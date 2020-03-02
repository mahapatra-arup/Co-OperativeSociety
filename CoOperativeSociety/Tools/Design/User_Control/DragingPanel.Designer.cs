namespace CoOperativeSociety.Tools.Design.User_Control
{
    partial class DragingPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DragingPanel));
            this.Draging_Panel = new BusinessEntities.GradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new BusinessEntities.GradientPanel();
            this.Draging_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Draging_Panel
            // 
            this.Draging_Panel.BackColor = System.Drawing.Color.White;
            this.Draging_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Draging_Panel.BackgroundImage")));
            this.Draging_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Draging_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Draging_Panel.Controls.Add(this.pictureBox1);
            this.Draging_Panel.Controls.Add(this.btnClose);
            this.Draging_Panel.Controls.Add(this.label1);
            this.Draging_Panel.Controls.Add(this.gradientPanel1);
            this.Draging_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Draging_Panel.Location = new System.Drawing.Point(0, 0);
            this.Draging_Panel.Name = "Draging_Panel";
            this.Draging_Panel.PageEndColor = System.Drawing.Color.Blue;
            this.Draging_Panel.PageLinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.Draging_Panel.PageMiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Draging_Panel.PageStartColor = System.Drawing.Color.PowderBlue;
            this.Draging_Panel.PageTripleColorMode = true;
            this.Draging_Panel.Size = new System.Drawing.Size(733, 450);
            this.Draging_Panel.TabIndex = 1;
            this.Draging_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draging_Panel_MouseDown);
            this.Draging_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draging_Panel_MouseMove);
            this.Draging_Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draging_Panel_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CoOperativeSociety.Properties.Resources.Default_Session;
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 33);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(686, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(44, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instruction";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanel1.BackgroundImage")));
            this.gradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel1.Location = new System.Drawing.Point(4, 37);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.PageEndColor = System.Drawing.Color.Empty;
            this.gradientPanel1.PageLinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientPanel1.PageMiddleColor = System.Drawing.Color.Empty;
            this.gradientPanel1.PageStartColor = System.Drawing.Color.Empty;
            this.gradientPanel1.PageTripleColorMode = false;
            this.gradientPanel1.Size = new System.Drawing.Size(722, 406);
            this.gradientPanel1.TabIndex = 0;
            // 
            // DragingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.Draging_Panel);
            this.Name = "DragingPanel";
            this.Size = new System.Drawing.Size(733, 450);
            this.Draging_Panel.ResumeLayout(false);
            this.Draging_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BusinessEntities.GradientPanel Draging_Panel;
        private System.Windows.Forms.Label label1;
        private BusinessEntities.GradientPanel gradientPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}