namespace BusinessEntities
{
    partial class PleaseWait
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PleaseWait));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBer = new System.Windows.Forms.ProgressBar();
            this.ProgressB = new BusinessEntities.IControl_ProgressBar();
            this.pb = new System.Windows.Forms.PictureBox();
            this.tmProgress = new System.Windows.Forms.Timer(this.components);
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pbWait = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbWait);
            this.panel1.Controls.Add(this.pbLoading);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ProgressB);
            this.panel1.Controls.Add(this.pb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 249);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.progressBer);
            this.panel2.Location = new System.Drawing.Point(3, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 30);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // progressBer
            // 
            this.progressBer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.progressBer.Location = new System.Drawing.Point(1, 4);
            this.progressBer.Name = "progressBer";
            this.progressBer.Size = new System.Drawing.Size(252, 22);
            this.progressBer.TabIndex = 2;
            // 
            // ProgressB
            // 
            this.ProgressB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProgressB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.ProgressB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProgressB.Location = new System.Drawing.Point(44, 18);
            this.ProgressB.Maximum = ((long)(100));
            this.ProgressB.MinimumSize = new System.Drawing.Size(100, 100);
            this.ProgressB.Name = "ProgressB";
            this.ProgressB.ProgressColor1 = System.Drawing.Color.Lime;
            this.ProgressB.ProgressColor2 = System.Drawing.Color.Red;
            this.ProgressB.ProgressShape = BusinessEntities.IControl_ProgressBar._ProgressShape.Flat;
            this.ProgressB.Size = new System.Drawing.Size(168, 168);
            this.ProgressB.TabIndex = 4;
            this.ProgressB.Text = "iControl_ProgressBar1";
            this.ProgressB.Value = ((long)(0));
            // 
            // pb
            // 
            this.pb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb.BackColor = System.Drawing.Color.Transparent;
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.Location = new System.Drawing.Point(34, 16);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(189, 155);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            // 
            // tmProgress
            // 
            this.tmProgress.Tick += new System.EventHandler(this.tmProgress_Tick);
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(0, 177);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(263, 69);
            this.pbLoading.TabIndex = 5;
            this.pbLoading.TabStop = false;
            // 
            // pbWait
            // 
            this.pbWait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbWait.BackColor = System.Drawing.Color.Transparent;
            this.pbWait.Image = ((System.Drawing.Image)(resources.GetObject("pbWait.Image")));
            this.pbWait.Location = new System.Drawing.Point(24, 16);
            this.pbWait.Name = "pbWait";
            this.pbWait.Size = new System.Drawing.Size(200, 157);
            this.pbWait.TabIndex = 6;
            this.pbWait.TabStop = false;
            // 
            // PleaseWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(263, 249);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PleaseWait";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PleaseWait";
            this.TransparencyKey = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBer;
        private System.Windows.Forms.Timer tmProgress;
        private IControl_ProgressBar ProgressB;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.PictureBox pbWait;
    }
}