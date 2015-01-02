namespace SetGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._flowBoard = new System.Windows.Forms.FlowLayoutPanel();
            this._lblMessages = new System.Windows.Forms.Label();
            this._btnHint = new System.Windows.Forms.Button();
            this._mnuMain = new System.Windows.Forms.MenuStrip();
            this._mnuGame = new System.Windows.Forms.ToolStripMenuItem();
            this._itmGameNewSingle = new System.Windows.Forms.ToolStripMenuItem();
            this._itmGameNewPredef = new System.Windows.Forms.ToolStripMenuItem();
            this._mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this._itmOptionsDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this._itmOptionsControls = new System.Windows.Forms.ToolStripMenuItem();
            this._itmOptionsShowDebug = new System.Windows.Forms.ToolStripMenuItem();
            this._btnSet = new System.Windows.Forms.Button();
            this._lblScore = new System.Windows.Forms.Label();
            this._lblCountdown = new System.Windows.Forms.Label();
            this._pnlBoard = new System.Windows.Forms.Panel();
            this._mnuMain.SuspendLayout();
            this._pnlBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // _flowBoard
            // 
            this._flowBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._flowBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._flowBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flowBoard.Location = new System.Drawing.Point(2, 2);
            this._flowBoard.Name = "_flowBoard";
            this._flowBoard.Size = new System.Drawing.Size(561, 764);
            this._flowBoard.TabIndex = 0;
            // 
            // _lblMessages
            // 
            this._lblMessages.AutoSize = true;
            this._lblMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblMessages.Location = new System.Drawing.Point(12, 801);
            this._lblMessages.Name = "_lblMessages";
            this._lblMessages.Size = new System.Drawing.Size(0, 20);
            this._lblMessages.TabIndex = 2;
            // 
            // _btnHint
            // 
            this._btnHint.Enabled = false;
            this._btnHint.Location = new System.Drawing.Point(330, 801);
            this._btnHint.Name = "_btnHint";
            this._btnHint.Size = new System.Drawing.Size(75, 23);
            this._btnHint.TabIndex = 3;
            this._btnHint.Text = "Hint";
            this._btnHint.UseVisualStyleBackColor = true;
            this._btnHint.Click += new System.EventHandler(this._btnHint_Click);
            // 
            // _mnuMain
            // 
            this._mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mnuGame,
            this._mnuOptions});
            this._mnuMain.Location = new System.Drawing.Point(0, 0);
            this._mnuMain.Name = "_mnuMain";
            this._mnuMain.Size = new System.Drawing.Size(593, 24);
            this._mnuMain.TabIndex = 4;
            this._mnuMain.Text = "menuStrip1";
            // 
            // _mnuGame
            // 
            this._mnuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._itmGameNewSingle,
            this._itmGameNewPredef});
            this._mnuGame.Name = "_mnuGame";
            this._mnuGame.Size = new System.Drawing.Size(50, 20);
            this._mnuGame.Text = "&Game";
            // 
            // _itmGameNewSingle
            // 
            this._itmGameNewSingle.Name = "_itmGameNewSingle";
            this._itmGameNewSingle.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this._itmGameNewSingle.Size = new System.Drawing.Size(187, 22);
            this._itmGameNewSingle.Text = "New Single Player";
            this._itmGameNewSingle.Click += new System.EventHandler(this._itmGameNewSingle_Click);
            // 
            // _itmGameNewPredef
            // 
            this._itmGameNewPredef.Name = "_itmGameNewPredef";
            this._itmGameNewPredef.Size = new System.Drawing.Size(187, 22);
            this._itmGameNewPredef.Text = "New Predefined Deck";
            this._itmGameNewPredef.Click += new System.EventHandler(this._itmGameNewPredef_Click);
            // 
            // _mnuOptions
            // 
            this._mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._itmOptionsDisplay,
            this._itmOptionsControls,
            this._itmOptionsShowDebug});
            this._mnuOptions.Name = "_mnuOptions";
            this._mnuOptions.Size = new System.Drawing.Size(61, 20);
            this._mnuOptions.Text = "&Options";
            // 
            // _itmOptionsDisplay
            // 
            this._itmOptionsDisplay.Name = "_itmOptionsDisplay";
            this._itmOptionsDisplay.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this._itmOptionsDisplay.Size = new System.Drawing.Size(178, 22);
            this._itmOptionsDisplay.Text = "&Display...";
            this._itmOptionsDisplay.Click += new System.EventHandler(this._itmOptionsDisplay_Click);
            // 
            // _itmOptionsControls
            // 
            this._itmOptionsControls.Name = "_itmOptionsControls";
            this._itmOptionsControls.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this._itmOptionsControls.Size = new System.Drawing.Size(178, 22);
            this._itmOptionsControls.Text = "&Controls...";
            this._itmOptionsControls.Click += new System.EventHandler(this._itmOptionsControls_Click);
            // 
            // _itmOptionsShowDebug
            // 
            this._itmOptionsShowDebug.CheckOnClick = true;
            this._itmOptionsShowDebug.Name = "_itmOptionsShowDebug";
            this._itmOptionsShowDebug.Size = new System.Drawing.Size(178, 22);
            this._itmOptionsShowDebug.Text = "Show Debug Dialog";
            this._itmOptionsShowDebug.CheckedChanged += new System.EventHandler(this._itmOptionsShowDebug_CheckedChanged);
            // 
            // _btnSet
            // 
            this._btnSet.Enabled = false;
            this._btnSet.Location = new System.Drawing.Point(249, 801);
            this._btnSet.Name = "_btnSet";
            this._btnSet.Size = new System.Drawing.Size(75, 23);
            this._btnSet.TabIndex = 5;
            this._btnSet.Text = "SET";
            this._btnSet.UseVisualStyleBackColor = true;
            this._btnSet.Click += new System.EventHandler(this._btnSet_Click);
            // 
            // _lblScore
            // 
            this._lblScore.AutoSize = true;
            this._lblScore.Location = new System.Drawing.Point(421, 807);
            this._lblScore.Name = "_lblScore";
            this._lblScore.Size = new System.Drawing.Size(0, 13);
            this._lblScore.TabIndex = 6;
            // 
            // _lblCountdown
            // 
            this._lblCountdown.AutoSize = true;
            this._lblCountdown.Location = new System.Drawing.Point(203, 807);
            this._lblCountdown.Name = "_lblCountdown";
            this._lblCountdown.Size = new System.Drawing.Size(0, 13);
            this._lblCountdown.TabIndex = 7;
            // 
            // _pnlBoard
            // 
            this._pnlBoard.Controls.Add(this._flowBoard);
            this._pnlBoard.Location = new System.Drawing.Point(16, 27);
            this._pnlBoard.Name = "_pnlBoard";
            this._pnlBoard.Padding = new System.Windows.Forms.Padding(2);
            this._pnlBoard.Size = new System.Drawing.Size(565, 768);
            this._pnlBoard.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 836);
            this.Controls.Add(this._pnlBoard);
            this.Controls.Add(this._lblCountdown);
            this.Controls.Add(this._lblScore);
            this.Controls.Add(this._btnSet);
            this.Controls.Add(this._btnHint);
            this.Controls.Add(this._lblMessages);
            this.Controls.Add(this._mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this._mnuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this._mnuMain.ResumeLayout(false);
            this._mnuMain.PerformLayout();
            this._pnlBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _flowBoard;
        private System.Windows.Forms.Label _lblMessages;
        private System.Windows.Forms.Button _btnHint;
        private System.Windows.Forms.MenuStrip _mnuMain;
        private System.Windows.Forms.ToolStripMenuItem _mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem _itmOptionsDisplay;
        private System.Windows.Forms.Button _btnSet;
        private System.Windows.Forms.ToolStripMenuItem _mnuGame;
        private System.Windows.Forms.ToolStripMenuItem _itmGameNewSingle;
        private System.Windows.Forms.Label _lblScore;
        private System.Windows.Forms.Label _lblCountdown;
        private System.Windows.Forms.Panel _pnlBoard;
        private System.Windows.Forms.ToolStripMenuItem _itmOptionsControls;
        private System.Windows.Forms.ToolStripMenuItem _itmGameNewPredef;
        private System.Windows.Forms.ToolStripMenuItem _itmOptionsShowDebug;
    }
}

