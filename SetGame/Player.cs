using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetGame
{
    public class Player : IDisposable
    {
        private IControlHandler _controlHandler = null;

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public event Action<Player> SetRequested = delegate { };

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

        public IControlHandler ControlHandler
        {
            get { return _controlHandler; }
            set
            {
                if (_controlHandler != null)
                {
                    _controlHandler.SetRequest -= _controlHandler_SetRequest;
                }

                _controlHandler = value;

                if (_controlHandler != null)
                {
                    _controlHandler.SetRequest += new Action(_controlHandler_SetRequest);
                }
            }
        }

        public void Dispose()
        {
            ControlHandler = null;
        }

        private void _controlHandler_SetRequest()
        {
            SetRequested(this);
        }
    }
}
