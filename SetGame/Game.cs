using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetGame
{
    class Game
    {
        private List<Card> _deck;
        private List<HashSet<Card>> _sets = new List<HashSet<Card>>();
        private int[] _scores;

        public Game(int playerCount)
        {
            Random rand = new Random();
            _deck = Card.GenerateDeck().OrderBy(c => rand.Next()).ToList();

            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Colour == Colours.Green)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Colour == Colours.Purple)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Colour == Colours.Red)));

            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Shade == Shades.Empty)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Shade == Shades.Half)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Shade == Shades.Solid)));

            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Shape == Shapes.Diamond)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Shape == Shapes.Pill)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Shape == Shapes.Tilde)));

            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Number == Numbers.One)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Number == Numbers.Two)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Number == Numbers.Three)));

            _scores = new int[playerCount];
        }

        public List<Card> Deal(int n)
        {
            var result = _deck.Take(n).ToList();
            _deck.RemoveRange(0, n);
            return result;
        }

        public bool Validate(Card c1, Card c2, Card c3)
        {
            HashSet<Card> choice = new HashSet<Card>(new[] { c1, c2, c3 });
            return !_sets.Select(s => s.Intersect(choice).Count()).Contains(2);
        }

        public void IncrementScore(int player)
        {
            _scores[player] += 3;
        }

        public void PenalizePlayer(int player)
        {
            _scores[player]--;
        }

        public int[] Scores
        {
            get { return _scores; }
        }
    }
}
