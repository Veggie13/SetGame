using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Xml.Serialization;

namespace SetGame
{
    public partial class MainForm : Form, LocalControlHandler.IControlProvider
    {
        #region Class Members
        private Game _game = new Game();
        private bool _inSet = false;
        private HashSet<Player> _localPlayers = new HashSet<Player>();
        private Configuration _config = new Configuration();
        #endregion

        public MainForm()
        {
            InitializeComponent();

            _config.ControlOptions = new LocalControlHandler(this)
                {
                    UseSetButton = true,
                    UseRightMouseButton = true,
                    Key = 'S'
                };
            _config.DisplayOptions = new CardRenderer(Shapes.Pill, Shapes.Diamond, Shapes.ZigZag, Color.Red, Color.Green, Color.Purple);

            _game.BoardModified += new Action(_game_BoardModified);
            _game.BeginSet += new Action<Player>(_game_BeginSet);
            _game.SuccessfulSet += new Action<Card, Card, Card>(_game_SuccessfulSet);
            _game.FailedSet += new Action(_game_FailedSet);
            _game.ScoresChanged += new Action(_game_ScoresChanged);
            _game.PlayersChanged += new Action(_game_PlayersChanged);
            _game.ShotClockTick += new Action<int>(_game_ShotClockTick);
            _game.GameOver += new Action(_game_GameOver);

            setupKeyEvents(this);
        }

        #region Properties
        IEnumerable<CardPanel> CardPanels
        {
            get
            {
                return _flowBoard.Controls.OfType<CardPanel>();
            }
        }

        IEnumerable<Card> Cards
        {
            get
            {
                return CardPanels.Select(cp => cp.Card);
            }
        }

        string ConfigurationPath
        {
            get
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(path, "SetGame");
            }
        }

        string ConfigurationFilePath
        {
            get
            {
                return Path.Combine(ConfigurationPath, "config.xml");
            }
        }
        #endregion

        #region IControlProvider
        public event Action SetRequestClicked = delegate { };

        public event Action RightMouseClicked = delegate { };

        public event Action<char> KeyPressed = delegate { };
        #endregion

