namespace SetGame
{
    partial class ControlOptionsDlg
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
            this._grpSinglePlayer = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._chkKey = new System.Windows.Forms.CheckBox();
            this._chkRightClick = new System.Windows.Forms.CheckBox();
            this._txtKey = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._grpSinglePlayer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _grpSinglePlayer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._grpSinglePlayer, 4);
            this._grpSinglePlayer.Controls.Add(this.tableLayoutPanel2);
            this._grpSinglePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grpSinglePlayer.Location = new System.Drawing.Point(3, 3);
            this._grpSinglePlayer.Name = "_grpSinglePlayer";
            this._grpSinglePlayer.Size = new System.Drawing.Size(171, 81);
            this._grpSinglePlayer.TabIndex = 0;
            this._grpSinglePlayer.TabStop = false;
            this._grpSinglePlayer.Text = "Single Player";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this._chkKey, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._chkRightClick, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this._txtKey, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(165, 62);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // _chkKey
            // 
            this._chkKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._chkKey.AutoSize = true;
            this._chkKey.Location = new System.Drawing.Point(3, 4);
            this._chkKey.Name = "_chkKey";
            this._chkKey.Size = new System.Drawing.Size(123, 17);
            this._chkKey.TabIndex = 0;
            this._chkKey.Text = "Call Set with Key";
            this._chkKey.UseVisualStyleBackColor = true;
            this._chkKey.CheckedChanged += new System.EventHandler(this._chkKey_CheckedChanged);
            // 
            // _chkRightClick
            // 
            this._chkRightClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._chkRightClick.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this._chkRightClick, 2);
            this._chkRightClick.Location = new System.Drawing.Point(3, 29);
            this._chkRightClick.Name = "_chkRightClick";
            this._chkRightClick.Size = new System.Drawing.Size(159, 17);
            this._chkRightClick.TabIndex = 1;
            this._chkRightClick.Text = "Call Set with Right Click";
            this._chkRightClick.UseVisualStyleBackColor = true;
            // 
            // _txtKey
            // 
            this._txtKey.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._txtKey.Enabled = false;
            this._txtKey.Location = new System.Drawing.Point(132, 3);
            this._txtKey.Name = "_txtKey";
            this._txtKey.Size = new System.Drawing.Size(30, 20);
            this._txtKey.TabIndex = 2;
            this._txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtKey.TextChanged += new System.EventHandler(this._txtKey_TextChanged);
            this._txtKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtKey_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._grpSinglePlayer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._btnOK, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._btnCancel, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(177, 116);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // _btnOK
            // 
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.Location = new System.Drawing.Point(10, 90);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 23);
            this._btnOK.TabIndex = 1;
            this._btnOK.Text = "OK";
            this._btnOK.UseVisualStyleBackColor = true;
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(91, 90);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 2;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // ControlOptionsDlg
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(177, 116);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlOptionsDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Control Options";
            this.Load += new System.EventHandler(this.ControlOptionsDlg_Load);
            this._grpSinglePlayer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _grpSinglePlayer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox _chkKey;
        private System.Windows.Forms.CheckBox _chkRightClick;
        private System.Windows.Forms.TextBox _txtKey;
    }
}