using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SetGame
{
    partial class ControlOptionsDlg : Form
    {
        #region Class Members
        private LocalControlHandler _handler;
        #endregion

        public ControlOptionsDlg(LocalControlHandler handler)
        {
            InitializeComponent();

            _handler = handler;
        }

        #region Properties
        private bool SetWithKey { get { return _chkKey.Checked; } }
        private bool SetWithRightClick { get { return _chkRightClick.Checked; } }
        private char Key { get { return _txtKey.Text[0]; } }
        #endregion

        #region Event Handlers
        private void ControlOptionsDlg_Load(object sender, EventArgs e)
        {
            _chkKey.Checked = (_handler.Key != '\0');
            _txtKey.Text = !_chkKey.Checked ? "" : _handler.Key.ToString().ToUpper();

            _chkRightClick.Checked = _handler.UseRightMouseButton;
        }

        private void _chkKey_CheckedChanged(object sender, EventArgs e)
        {
            _txtKey.Text = _chkKey.Checked ? "S" : "";
            _txtKey.Enabled = _chkKey.Checked;
        }

        private void _txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            _txtKey.Text = e.KeyChar.ToString().ToUpper();
            e.Handled = true;
        }

        private void _txtKey_TextChanged(object sender, EventArgs e)
        {
            if (_txtKey.Text.Equals("") && _chkKey.Checked)
            {
                _txtKey.Text = "S";
            }
        }

        private void _btnOK_Click(object sender, EventArgs e)
        {
            _handler.UseRightMouseButton = SetWithRightClick;
            _handler.Key = SetWithKey ? Key : '\0';

            Close();
        }
        #endregion
    }
}
