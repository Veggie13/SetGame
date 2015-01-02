using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SetGame
{
    public interface IControlHandler
    {
        event Action SetRequest;
    }

    public class LocalControlHandler : IControlHandler
    {
        public interface IControlProvider
        {
            event Action SetRequestClicked;
            event Action RightMouseClicked;
            event Action<char> KeyPressed;
        }

        #region Constructors
        public LocalControlHandler()
        {
            UseRightMouseButton = false;
            Key = '\0';
        }
        
        public LocalControlHandler(IControlProvider controlProvider, char key = '\0')
        {
            UseRightMouseButton = false;
            Key = key;
            ControlProvider = controlProvider;
        }
        #endregion

        #region IControlHandler
        public event Action SetRequest = delegate { };
        #endregion

        #region Properties
        public IControlProvider ControlProvider
        {
            set
            {
                value.SetRequestClicked += new Action(controlProvider_SetRequestClicked);
                value.RightMouseClicked += new Action(controlProvider_RightMouseClicked);
                value.KeyPressed += new Action<char>(controlProvider_KeyPressed);
            }
        }

        public bool UseSetButton
        {
            get;
            set;
        }

        public bool UseRightMouseButton
        {
            get;
            set;
        }

        public char Key
        {
            get;
            set;
        }
        #endregion

        #region Event Handlers
        private void controlProvider_SetRequestClicked()
        {
            if (UseSetButton)
            {
                SetRequest();
            }
        }

        private void controlProvider_KeyPressed(char key)
        {
            if (key.ToString().ToLower() == Key.ToString().ToLower())
            {
                SetRequest();
            }
        }

        private void controlProvider_RightMouseClicked()
        {
            if (UseRightMouseButton)
            {
                SetRequest();
            }
        }
        #endregion
    }
}
