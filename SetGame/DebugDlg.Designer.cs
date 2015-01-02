namespace SetGame
{
    partial class DebugDlg
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._txtBoard = new System.Windows.Forms.TextBox();
            this._txtDeck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._txtColours = new System.Windows.Forms.TextBox();
            this._txtShades = new System.Windows.Forms.TextBox();
            this._txtShapes = new System.Windows.Forms.TextBox();
            this._txtNumbers = new System.Windows.Forms.TextBox();
            this._btnUpdateBoard = new System.Windows.Forms.Button();
            this._btnUpdateDeck = new System.Windows.Forms.Button();
            this._btnDeckExport = new System.Windows.Forms.Button();
            this._btnBoardExport = new System.Windows.Forms.Button();
            this._btnExportBoth = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnExportBoth, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 573);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this._txtBoard, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this._txtDeck, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this._txtColours, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this._txtShades, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this._txtShapes, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this._txtNumbers, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this._btnUpdateBoard, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this._btnUpdateDeck, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this._btnDeckExport, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this._btnBoardExport, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(532, 538);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // _txtBoard
            // 
            this.tableLayoutPanel3.SetColumnSpan(this._txtBoard, 2);
            this._txtBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtBoard.Location = new System.Drawing.Point(3, 83);
            this._txtBoard.Multiline = true;
            this._txtBoard.Name = "_txtBoard";
            this._txtBoard.Size = new System.Drawing.Size(260, 423);
            this._txtBoard.TabIndex = 0;
            // 
            // _txtDeck
            // 
            this.tableLayoutPanel3.SetColumnSpan(this._txtDeck, 2);
            this._txtDeck.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtDeck.Location = new System.Drawing.Point(269, 83);
            this._txtDeck.Multiline = true;
            this._txtDeck.Name = "_txtDeck";
            this._txtDeck.Size = new System.Drawing.Size(260, 423);
            this._txtDeck.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Board";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deck";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Colours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Shapes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Shades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Numbers";
            // 
            // _txtColours
            // 
            this._txtColours.Location = new System.Drawing.Point(136, 3);
            this._txtColours.Name = "_txtColours";
            this._txtColours.Size = new System.Drawing.Size(100, 20);
            this._txtColours.TabIndex = 8;
            this._txtColours.Text = "RGV";
            this._txtColours.TextChanged += new System.EventHandler(this._txtColours_TextChanged);
            // 
            // _txtShades
            // 
            this._txtShades.Location = new System.Drawing.Point(136, 33);
            this._txtShades.Name = "_txtShades";
            this._txtShades.Size = new System.Drawing.Size(100, 20);
            this._txtShades.TabIndex = 9;
            this._txtShades.Text = "FSE";
            this._txtShades.TextChanged += new System.EventHandler(this._txtShades_TextChanged);
            // 
            // _txtShapes
            // 
            this._txtShapes.Location = new System.Drawing.Point(402, 3);
            this._txtShapes.Name = "_txtShapes";
            this._txtShapes.Size = new System.Drawing.Size(100, 20);
            this._txtShapes.TabIndex = 10;
            this._txtShapes.Text = "PDZ";
            this._txtShapes.TextChanged += new System.EventHandler(this._txtShapes_TextChanged);
            // 
            // _txtNumbers
            // 
            this._txtNumbers.Location = new System.Drawing.Point(402, 33);
            this._txtNumbers.Name = "_txtNumbers";
            this._txtNumbers.Size = new System.Drawing.Size(100, 20);
            this._txtNumbers.TabIndex = 11;
            this._txtNumbers.Text = "123";
            this._txtNumbers.TextChanged += new System.EventHandler(this._txtNumbers_TextChanged);
            // 
            // _btnUpdateBoard
            // 
            this._btnUpdateBoard.Location = new System.Drawing.Point(3, 512);
            this._btnUpdateBoard.Name = "_btnUpdateBoard";
            this._btnUpdateBoard.Size = new System.Drawing.Size(75, 23);
            this._btnUpdateBoard.TabIndex = 12;
            this._btnUpdateBoard.Text = "Update";
            this._btnUpdateBoard.UseVisualStyleBackColor = true;
            this._btnUpdateBoard.Click += new System.EventHandler(this._btnUpdateBoard_Click);
            // 
            // _btnUpdateDeck
            // 
            this._btnUpdateDeck.Location = new System.Drawing.Point(269, 512);
            this._btnUpdateDeck.Name = "_btnUpdateDeck";
            this._btnUpdateDeck.Size = new System.Drawing.Size(75, 23);
            this._btnUpdateDeck.TabIndex = 13;
            this._btnUpdateDeck.Text = "Update";
            this._btnUpdateDeck.UseVisualStyleBackColor = true;
            this._btnUpdateDeck.Click += new System.EventHandler(this._btnUpdateDeck_Click);
            // 
            // _btnDeckExport
            // 
            this._btnDeckExport.Location = new System.Drawing.Point(402, 512);
            this._btnDeckExport.Name = "_btnDeckExport";
            this._btnDeckExport.Size = new System.Drawing.Size(75, 23);
            this._btnDeckExport.TabIndex = 14;
            this._btnDeckExport.Text = "Export";
            this._btnDeckExport.UseVisualStyleBackColor = true;
            this._btnDeckExport.Click += new System.EventHandler(this._btnDeckExport_Click);
            // 
            // _btnBoardExport
            // 
            this._btnBoardExport.Location = new System.Drawing.Point(136, 512);
            this._btnBoardExport.Name = "_btnBoardExport";
            this._btnBoardExport.Size = new System.Drawing.Size(75, 23);
            this._btnBoardExport.TabIndex = 15;
            this._btnBoardExport.Text = "Export";
            this._btnBoardExport.UseVisualStyleBackColor = true;
            this._btnBoardExport.Click += new System.EventHandler(this._btnBoardExport_Click);
            // 
            // _btnExportBoth
            // 
            this._btnExportBoth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnExportBoth.Location = new System.Drawing.Point(231, 547);
            this._btnExportBoth.Name = "_btnExportBoth";
            this._btnExportBoth.Size = new System.Drawing.Size(75, 23);
            this._btnExportBoth.TabIndex = 3;
            this._btnExportBoth.Text = "Export Both";
            this._btnExportBoth.UseVisualStyleBackColor = true;
            this._btnExportBoth.Click += new System.EventHandler(this._btnExportBoth_Click);
            // 
            // DebugDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Debug";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebugDlg_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox _txtBoard;
        private System.Windows.Forms.TextBox _txtDeck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtColours;
        private System.Windows.Forms.TextBox _txtShades;
        private System.Windows.Forms.TextBox _txtShapes;
        private System.Windows.Forms.TextBox _txtNumbers;
        private System.Windows.Forms.Button _btnUpdateBoard;
        private System.Windows.Forms.Button _btnUpdateDeck;
        private System.Windows.Forms.Button _btnDeckExport;
        private System.Windows.Forms.Button _btnBoardExport;
        private System.Windows.Forms.Button _btnExportBoth;
    }
}