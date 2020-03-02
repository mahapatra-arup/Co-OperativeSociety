namespace CoOperativeSociety.Setting
{
    partial class DecimalPointSetting
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
            this.iControl_GroupBox1 = new BusinessEntities.IControl_GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDecimalPoint = new System.Windows.Forms.NumericUpDown();
            this.iControl_GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalPoint)).BeginInit();
            this.SuspendLayout();
            // 
            // iControl_GroupBox1
            // 
            this.iControl_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iControl_GroupBox1.Controls.Add(this.label1);
            this.iControl_GroupBox1.Controls.Add(this.nudDecimalPoint);
            this.iControl_GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.iControl_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iControl_GroupBox1.Name = "iControl_GroupBox1";
            this.iControl_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iControl_GroupBox1.Size = new System.Drawing.Size(322, 161);
            this.iControl_GroupBox1.TabIndex = 0;
            this.iControl_GroupBox1.Text = "Decimal point Setting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digit After The Decimal Point :";
            // 
            // nudDecimalPoint
            // 
            this.nudDecimalPoint.Location = new System.Drawing.Point(188, 74);
            this.nudDecimalPoint.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudDecimalPoint.Name = "nudDecimalPoint";
            this.nudDecimalPoint.Size = new System.Drawing.Size(112, 20);
            this.nudDecimalPoint.TabIndex = 0;
            this.nudDecimalPoint.ValueChanged += new System.EventHandler(this.nudDecimalPoint_ValueChanged);
            // 
            // DecimalPointSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 184);
            this.Controls.Add(this.iControl_GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "DecimalPointSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.iControl_GroupBox1.ResumeLayout(false);
            this.iControl_GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalPoint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BusinessEntities.IControl_GroupBox iControl_GroupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDecimalPoint;
    }
}