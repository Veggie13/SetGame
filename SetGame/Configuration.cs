using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetGame
{
    [Serializable]
    public class Configuration
    {
        public CardRenderer DisplayOptions
        {
            get;
            set;
        }

        public LocalControlHandler ControlOptions
        {
            get;
            set;
        }
    }
}
