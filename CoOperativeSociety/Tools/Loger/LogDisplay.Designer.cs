namespace CoOperativeSociety.Tools.Loger
{
    partial class LogDisplay
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
            this.rtbErrorLog = new System.Windows.Forms.RichTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUndu = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.txtSearch = new BusinessEntities.IControl_TextBox_Small();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbErrorLog
            // 
            this.rtbErrorLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbErrorLog.BackColor = System.Drawing.Color.Beige;
            this.rtbErrorLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbErrorLog.Location = new System.Drawing.Point(5, 58);
            this.rtbErrorLog.Name = "rtbErrorLog";
            this.rtbErrorLog.Size = new System.Drawing.Size(1093, 427);
            this.rtbErrorLog.TabIndex = 0;
            this.rtbErrorLog.Text = "";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(587, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FloralWhite;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(786, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 32);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUndu
            // 
            this.btnUndu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndu.BackColor = System.Drawing.Color.FloralWhite;
            this.btnUndu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndu.Location = new System.Drawing.Point(890, 16);
            this.btnUndu.Name = "btnUndu";
            this.btnUndu.Size = new System.Drawing.Size(98, 32);
            this.btnUndu.TabIndex = 4;
            this.btnUndu.Text = "Undo";
            this.btnUndu.UseVisualStyleBackColor = false;
            this.btnUndu.Click += new System.EventHandler(this.btnUndu_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRedo.BackColor = System.Drawing.Color.FloralWhite;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Location = new System.Drawing.Point(994, 16);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(98, 32);
            this.btnRedo.TabIndex = 5;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(6, 20);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(575, 28);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.BackColor = System.Drawing.Color.FloralWhite;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Location = new System.Drawing.Point(702, 16);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(78, 32);
            this.btnReload.TabIndex = 6;
            this.btnReload.Text = "Re-Load";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // LogDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 491);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnRedo);
            this.Controls.Add(this.btnUndu);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.rtbErrorLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LogDisplay";
            this.Text = "LogDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbErrorLog;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private BusinessEntities.IControl_TextBox_Small txtSearch;
        private System.Windows.Forms.Button btnUndu;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnReload;
    }
}