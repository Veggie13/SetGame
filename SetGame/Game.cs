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
            if (result.Count > 0)
                _deck.RemoveRange(0, result.Count);
            return result;
        }

        public bool Validate(Card c1, Card c2, Card c3)
        {
            HashSet<Card> choice = new HashSet<Card>(new[] { c1, c2, c3 });
            return validate(choice);
        }

        private bool validate(HashSet<Card> choice)
        {
            if (choice.Count != 3)
                return false;
            return !_sets.Select(s => s.Intersect(choice).Count()).Contains(2);
        }

        public HashSet<Card> GetOptions(IEnumerable<Card> set)
        {
            return set.PowerSet(3, 3).Where(s => validate(s))
                .Aggregate(new HashSet<Card>(), (a, s) => { a.UnionWith(s); return a; });
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

    static class Extensions
    {
        public static List<HashSet<T>> PowerSet<T>(this IEnumerable<T> startingSet, int minSubsetSize, int maxSize)
        {
            List<HashSet<T>> subsetList = new List<HashSet<T>>();

            //The set bits of each intermediate value represent unique 
            //combinations from the startingSet.
            //We can start checking for combinations at (1<<minSubsetSize)-1 since
            //values less than that will not yield large enough subsets.
            int count = startingSet.Count();
            int iLimit = 1 << count;
            for (int i = (1 << minSubsetSize) - 1; i < iLimit; i++)
            {
                //Get the number of 1's in this 'i'
                int setBitCount = SetBitCount(i);

                //Only include this subset if it will have at least minSubsetSize members.
                if (setBitCount >= minSubsetSize && setBitCount <= maxSize)
                {
                    HashSet<T> subset = new HashSet<T>();

                    int j = 0;
                    foreach (var item in startingSet)
                    {
                        //If the j'th bit in i is set, 
                        //then add the j'th element of the startingSet to this subset.
                        if ((i & (1 << j++)) != 0)
                        {
                            subset.Add(item);
                        }
                    }
                    subsetList.Add(subset);
                }
            }
            return subsetList;
        }

        static int SetBitCount(Int32 i)
        {
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
        }
    }
}
