using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SetGame
{
    public partial class DebugDlg : Form
    {
        public DebugDlg()
        {
            InitializeComponent();
        }

        private Game _game;
        public Game Game
        {
            get { return _game; }
            set
            {
                if (_game != null)
                {
                    this.Enabled = false;
                    _game.BoardModified -= _game_BoardModified;
                }

                _game = value;

                if (_game != null)
                {
                    this.Enabled = true;
                    _game.BoardModified += _game_BoardModified;
                }
            }
        }

        void _game_BoardModified()
        {
            _txtBoard.Text = string.Join("\r\n", Game.Board.Select(c => deparse(c.ToString())));
            _txtDeck.Text = string.Join("\r\n", Game.Deck.Select(c => deparse(c.ToString())));
        }

        private void DebugDlg_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void _btnUpdateBoard_Click(object sender, EventArgs e)
        {
            var dict = getDict();
            Game.Board = linify(_txtBoard.Text).Select(l => new Card(l, dict));
        }

        private List<string> linify(string text)
        {
            List<string> lines = new List<string>();
            using (var reader = new StringReader(text))
            {
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    lines.Add(line);
                }
            }
            return lines;
        }

        private Dictionary<char, char> getDict()
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            parse(_txtColours.Text, dict);
            parse(_txtShapes.Text, dict);
            parse(_txtShades.Text, dict);
            parse(_txtNumbers.Text, dict);
            return dict;
        }

        private void parse(string str, Dictionary<char, char> dict)
        {
            for (int c = 0; c < str.Length; c++)
            {
                dict[str[c]] = (char)('1' + c);
            }
        }

        private string deparse(string str)
        {
            var arr = str.Select(c => c - '1').ToArray();
            return _txtColours.Text[arr[0]].ToString()
                + _txtShades.Text[arr[1]].ToString()
                + _txtShapes.Text[arr[2]].ToString()
                + _txtNumbers.Text[arr[3]].ToString();
        }

        private void _btnUpdateDeck_Click(object sender, EventArgs e)
        {
            var dict = getDict();
            Game.Deck = linify(_txtDeck.Text).Select(l => new Card(l, dict));
        }

        private void _txtColours_TextChanged(object sender, EventArgs e)
        {
            if (_txtColours.Text.Length < 3)
                _txtColours.Text += new string(' ', 3 - _txtColours.Text.Length);
            _game_BoardModified();
        }

        private void _txtShapes_TextChanged(object sender, EventArgs e)
        {
            if (_txtShapes.Text.Length < 3)
                _txtShapes.Text += new string(' ', 3 - _txtShapes.Text.Length);
            _game_BoardModified();
        }

        private void _txtShades_TextChanged(object sender, EventArgs e)
        {
            if (_txtShades.Text.Length < 3)
                _txtShades.Text += new string(' ', 3 - _txtShades.Text.Length);
            _game_BoardModified();
        }

        private void _txtNumbers_TextChanged(object sender, EventArgs e)
        {
            if (_txtNumbers.Text.Length < 3)
                _txtNumbers.Text += new string(' ', 3 - _txtNumbers.Text.Length);
            _game_BoardModified();
        }

        private void export(IEnumerable<string> lines)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            if (sfd.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
                return;

            using (var writer = new StreamWriter(sfd.OpenFile()))
            {
                writer.WriteLine(_txtColours.Text.Substring(0, 3));
                writer.WriteLine(_txtShapes.Text.Substring(0, 3));
                writer.WriteLine(_txtShades.Text.Substring(0, 3));
                writer.WriteLine(_txtNumbers.Text.Substring(0, 3));
                writer.WriteLine();
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }

        private void _btnBoardExport_Click(object sender, EventArgs e)
        {
            export(linify(_txtBoard.Text));
        }

        private void _btnDeckExport_Click(object sender, EventArgs e)
        {
            export(linify(_txtDeck.Text));
        }

        private void _btnExportBoth_Click(object sender, EventArgs e)
        {
            export(new[] { linify(_txtBoard.Text), linify(_txtDeck.Text) }.SelectMany(l => l));
        }
    }
}
