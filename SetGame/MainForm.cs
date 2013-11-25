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
                return flowLayoutPanel1.Controls.OfType<CardPanel>();
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
            button1.Enabled = button2.Enabled = false;
            label1.Text = label2.Text = label3.Text = "";
            flowLayoutPanel1.Controls.Clear();
        }

        private void _game_ShotClockTick(int count)
        {
            label3.Text = count.ToString();
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
            label3.Text = "";
            foreach (var cp in CardPanels)
                cp.Selected = false;
            panel1.BackColor = Control.DefaultBackColor;
            panel1.Focus();
        }

        private void _game_BeginSet(int obj)
        {
            _inSet = true;
        }

        private void _game_BoardModified()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(_game.Board
                .Select(c =>
                {
                    var cardPanel = new CardPanel(c)
                    {
                        Width = flowLayoutPanel1.Width / 3 - 20,
                        Height = flowLayoutPanel1.Height / 5 - 20,
                        Renderer = _renderer
                    };
                    cardPanel.Click += new EventHandler(cardPanel_Click);
                    return cardPanel;
                }).ToArray());
            button1.Enabled = true;
            button2.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            callSet();
            this.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
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
        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new DisplayOptionsDlg(_renderer);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                Invalidate(true);
            }
        }

        private void newSinglePlayerToolStripMenuItem_Click(object sender, EventArgs e)
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
            label2.Text = string.Format("{0}: {1}", _game.Names[0], _game.Scores[0]);
        }

        private void callSet()
        {
            panel1.BackColor = Color.Orange;
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
