namespace CoOperativeSociety.Society.ListView
{
    partial class SocityLoanEMIView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSocityloanDetails = new System.Windows.Forms.DataGridView();
            this.dgvSocityloanEMI = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rtxtTotalDetails = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocityloanDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocityloanEMI)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Controls.Add(this.dgvSocityloanDetails);
            this.panel1.Controls.Add(this.dgvSocityloanEMI);
            this.panel1.Location = new System.Drawing.Point(1, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 402);
            this.panel1.TabIndex = 171;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(4, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 3);
            this.label1.TabIndex = 187;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(862, 3);
            this.label2.TabIndex = 186;
            // 
            // dgvSocityloanDetails
            // 
            this.dgvSocityloanDetails.AllowUserToAddRows = false;
            this.dgvSocityloanDetails.AllowUserToDeleteRows = false;
            this.dgvSocityloanDetails.AllowUserToOrderColumns = true;
            this.dgvSocityloanDetails.AllowUserToResizeRows = false;
            this.dgvSocityloanDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSocityloanDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSocityloanDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvSocityloanDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSocityloanDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSocityloanDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSocityloanDetails.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSocityloanDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSocityloanDetails.EnableHeadersVisualStyles = false;
            this.dgvSocityloanDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvSocityloanDetails.Location = new System.Drawing.Point(3, 8);
            this.dgvSocityloanDetails.Name = "dgvSocityloanDetails";
            this.dgvSocityloanDetails.ReadOnly = true;
            this.dgvSocityloanDetails.RowHeadersVisible = false;
            this.dgvSocityloanDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSocityloanDetails.Size = new System.Drawing.Size(864, 132);
            this.dgvSocityloanDetails.TabIndex = 164;
            this.dgvSocityloanDetails.SelectionChanged += new System.EventHandler(this.dgvSocityloanDetails_SelectionChanged);
            // 
            // dgvSocityloanEMI
            // 
            this.dgvSocityloanEMI.AllowUserToAddRows = false;
            this.dgvSocityloanEMI.AllowUserToDeleteRows = false;
            this.dgvSocityloanEMI.AllowUserToOrderColumns = true;
            this.dgvSocityloanEMI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSocityloanEMI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSocityloanEMI.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSocityloanEMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSocityloanEMI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSocityloanEMI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSocityloanEMI.ColumnHeadersHeight = 35;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSocityloanEMI.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSocityloanEMI.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvSocityloanEMI.Location = new System.Drawing.Point(0, 148);
            this.dgvSocityloanEMI.Name = "dgvSocityloanEMI";
            this.dgvSocityloanEMI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvSocityloanEMI.RowHeadersVisible = false;
            this.dgvSocityloanEMI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSocityloanEMI.Size = new System.Drawing.Size(870, 214);
            this.dgvSocityloanEMI.TabIndex = 163;
            this.dgvSocityloanEMI.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSocityloanEMI_CellClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CoOperativeSociety.Properties.Resources.information32X32;
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 40);
            this.button1.TabIndex = 170;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(40, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 169;
            this.label4.Text = "EMI Details ::";
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
            this.btnRefresh.Location = new System.Drawing.Point(778, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(89, 27);
            this.btnRefresh.TabIndex = 172;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // rtxtTotalDetails
            // 
            this.rtxtTotalDetails.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtxtTotalDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTotalDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtxtTotalDetails.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTotalDetails.ForeColor = System.Drawing.Color.LawnGreen;
            this.rtxtTotalDetails.Location = new System.Drawing.Point(0, 365);
            this.rtxtTotalDetails.Name = "rtxtTotalDetails";
            this.rtxtTotalDetails.ReadOnly = true;
            this.rtxtTotalDetails.Size = new System.Drawing.Size(870, 37);
            this.rtxtTotalDetails.TabIndex = 190;
            this.rtxtTotalDetails.Text = "Paid   :  XXXXXXXXXXXXXXXX000000000\nDue   :  XXXXXXXXXXXXXXXX000000000";
            // 
            // SocityLoanEMIView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(874, 447);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Name = "SocityLoanEMIView";
            this.Text = "SocityLoanEMIView";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocityloanDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocityloanEMI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSocityloanDetails;
        private System.Windows.Forms.DataGridView dgvSocityloanEMI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RichTextBox rtxtTotalDetails;
    }
}