namespace CoOperativeSociety
{
    partial class CustomerEMIView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxtTotalDetails = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCustomerloanDetails = new System.Windows.Forms.DataGridView();
            this.dgvCustomerloanEMI = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.lblPhNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerloanDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerloanEMI)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(42, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 140;
            this.label4.Text = "EMI Details ::";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.rtxtTotalDetails);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvCustomerloanDetails);
            this.panel1.Controls.Add(this.dgvCustomerloanEMI);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbCustomerName);
            this.panel1.Location = new System.Drawing.Point(2, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 450);
            this.panel1.TabIndex = 142;
            // 
            // rtxtTotalDetails
            // 
            this.rtxtTotalDetails.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtxtTotalDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTotalDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtTotalDetails.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTotalDetails.ForeColor = System.Drawing.Color.LawnGreen;
            this.rtxtTotalDetails.Location = new System.Drawing.Point(0, 416);
            this.rtxtTotalDetails.Name = "rtxtTotalDetails";
            this.rtxtTotalDetails.ReadOnly = true;
            this.rtxtTotalDetails.Size = new System.Drawing.Size(891, 34);
            this.rtxtTotalDetails.TabIndex = 189;
            this.rtxtTotalDetails.Text = "Paid   :  XXXXXXXXXXXXXXXX000000000\nDue   :  XXXXXXXXXXXXXXXX000000000";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(4, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(884, 3);
            this.label1.TabIndex = 187;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(4, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(883, 3);
            this.label2.TabIndex = 186;
            // 
            // dgvCustomerloanDetails
            // 
            this.dgvCustomerloanDetails.AllowUserToAddRows = false;
            this.dgvCustomerloanDetails.AllowUserToDeleteRows = false;
            this.dgvCustomerloanDetails.AllowUserToOrderColumns = true;
            this.dgvCustomerloanDetails.AllowUserToResizeRows = false;
            this.dgvCustomerloanDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerloanDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomerloanDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerloanDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustomerloanDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerloanDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomerloanDetails.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerloanDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomerloanDetails.EnableHeadersVisualStyles = false;
            this.dgvCustomerloanDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvCustomerloanDetails.Location = new System.Drawing.Point(3, 50);
            this.dgvCustomerloanDetails.Name = "dgvCustomerloanDetails";
            this.dgvCustomerloanDetails.ReadOnly = true;
            this.dgvCustomerloanDetails.RowHeadersVisible = false;
            this.dgvCustomerloanDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerloanDetails.Size = new System.Drawing.Size(885, 119);
            this.dgvCustomerloanDetails.TabIndex = 164;
            this.dgvCustomerloanDetails.SelectionChanged += new System.EventHandler(this.dgvCustomerloanDetails_SelectionChanged);
            // 
            // dgvCustomerloanEMI
            // 
            this.dgvCustomerloanEMI.AllowUserToAddRows = false;
            this.dgvCustomerloanEMI.AllowUserToDeleteRows = false;
            this.dgvCustomerloanEMI.AllowUserToOrderColumns = true;
            this.dgvCustomerloanEMI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerloanEMI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCustomerloanEMI.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCustomerloanEMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustomerloanEMI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerloanEMI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCustomerloanEMI.ColumnHeadersHeight = 35;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerloanEMI.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCustomerloanEMI.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvCustomerloanEMI.Location = new System.Drawing.Point(0, 178);
            this.dgvCustomerloanEMI.Name = "dgvCustomerloanEMI";
            this.dgvCustomerloanEMI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCustomerloanEMI.RowHeadersVisible = false;
            this.dgvCustomerloanEMI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerloanEMI.Size = new System.Drawing.Size(891, 235);
            this.dgvCustomerloanEMI.TabIndex = 163;
            this.dgvCustomerloanEMI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerloanEMI_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Teal;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::CoOperativeSociety.Properties.Resources.refresh1;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(791, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 27);
            this.btnRefresh.TabIndex = 162;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 159;
            this.label9.Text = "Customer Name :";
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(101, 8);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(650, 21);
            this.cmbCustomerName.TabIndex = 158;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            // 
            // lblPhNo
            // 
            this.lblPhNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhNo.BackColor = System.Drawing.Color.MistyRose;
            this.lblPhNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhNo.Location = new System.Drawing.Point(748, 27);
            this.lblPhNo.Name = "lblPhNo";
            this.lblPhNo.Size = new System.Drawing.Size(145, 20);
            this.lblPhNo.TabIndex = 168;
            this.lblPhNo.Text = "+91XXXXXXX";
            this.lblPhNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(700, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 167;
            this.label6.Text = "Ph. No. :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDob
            // 
            this.lblDob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDob.BackColor = System.Drawing.Color.MistyRose;
            this.lblDob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDob.Location = new System.Drawing.Point(555, 27);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(139, 20);
            this.lblDob.TabIndex = 166;
            this.lblDob.Text = "dd/MMM/yyyy";
            this.lblDob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.MistyRose;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(519, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 165;
            this.label5.Text = "DOB : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CoOperativeSociety.Properties.Resources.information32X32;
            this.button1.Location = new System.Drawing.Point(5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 40);
            this.button1.TabIndex = 141;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CustomerEMIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 497);
            this.Controls.Add(this.lblPhNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "CustomerEMIView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerEMIView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerloanDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerloanEMI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        internal System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvCustomerloanEMI;
        private System.Windows.Forms.DataGridView dgvCustomerloanDetails;
        private System.Windows.Forms.Label lblPhNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtTotalDetails;
    }
}