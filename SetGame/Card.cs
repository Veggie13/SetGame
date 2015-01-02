using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetGame
{
    public class Card
    {
        #region Class Members
        private PropertySet _properties;
        #endregion

        public Card(Colours colour, Shades shade, ShapeID shape, Numbers number)
        {
            _properties = new PropertySet(
                (int)PropertyTypes.Colour, (int)colour,
                (int)PropertyTypes.Shade, (int)shade,
                (int)PropertyTypes.Shape, (int)shape,
                (int)PropertyTypes.Number, (int)number);
        }

        internal Card(string code, Dictionary<char, char> dict = null)
        {
            if (dict != null)
            {
                code = translate(code, dict);
            }

            _properties = new PropertySet(
                (int)PropertyTypes.Colour, (int)(code[0] - '0'),
                (int)PropertyTypes.Shade, (int)(code[1] - '0'),
                (int)PropertyTypes.Shape, (int)(code[2] - '0'),
                (int)PropertyTypes.Number, (int)(code[3] - '0'));
        }

        public static List<Card> GenerateDeck()
        {
            List<Card> deck = new List<Card>();

            foreach (Colours colour in Enum.GetValues(typeof(Colours)))
            {
                foreach (Shades shade in Enum.GetValues(typeof(Shades)))
                {
                    foreach (ShapeID shape in Enum.GetValues(typeof(ShapeID)))
                    {
                        foreach (Numbers number in Enum.GetValues(typeof(Numbers)))
                            deck.Add(new Card(colour, shade, shape, number));
                    }
                }
            }

            return deck;
        }

        #region Properties
        public Colours Colour
        {
            get { return (Colours)_properties[PropertyTypes.Colour]; }
        }

        public Shades Shade
        {
            get { return (Shades)_properties[PropertyTypes.Shade]; }
        }

        public ShapeID Shape
        {
            get { return (ShapeID)_properties[PropertyTypes.Shape]; }
        }

        public Numbers Number
        {
            get { return (Numbers)_properties[PropertyTypes.Number]; }
        }

        public PropertySet Properties
        {
            get { return _properties; }
        }
        #endregion

        #region Overrides
        public override bool Equals(object obj)
        {
            if (obj is Card)
            {
                Card other = (Card)obj;
                return GetHashCode() == other.GetHashCode();
            }
            return false;
        }
        
        public override int GetHashCode()
        {
            return _properties.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}", (int)Colour, (int)Shade, (int)Shape, (int)Number);
        }
        #endregion

        #region Private Helpers
        private string translate(string str, Dictionary<char, char> translator)
        {
            foreach (var key in translator.Keys)
            {
                str = str.Replace(key, translator[key]);
            }
            return str;
        }
        #endregion
    }
}