        #region Event Handlers
        #region MainForm
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadConfiguration();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressed(e.KeyChar);
            e.Handled = true;
        }
        #endregion

        #region Game
        private void _game_GameOver()
        {
            _btnSet.Enabled = _btnHint.Enabled = false;
            _lblMessages.Text = _lblScore.Text = _lblCountdown.Text = "";
            _flowBoard.Controls.Clear();

            Label message = new Label();
            message.Size = _flowBoard.Size;
            message.Font = new Font("Arial", 30f, FontStyle.Bold);
            message.ForeColor = Color.Red;
            message.TextAlign = ContentAlignment.MiddleCenter;

            message.Text = "GAME OVER\r\nNo sets remain\r\n";
            foreach (var player in Enumerable.Range(0, _game.PlayerCount)
                .Select(i => new Tuple<string, int>(_game.Names[i], _game.Scores[i]))
                .OrderByDescending(p => p.Item2))
            {
                message.Text += string.Format("\r\n{0}: {1}", player.Item1, player.Item2);
            }

            _flowBoard.Controls.Add(message);
        }

        private void _game_ShotClockTick(int count)
        {
            _lblCountdown.Text = count.ToString();
        }

        private void _game_PlayersChanged()
        {
            printScores();
        }

        private void _game_ScoresChanged()
        {
            printScores();
        }

        private void _game_SuccessfulSet(Card card1, Card card2, Card card3)
        {
            foreach (CardPanel cp in _flowBoard.Controls)
            {
                cp.Selected = (cp.Card.Equals(card1) || cp.Card.Equals(card2) || cp.Card.Equals(card3));
            }

            // Take a moment to bask in the set you've chosen...
            Application.DoEvents();
            Thread.Sleep(1000);

            finishInSet();
        }

        private void _game_FailedSet()
        {
            finishInSet();
        }

        private void _game_BeginSet(Player player)
        {
            if (_localPlayers.Contains(player))
            {
                _inSet = true;
                _pnlBoard.BackColor = Color.Orange;
            }
            else
            {
                _pnlBoard.BackColor = Color.Red;
            }

            _btnSet.Enabled = false;
            _btnHint.Enabled = false;
            this.Focus();
        }

        private void _game_BoardModified()
        {
            _btnSet.Enabled = false;
            _btnHint.Enabled = false;
            _flowBoard.Controls.Clear();
            _flowBoard.Controls.AddRange(_game.Board
                .Select(c =>
                {
                    var cardPanel = new CardPanel(c)
                    {
                        Width = _flowBoard.Width / 3 - 20,
                        Height = _flowBoard.Height / 5 - 20,
                        Renderer = _config.DisplayOptions
                    };
                    cardPanel.MouseClick += new MouseEventHandler(cardPanel_MouseClick);
                    return cardPanel;
                }).ToArray());
            _btnSet.Enabled = true;
            _btnHint.Enabled = true;
        }
        #endregion

        #region Controls
        private void cardPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RightMouseClicked();
            }

            CardPanel cardPanel = sender as CardPanel;
            if (!_inSet || cardPanel == null)
                return;

            cardPanel.Selected = !cardPanel.Selected;

            var selected = CardPanels.Where(cp => cp.Selected).ToList();
            if (selected.Count == 3)
            {
                _game.MakePlay(selected[0].Card, selected[1].Card, selected[2].Card);
            }
        }

        private void _btnSet_Click(object sender, EventArgs e)
        {
            SetRequestClicked();
        }

        private void _btnHint_Click(object sender, EventArgs e)
        {
            var choices = _game.GetOptions(Cards);
            if (choices.Count > 0)
            {
                foreach (var cp in CardPanels)
                    cp.Selected = false;

                Random rand = new Random();
                var panel = CardPanels.Where(cp => choices.Contains(cp.Card)).OrderBy(cp => rand.Next()).First();
                panel.Selected = true;
            }
            this.Focus();
        }
        #endregion

        #region Menu Items
        private void _itmOptionsDisplay_Click(object sender, EventArgs e)
        {
            var dlg = new DisplayOptionsDlg(_config.DisplayOptions);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                saveConfiguration();
                Invalidate(true);
            }
        }

        private void _itmOptionsControls_Click(object sender, EventArgs e)
        {
            var dlg = new ControlOptionsDlg(_config.ControlOptions);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                saveConfiguration();
            }
        }

        private void _itmGameNewSingle_Click(object sender, EventArgs e)
        {
            if (_game.Active)
                finishGame();

            _localPlayers.Add(new Player("Score")
                {
                    ControlHandler = _config.ControlOptions
                });

            foreach (Player p in _localPlayers)
                _game.AddPlayer(p);
            _game.BeginGame();
        }
        #endregion
        #endregion

        #region Private Helpers
        private void printScores()
        {
            _lblScore.Text = string.Format("{0}: {1}", _game.Names[0], _game.Scores[0]);
        }

        private void setupKeyEvents(Control c)
        {
            foreach (Control child in c.Controls)
            {
                setupKeyEvents(child);
            }

            c.KeyPress += new KeyPressEventHandler(MainForm_KeyPress);
        }

        private void finishInSet()
        {
            _inSet = false;
            _lblCountdown.Text = "";
            foreach (var cp in CardPanels)
                cp.Selected = false;
            _pnlBoard.BackColor = Control.DefaultBackColor;
            _pnlBoard.Focus();
            _btnSet.Enabled = true;
            _btnHint.Enabled = true;
        }

        private void finishGame()
        {
            _game.EndGame();
            foreach (Player p in _localPlayers)
                p.Dispose();
            _localPlayers.Clear();
        }

        private void loadConfiguration()
        {
            try
            {
                using (var stream = new FileStream(ConfigurationFilePath, FileMode.Open, FileAccess.Read))
                {
                    var serializer = new XmlSerializer(typeof(Configuration));
                    _config = (Configuration)serializer.Deserialize(stream);
                }
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(ConfigurationPath);
                saveConfiguration();
            }
            catch (Exception)
            {
                saveConfiguration();
            }

            _config.ControlOptions.ControlProvider = this;
        }

        private void saveConfiguration()
        {
            using (var stream = new FileStream(ConfigurationFilePath, FileMode.Create, FileAccess.Write))
            {
                var serializer = new XmlSerializer(typeof(Configuration));
                serializer.Serialize(stream, _config);
            }
        }
        #endregion
    }
}
