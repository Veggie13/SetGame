using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetGame
{
    class Player
    {
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public string Name
        {
            get;
            private set;
        }

        public int Score
        {
            get;
            set;
        }
    }
}
