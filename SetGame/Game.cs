﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SetGame
{
    class Game
    {
        private const int ShotClockLimit = 5;

        private List<Card> _deck;
        private List<Card> _board = new List<Card>();
        private List<HashSet<Card>> _sets = new List<HashSet<Card>>();
        private List<Player> _players = new List<Player>();
        private bool _started = false;
        private int _reservation = -1;
        private Timer _timer = new Timer();
        private int _shotClock;

        public Game()
        {
            initDeck();

            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Colour == Colours.Second)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Colour == Colours.Third)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Colour == Colours.First)));

            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Shade == Shades.Empty)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Shade == Shades.Half)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Shade == Shades.Solid)));

            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Shape == ShapeID.Beta)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Shape == ShapeID.Alpha)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Shape == ShapeID.Gamma)));

            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Number == Numbers.One)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Number == Numbers.Two)));
            _sets.Add(new HashSet<Card>(_deck.Where(c => c.Number == Numbers.Three)));

            _timer.Interval = 1000;
            _timer.Tick += new EventHandler(_timer_Tick);
        }

        public event Action BoardModified = () => { };
        public event Action ScoresChanged = () => { };
        public event Action PlayersChanged = () => { };
        public event Action<int> BeginSet = (p) => { };
        public event Action<int> ShotClockTick = (i) => { };
        public event Action EndSet = () => { };
        public event Action GameOver = () => { };

        public bool Active
        {
            get { return _started; }
        }
        
        public int PlayerCount
        {
            get { return _players.Count; }
        }

        public string[] Names
        {
            get { return _players.Select(p => p.Name).ToArray(); }
        }

        public int[] Scores
        {
            get { return _players.Select(p => p.Score).ToArray(); }
        }

        public IEnumerable<Card> Board
        {
            get { return _board; }
        }

        public void AddPlayer(Player player)
        {
            if (_started)
                return;

            _players.Add(player);
            PlayersChanged();
        }

        public void BeginGame()
        {
            if (_started || _players.Count == 0)
                return;

            _started = true;
            initDeck();
            replenishBoard();
        }

        public void EndGame()
        {
            if (!_started)
                return;

            _board.Clear();
            _players.Clear();
            GameOver();
        }

        public void Reserve(int player)
        {
            if (_started && _reservation < 0)
            {
                _reservation = player;
                _shotClock = ShotClockLimit;

                BeginSet(_reservation);
                ShotClockTick(_shotClock);
                _timer.Start();
            }
        }

        public List<Card> Deal(int n)
        {
            var result = _deck.Take(n).ToList();
            if (result.Count > 0)
                _deck.RemoveRange(0, result.Count);

            _board.AddRange(result);
            BoardModified();

            return result;
        }

        public bool MakePlay(int player, Card c1, Card c2, Card c3)
        {
            if (_reservation < 0)
                return false;
            _timer.Stop();
            _reservation = -1;
            EndSet();

            HashSet<Card> choice = new HashSet<Card>(new[] { c1, c2, c3 });
            if (validate(choice))
            {
                _board.RemoveAll(c => choice.Contains(c));
                replenishBoard();

                IncrementScore(player);

                if (_deck.Count == 0 && GetOptions(_board).Count == 0)
                    EndGame();
                return true;
            }
            else
            {
                PenalizePlayer(player);
                return false;
            }
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();

            if (_reservation >= 0)
            {
                if (--_shotClock == 0)
                {
                    PenalizePlayer(_reservation);
                    EndSet();
                    _reservation = -1;
                }
                else
                {
                    ShotClockTick(_shotClock);
                    _timer.Start();
                }
            }
        }

        private bool validate(HashSet<Card> choice)
        {
            if (choice.Count != 3)
                return false;
            var list = _sets.Select(s => s.Intersect(choice).Count()).ToList();
            return !list.Contains(2);
        }

        public HashSet<Card> GetOptions(IEnumerable<Card> set)
        {
            return set.PowerSet(3, 3).Where(s => validate(s))
                .Aggregate(new HashSet<Card>(), (a, s) => { a.UnionWith(s); return a; });
        }

        public void IncrementScore(int player)
        {
            _players[player].Score += 3;
            ScoresChanged();
        }

        public void PenalizePlayer(int player)
        {
            _players[player].Score--;
            ScoresChanged();
        }

        private void initDeck()
        {
            Random rand = new Random();
            _deck = Card.GenerateDeck().OrderBy(c => rand.Next()).ToList();
        }

        private void replenishBoard()
        {
            while (_deck.Count > 0 && (_board.Count < 12 || GetOptions(_board).Count == 0))
            {
                Deal(3);
            }
        }
    }

    static partial class Extensions
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
