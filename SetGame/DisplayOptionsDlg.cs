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
    partial class DisplayOptionsDlg : Form
    {
        private static readonly Dictionary<Shapes, string> ShapeNames = new Dictionary<Shapes, string>();

        static DisplayOptionsDlg()
        {
            ShapeNames[Shapes.Chevron] = "Chevron";
            ShapeNames[Shapes.Crescent] = "Crescent";
            ShapeNames[Shapes.Diamond] = "Diamond";
            ShapeNames[Shapes.HourGlass] = "Hour Glass";
            ShapeNames[Shapes.Pill] = "Pill";
            ShapeNames[Shapes.ZigZag] = "Zig-Zag";
        }

        private bool _initializing = true;
        private CardRenderer _renderer;

        public DisplayOptionsDlg(CardRenderer renderer)
        {
            InitializeComponent();

            _renderer = renderer;
        }

        private Shapes SelectedShape1
        {
            get { return ((KeyValuePair<Shapes, string>)_cboShape1.SelectedItem).Key; }
            set { _cboShape1.SelectedValue = value; }
        }

        private Shapes SelectedShape2
        {
            get { return ((KeyValuePair<Shapes, string>)_cboShape2.SelectedItem).Key; }
            set { _cboShape2.SelectedValue = value; }
        }

        private Shapes SelectedShape3
        {
            get { return ((KeyValuePair<Shapes, string>)_cboShape3.SelectedItem).Key; }
            set { _cboShape3.SelectedValue = value; }
        }

        private void DisplayOptionsDlg_Load(object sender, EventArgs e)
        {
            // This is a weird initialization because of the constraint that the
            // combo boxes can't contain the others' selections. Initialize to the
            // unselected options with messages off, then set them properly after.

            Shapes[] notUsed = ShapeNames.Keys.Except(new[] {
                _renderer.ShapeAlpha, _renderer.ShapeBeta, _renderer.ShapeGamma
            }).ToArray();
            
            loadCombo(_cboShape1, notUsed[0]);
            loadCombo(_cboShape2, notUsed[1]);
            loadCombo(_cboShape3, notUsed[2]);

            _initializing = false;

            SelectedShape1 = _renderer.ShapeAlpha;
            SelectedShape2 = _renderer.ShapeBeta;
            SelectedShape3 = _renderer.ShapeGamma;

            // Colors

            _btnColor1.BackColor = _renderer.ColourFirst;
            _btnColor2.BackColor = _renderer.ColourSecond;
            _btnColor3.BackColor = _renderer.ColourThird;
        }

        private void ColorSelector_Click(object sender, EventArgs e)
        {
            selectColor(sender as Button);
        }

        private void _btnOK_Click(object sender, EventArgs e)
        {
            _renderer.ShapeAlpha = SelectedShape1;
            _renderer.ShapeBeta = SelectedShape2;
            _renderer.ShapeGamma = SelectedShape3;

            _renderer.ColourFirst = _btnColor1.BackColor;
            _renderer.ColourSecond = _btnColor2.BackColor;
            _renderer.ColourThird = _btnColor3.BackColor;
        }

        private void _shapePreview1_Paint(object sender, PaintEventArgs e)
        {
            drawPreview(e.Graphics, SelectedShape1);
        }

        private void _shapePreview2_Paint(object sender, PaintEventArgs e)
        {
            drawPreview(e.Graphics, SelectedShape2);
        }

        private void _shapePreview3_Paint(object sender, PaintEventArgs e)
        {
            drawPreview(e.Graphics, SelectedShape3);
        }

        private void _cboShape1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_initializing)
                return;

            loadCombo(_cboShape2, SelectedShape2, SelectedShape1, SelectedShape3);
            loadCombo(_cboShape3, SelectedShape3, SelectedShape1, SelectedShape2);

            _shapePreview1.Invalidate();
        }

        private void _cboShape2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_initializing)
                return;

            loadCombo(_cboShape1, SelectedShape1, SelectedShape2, SelectedShape3);
            loadCombo(_cboShape3, SelectedShape3, SelectedShape1, SelectedShape2);

            _shapePreview2.Invalidate();
        }

        private void _cboShape3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_initializing)
                return;

            loadCombo(_cboShape2, SelectedShape2, SelectedShape1, SelectedShape3);
            loadCombo(_cboShape1, SelectedShape1, SelectedShape3, SelectedShape2);

            _shapePreview3.Invalidate();
        }

        private void loadCombo(ComboBox cbo, Shapes val, params Shapes[] except)
        {
            bool init = _initializing;
            _initializing = true;

            Shapes? old = (cbo.SelectedValue == null) ? (Shapes?)null : (Shapes)cbo.SelectedValue;
            cbo.DataSource = ShapeNames.ExceptKeys(except).ToList();
            cbo.ValueMember = "Key";
            cbo.DisplayMember = "Value";
            if (old != null)
                cbo.SelectedValue = old.Value;

            _initializing = init;
            cbo.SelectedValue = val;
        }

        private void selectColor(Button btn)
        {
            ColorDialog dlg = new ColorDialog()
            {
                Color = btn.BackColor,
                SolidColorOnly = true,
                AnyColor = true,
                AllowFullOpen = true,
                FullOpen = true
            };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                btn.BackColor = dlg.Color;
            }
        }

        private void drawPreview(Graphics g, Shapes shape)
        {
            g.TranslateTransform(18, 24);

            g.DrawPolygon(new Pen(Color.Black, 2f), CardRenderer.GetPolygon(shape));
        }
    }

    static partial class Extensions
    {
        public static IEnumerable<KeyValuePair<T, U>> ExceptKeys<T, U>(this IEnumerable<KeyValuePair<T, U>> me, IEnumerable<T> keys)
        {
            return me.Where(p => !keys.Contains(p.Key));
        }
    }
}
