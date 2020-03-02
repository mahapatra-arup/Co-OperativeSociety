namespace CoOperativeSociety.Others
{
    partial class LoanCalculator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRepaymentInterVal = new System.Windows.Forms.ComboBox();
            this.btnCalCulate = new System.Windows.Forms.Button();
            this.ffff = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoOfPayment = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Installment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmiAmount = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Repayment interval ";
            // 
            // cmbRepaymentInterVal
            // 
            this.cmbRepaymentInterVal.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRepaymentInterVal.FormattingEnabled = true;
            this.cmbRepaymentInterVal.Items.AddRange(new object[] {
            "Month",
            "Year"});
            this.cmbRepaymentInterVal.Location = new System.Drawing.Point(14, 34);
            this.cmbRepaymentInterVal.Name = "cmbRepaymentInterVal";
            this.cmbRepaymentInterVal.Size = new System.Drawing.Size(143, 23);
            this.cmbRepaymentInterVal.TabIndex = 0;
            this.cmbRepaymentInterVal.Text = "Month";
            // 
            // btnCalCulate
            // 
            this.btnCalCulate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalCulate.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCalCulate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalCulate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalCulate.Location = new System.Drawing.Point(615, 32);
            this.btnCalCulate.Name = "btnCalCulate";
            this.btnCalCulate.Size = new System.Drawing.Size(89, 28);
            this.btnCalCulate.TabIndex = 4;
            this.btnCalCulate.Text = "&Calculate >>";
            this.btnCalCulate.UseVisualStyleBackColor = false;
            this.btnCalCulate.Click += new System.EventHandler(this.btnCalCulate_Click);
            // 
            // ffff
            // 
            this.ffff.AutoSize = true;
            this.ffff.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ffff.Location = new System.Drawing.Point(478, 19);
            this.ffff.Name = "ffff";
            this.ffff.Size = new System.Drawing.Size(97, 15);
            this.ffff.TabIndex = 16;
            this.ffff.Text = "No. of payments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Annual interest rate (%)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Loan amount";
            // 
            // txtNoOfPayment
            // 
            this.txtNoOfPayment.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfPayment.Location = new System.Drawing.Point(475, 35);
            this.txtNoOfPayment.Name = "txtNoOfPayment";
            this.txtNoOfPayment.Size = new System.Drawing.Size(121, 23);
            this.txtNoOfPayment.TabIndex = 3;
            this.txtNoOfPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanAmount_KeyPress);
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(314, 35);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(155, 23);
            this.txtRate.TabIndex = 2;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanAmount_KeyPress);
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanAmount.Location = new System.Drawing.Point(163, 35);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(146, 23);
            this.txtLoanAmount.TabIndex = 1;
            this.txtLoanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoanAmount_KeyPress);
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvView.ColumnHeadersHeight = 40;
            this.dgvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.Installment,
            this.Interest,
            this.Principal,
            this.Balance});
            this.dgvView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvView.EnableHeadersVisualStyles = false;
            this.dgvView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvView.Location = new System.Drawing.Point(4, 149);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvView.RowHeadersVisible = false;
            this.dgvView.RowHeadersWidth = 25;
            this.dgvView.Size = new System.Drawing.Size(715, 313);
            this.dgvView.TabIndex = 20;
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            // 
            // Installment
            // 
            this.Installment.HeaderText = "Installment";
            this.Installment.Name = "Installment";
            // 
            // Interest
            // 
            this.Interest.HeaderText = "Installment Interest";
            this.Interest.Name = "Interest";
            // 
            // Principal
            // 
            this.Principal.HeaderText = "Installment Principal";
            this.Principal.Name = "Principal";
            // 
            // Balance
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Balance.DefaultCellStyle = dataGridViewCellStyle3;
            this.Balance.HeaderText = "CurrentBalance";
            this.Balance.Name = "Balance";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Tomato;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(715, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Details";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmiAmount
            // 
            this.txtEmiAmount.BackColor = System.Drawing.Color.Navy;
            this.txtEmiAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmiAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEmiAmount.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmiAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmiAmount.Location = new System.Drawing.Point(0, 467);
            this.txtEmiAmount.Name = "txtEmiAmount";
            this.txtEmiAmount.ReadOnly = true;
            this.txtEmiAmount.Size = new System.Drawing.Size(724, 23);
            this.txtEmiAmount.TabIndex = 22;
            this.txtEmiAmount.Text = "       EMI  : 00000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLoanAmount);
            this.panel1.Controls.Add(this.txtRate);
            this.panel1.Controls.Add(this.txtNoOfPayment);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbRepaymentInterVal);
            this.panel1.Controls.Add(this.ffff);
            this.panel1.Controls.Add(this.btnCalCulate);
            this.panel1.Location = new System.Drawing.Point(1, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 82);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CoOperativeSociety.Properties.Resources.information32X32;
            this.button1.Location = new System.Drawing.Point(1, -3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 40);
            this.button1.TabIndex = 122;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(43, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 123;
            this.label6.Text = "Calculator";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 37);
            this.panel2.TabIndex = 124;
            // 
            // LoanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(724, 490);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmiAmount);
            this.Controls.Add(this.dgvView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "LoanCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRepaymentInterVal;
        private System.Windows.Forms.Button btnCalCulate;
        private System.Windows.Forms.Label ffff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoOfPayment;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtEmiAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Installment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}