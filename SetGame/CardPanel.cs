using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace SetGame
{
    class CardPanel : Panel
    {
        public CardPanel(Card card)
        {
            CardWidth = 150;
            CardHeight = 100;

            Card = card;

            this.Paint += new PaintEventHandler(CardPanel_Paint);
        }

        void CardPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(Width / 2, Height / 2);

            var rect = new Rectangle(-CardWidth / 2, -CardHeight / 2, CardWidth, CardHeight);
            e.Graphics.FillRectangle(Brushes.White, rect);
            e.Graphics.DrawRectangle(new Pen(Selected ? Color.Orange : Color.Black, 3f), rect);

            var poly = CardRenderer.GetPolygon(Card.Shape);
            var color = CardRenderer.GetColor(Card.Colour);
            var inner = CardRenderer.GetBrush(color, Card.Shade);
            var outer = new Pen(color, 2f);

            int num = (int)Card.Number;

            e.Graphics.TranslateTransform(-15f * (num - 1), 0f);
            for (int i = 0; i < num; i++)
            {
                drawPoly(e.Graphics, poly, inner, outer);
                e.Graphics.TranslateTransform(30f, 0f);
            }
        }

        private void drawPoly(Graphics g, Point[] poly, Brush inner, Pen outer)
        {
            g.FillPolygon(inner, poly);
            g.DrawPolygon(outer, poly);
        }

        [Browsable(false)]
        public Card Card
        {
            get;
            private set;
        }

        [DefaultValue(false)]
        public bool Selected
        {
            get;
            set;
        }

        [DefaultValue(150)]
        public int CardWidth
        {
            get;
            set;
        }

        [DefaultValue(100)]
        public int CardHeight
        {
            get;
            set;
        }
    }
}
