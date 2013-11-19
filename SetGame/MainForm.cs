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
        private Game _game = new Game(1);

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            deal(12);
        }

        void cardPanel_Click(object sender, EventArgs e)
        {
            CardPanel cardPanel = sender as CardPanel;
            if (cardPanel == null)
                return;

            cardPanel.Selected = !cardPanel.Selected;
            cardPanel.Invalidate();

            var selected = flowLayoutPanel1.Controls.OfType<CardPanel>().Where(cp => cp.Selected).ToList();
            if (selected.Count == 3)
            {
                if (!_game.Validate(selected[0].Card, selected[1].Card, selected[2].Card))
                {
                    foreach (var cp in selected)
                    {
                        cp.Selected = false;
                        cp.Invalidate();
                    }
                    _game.PenalizePlayer(0);
                }
                else
                {
                    foreach (var cp in selected)
                        flowLayoutPanel1.Controls.Remove(cp);
                    _game.IncrementScore(0);

                    if (flowLayoutPanel1.Controls.Count < 12)
                        deal(3);
                    else
                        checkOptions();
                }
            }
        }

        void deal(int n)
        {
            flowLayoutPanel1.Controls.AddRange(_game.Deal(n)
                .Select(c =>
                {
                    var cardPanel = new CardPanel(c)
                    {
                        Width = flowLayoutPanel1.Width / 3 - 20,
                        Height = flowLayoutPanel1.Height / 5 - 20
                    };
                    cardPanel.Click += new EventHandler(cardPanel_Click);
                    return cardPanel;
                }).ToArray());

            checkOptions();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            deal(3);
        }

        private void checkOptions()
        {
            var choices = _game.GetOptions(Cards);
            label1.Text = choices.Count > 0 ? "" : "No options left.";
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
                panel.Invalidate();
            }
        }
    }
}
