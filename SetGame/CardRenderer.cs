using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SetGame
{
    class CardRenderer
    {
        private static readonly Dictionary<Shapes, Point[]> ShapeMap = new Dictionary<Shapes, Point[]>();
        
        static CardRenderer()
        {
            ShapeMap[Shapes.Pill] = new[] {
                new Point(10, -20),
                new Point(10, 20),
                new Point(-10, 20),
                new Point(-10, -20)
            };
            ShapeMap[Shapes.Diamond] = new[] {
                new Point(0, -20),
                new Point(10, 0),
                new Point(0, 20),
                new Point(-10, 0)
            };
            ShapeMap[Shapes.ZigZag] = new[] {
                new Point(5, -20),
                new Point(15, -10),
                new Point(-5, 10),
                new Point(5, 20),
                new Point(-5, 20),
                new Point(-15, 10),
                new Point(5, -10),
                new Point(-5, -20)
            };
            ShapeMap[Shapes.HourGlass] = new[] {
                new Point(10, -20),
                new Point(0, 0),
                new Point(10, 20),
                new Point(-10, 20),
                new Point(0, 0),
                new Point(-10, -20)
            };
            ShapeMap[Shapes.Chevron] = new[] {
                new Point(0, -20),
                new Point(10, 20),
                new Point(0, 10),
                new Point(-10, 20)
            };
            ShapeMap[Shapes.Crescent] = new[] {
                new Point(-10, -20),
                new Point(-5, -19),
                new Point(0, -17),
                new Point(5, -12),
                new Point(9, -4),
                new Point(10, 0),
                new Point(9, 4),
                new Point(5, 12),
                new Point(0, 17),
                new Point(-5, 19),
                new Point(-10, 20)
            };
        }

        private Dictionary<ShapeID, Shapes> _shapes = new Dictionary<ShapeID, Shapes>();
        private Dictionary<Colours, Color> _colours = new Dictionary<Colours, Color>();

        public CardRenderer(Shapes alpha, Shapes beta, Shapes gamma, Color first, Color second, Color third)
        {
            _shapes[ShapeID.Alpha] = alpha;
            _shapes[ShapeID.Beta] = beta;
            _shapes[ShapeID.Gamma] = gamma;

            _colours[Colours.First] = first;
            _colours[Colours.Second] = second;
            _colours[Colours.Third] = third;
        }

        public Point[] GetPolygon(ShapeID shape)
        {
            return ShapeMap[_shapes[shape]];
        }

        public Color GetColor(Colours colour)
        {
            return _colours[colour];
        }

        public Brush GetBrush(Colours colour, Shades shade)
        {
            switch (shade)
            {
                case Shades.Empty:
                    return Brushes.White;
                case Shades.Half:
                    return new HatchBrush(HatchStyle.NarrowHorizontal, GetColor(colour), Color.Transparent);
                case Shades.Solid:
                    return new SolidBrush(GetColor(colour));
                default:
                    return null;
            }
        }
    }
}
