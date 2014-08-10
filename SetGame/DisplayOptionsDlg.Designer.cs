namespace SetGame
{
    partial class DisplayOptionsDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._cboShape1 = new System.Windows.Forms.ComboBox();
            this._shapePreview1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._shapePreview3 = new System.Windows.Forms.Panel();
            this._shapePreview2 = new System.Windows.Forms.Panel();
            this._cboShape3 = new System.Windows.Forms.ComboBox();
            this._cboShape2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnColor1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._btnColor2 = new System.Windows.Forms.Button();
            this._btnColor3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cboShape1
            // 
            this._cboShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cboShape1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboShape1.FormattingEnabled = true;
            this._cboShape1.Location = new System.Drawing.Point(49, 24);
            this._cboShape1.Name = "_cboShape1";
            this._cboShape1.Size = new System.Drawing.Size(128, 21);
            this._cboShape1.Sorted = true;
            this._cboShape1.TabIndex = 0;
            this._cboShape1.SelectedValueChanged += new System.EventHandler(this._cboShape1_SelectedValueChanged);
            // 
            // _shapePreview1
            // 
            this._shapePreview1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._shapePreview1.BackColor = System.Drawing.Color.White;
            this._shapePreview1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._shapePreview1.Location = new System.Drawing.Point(3, 3);
            this._shapePreview1.MaximumSize = new System.Drawing.Size(40, 50);
            this._shapePreview1.MinimumSize = new System.Drawing.Size(40, 50);
            this._shapePreview1.Name = "_shapePreview1";
            this.tableLayoutPanel1.SetRowSpan(this._shapePreview1, 2);
            this._shapePreview1.Size = new System.Drawing.Size(40, 50);
            this._shapePreview1.TabIndex = 1;
            this._shapePreview1.Paint += new System.Windows.Forms.PaintEventHandler(this._shapePreview1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this._shapePreview3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this._shapePreview2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._shapePreview1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._cboShape3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this._cboShape2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._cboShape1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnColor1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this._btnColor2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this._btnColor3, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(281, 212);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Shape 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Shape 2";
            // 
            // _shapePreview3
            // 
            this._shapePreview3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._shapePreview3.BackColor = System.Drawing.Color.White;
            this._shapePreview3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._shapePreview3.Location = new System.Drawing.Point(3, 115);
            this._shapePreview3.MaximumSize = new System.Drawing.Size(40, 50);
            this._shapePreview3.MinimumSize = new System.Drawing.Size(40, 50);
            this._shapePreview3.Name = "_shapePreview3";
            this.tableLayoutPanel1.SetRowSpan(this._shapePreview3, 2);
            this._shapePreview3.Size = new System.Drawing.Size(40, 50);
            this._shapePreview3.TabIndex = 5;
            this._shapePreview3.Paint += new System.Windows.Forms.PaintEventHandler(this._shapePreview3_Paint);
            // 
            // _shapePreview2
            // 
            this._shapePreview2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._shapePreview2.BackColor = System.Drawing.Color.White;
            this._shapePreview2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._shapePreview2.Location = new System.Drawing.Point(3, 59);
            this._shapePreview2.MaximumSize = new System.Drawing.Size(40, 50);
            this._shapePreview2.MinimumSize = new System.Drawing.Size(40, 50);
            this._shapePreview2.Name = "_shapePreview2";
            this.tableLayoutPanel1.SetRowSpan(this._shapePreview2, 2);
            this._shapePreview2.Size = new System.Drawing.Size(40, 50);
            this._shapePreview2.TabIndex = 3;
            this._shapePreview2.Paint += new System.Windows.Forms.PaintEventHandler(this._shapePreview2_Paint);
            // 
            // _cboShape3
            // 
            this._cboShape3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cboShape3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboShape3.FormattingEnabled = true;
            this._cboShape3.Location = new System.Drawing.Point(49, 136);
            this._cboShape3.Name = "_cboShape3";
            this._cboShape3.Size = new System.Drawing.Size(128, 21);
            this._cboShape3.Sorted = true;
            this._cboShape3.TabIndex = 4;
            this._cboShape3.SelectedValueChanged += new System.EventHandler(this._cboShape3_SelectedValueChanged);
            // 
            // _cboShape2
            // 
            this._cboShape2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._cboShape2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cboShape2.FormattingEnabled = true;
            this._cboShape2.Location = new System.Drawing.Point(49, 80);
            this._cboShape2.Name = "_cboShape2";
            this._cboShape2.Size = new System.Drawing.Size(128, 21);
            this._cboShape2.Sorted = true;
            this._cboShape2.TabIndex = 2;
            this._cboShape2.SelectedValueChanged += new System.EventHandler(this._cboShape2_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Shape 1";
            // 
            // _btnColor1
            // 
            this._btnColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._btnColor1.Location = new System.Drawing.Point(203, 23);
            this._btnColor1.Name = "_btnColor1";
            this._btnColor1.Size = new System.Drawing.Size(75, 23);
            this._btnColor1.TabIndex = 9;
            this._btnColor1.UseVisualStyleBackColor = true;
            this._btnColor1.Click += new System.EventHandler(this.ColorSelector_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Color 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Color 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Color 3";
            // 
            // _btnColor2
            // 
            this._btnColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._btnColor2.Location = new System.Drawing.Point(203, 79);
            this._btnColor2.Name = "_btnColor2";
            this._btnColor2.Size = new System.Drawing.Size(75, 23);
            this._btnColor2.TabIndex = 13;
            this._btnColor2.UseVisualStyleBackColor = true;
            this._btnColor2.Click += new System.EventHandler(this.ColorSelector_Click);
            // 
            // _btnColor3
            // 
            this._btnColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._btnColor3.Location = new System.Drawing.Point(203, 135);
            this._btnColor3.Name = "_btnColor3";
            this._btnColor3.Size = new System.Drawing.Size(75, 23);
            this._btnColor3.TabIndex = 14;
            this._btnColor3.UseVisualStyleBackColor = true;
            this._btnColor3.Click += new System.EventHandler(this.ColorSelector_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Location = new System.Drawing.Point(189, 3);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 6);
            this.groupBox1.Size = new System.Drawing.Size(2, 162);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 44);
            this.panel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this._btnOK, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._btnCancel, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(281, 44);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.Location = new System.Drawing.Point(135, 18);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(60, 23);
            this._btnOK.TabIndex = 0;
            this._btnOK.Text = "OK";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(201, 18);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(77, 23);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // DisplayOptionsDlg
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(291, 222);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayOptionsDlg";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Display Options";
            this.Load += new System.EventHandler(this.DisplayOptionsDlg_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _cboShape1;
        private System.Windows.Forms.Panel _shapePreview1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel _shapePreview3;
        private System.Windows.Forms.Panel _shapePreview2;
        private System.Windows.Forms.ComboBox _cboShape3;
        private System.Windows.Forms.ComboBox _cboShape2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnColor1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _btnColor2;
        private System.Windows.Forms.Button _btnColor3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
    }
}