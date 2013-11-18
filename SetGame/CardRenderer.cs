using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SetGame
{
    static class CardRenderer
    {
        public static Point[] GetPolygon(Shapes shape)
        {
            switch (shape)
            {
                case Shapes.Diamond:
                    return new[] {
                        new Point(0, -20),
                        new Point(10, 0),
                        new Point(0, 20),
                        new Point(-10, 0)
                    };
                case Shapes.Pill:
                    return new[] {
                        new Point(10, -20),
                        new Point(10, 20),
                        new Point(-10, 20),
                        new Point(-10, -20)
                    };
                case Shapes.Tilde:
                    return new[] {
                        new Point(5, -20),
                        new Point(15, -10),
                        new Point(-5, 10),
                        new Point(5, 20),
                        new Point(-5, 20),
                        new Point(-15, 10),
                        new Point(5, -10),
                        new Point(-5, -20)
                    };
                default:
                    return null;
            }
        }

        public static Color GetColor(Colours colour)
        {
            switch (colour)
            {
                case Colours.Green:
                    return Color.Green;
                case Colours.Purple:
                    return Color.Purple;
                case Colours.Red:
                    return Color.Red;
                default:
                    return Color.Black;
            }
        }

        public static Brush GetBrush(Color color, Shades shade)
        {
            switch (shade)
            {
                case Shades.Empty:
                    return Brushes.White;
                case Shades.Half:
                    return new HatchBrush(HatchStyle.NarrowHorizontal, color, Color.Transparent);
                case Shades.Solid:
                    return new SolidBrush(color);
                default:
                    return null;
            }
        }
    }
}
