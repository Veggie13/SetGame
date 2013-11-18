using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetGame
{
    class Card
    {
        private PropertySet _properties;

        public Card(Colours colour, Shades shade, Shapes shape, Numbers number)
        {
            _properties = new PropertySet(
                (int)PropertyTypes.Colour, (int)colour,
                (int)PropertyTypes.Shade, (int)shade,
                (int)PropertyTypes.Shape, (int)shape,
                (int)PropertyTypes.Number, (int)number);
        }

        public static List<Card> GenerateDeck()
        {
            List<Card> deck = new List<Card>();

            foreach (Colours colour in Enum.GetValues(typeof(Colours)))
            {
                foreach (Shades shade in Enum.GetValues(typeof(Shades)))
                {
                    foreach (Shapes shape in Enum.GetValues(typeof(Shapes)))
                    {
                        foreach (Numbers number in Enum.GetValues(typeof(Numbers)))
                            deck.Add(new Card(colour, shade, shape, number));
                    }
                }
            }

            return deck;
        }

        public Colours Colour
        {
            get { return (Colours)_properties[PropertyTypes.Colour]; }
        }

        public Shades Shade
        {
            get { return (Shades)_properties[PropertyTypes.Shade]; }
        }

        public Shapes Shape
        {
            get { return (Shapes)_properties[PropertyTypes.Shape]; }
        }

        public Numbers Number
        {
            get { return (Numbers)_properties[PropertyTypes.Number]; }
        }

        public PropertySet Properties
        {
            get { return _properties; }
        }

        public override int GetHashCode()
        {
            return _properties.GetHashCode();
        }
    }
}
