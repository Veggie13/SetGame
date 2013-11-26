using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SetGame
{
    public partial class MainForm : Form
    {
        #region Class Members
        private Game _game = new Game();
        private CardRenderer _renderer = new CardRenderer(Shapes.Pill, Shapes.Diamond, Shapes.ZigZag, Color.Red, Color.Green, Color.Purple);
        private bool _inSet = false;
        #endregion

        public MainForm()
        {
            InitializeComponent();

            _game.BoardModified += new Action(_game_BoardModified);
            _game.BeginSet += new Action<int>(_game_BeginSet);
            _game.EndSet += new Action(_game_EndSet);
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
        #endregion

        #region Event Handlers
        #region MainForm
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_game.Active && !_inSet && e.KeyChar.ToString().ToLower() == "s")
            {
                callSet();
                e.Handled = true;
            }
        }
        #endregion

        #region Game
        private void _game_GameOver()
        {
            _btnSet.Enabled = _btnHint.Enabled = false;
            _lblMessages.Text = _lblScore.Text = _lblCountdown.Text = "";
            _flowBoard.Controls.Clear();
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

        private void _game_EndSet()
        {
            _inSet = false;
            _lblCountdown.Text = "";
            foreach (var cp in CardPanels)
                cp.Selected = false;
            _pnlBoard.BackColor = Control.DefaultBackColor;
            _pnlBoard.Focus();
        }

        private void _game_BeginSet(int obj)
        {
            _inSet = true;
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
                        Renderer = _renderer
                    };
                    cardPanel.Click += new EventHandler(cardPanel_Click);
                    return cardPanel;
                }).ToArray());
            _btnSet.Enabled = true;
            _btnHint.Enabled = true;
        }
        #endregion

        #region Controls
        private void cardPanel_Click(object sender, EventArgs e)
        {
            CardPanel cardPanel = sender as CardPanel;
            if (!_inSet || cardPanel == null)
                return;

            cardPanel.Selected = !cardPanel.Selected;

            var selected = CardPanels.Where(cp => cp.Selected).ToList();
            if (selected.Count == 3)
            {
                _game.MakePlay(0, selected[0].Card, selected[1].Card, selected[2].Card);
            }
        }

        private void _btnSet_Click(object sender, EventArgs e)
        {
            callSet();
            this.Focus();
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
            var dlg = new DisplayOptionsDlg(_renderer);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Invalidate(true);
            }
        }

        private void _itmGameNewSingle_Click(object sender, EventArgs e)
        {
            if (_game.Active)
                _game.EndGame();

            _game.AddPlayer(new Player("Player 1"));
            _game.BeginGame();
        }
        #endregion
        #endregion

        #region Private Helpers
        private void printScores()
        {
            _lblScore.Text = string.Format("{0}: {1}", _game.Names[0], _game.Scores[0]);
        }

        private void callSet()
        {
            _pnlBoard.BackColor = Color.Orange;
            _game.Reserve(0);
        }

        private void setupKeyEvents(Control c)
        {
            foreach (Control child in c.Controls)
            {
                setupKeyEvents(child);
            }

            c.KeyPress += new KeyPressEventHandler(MainForm_KeyPress);
        }
        #endregion
    }
}
