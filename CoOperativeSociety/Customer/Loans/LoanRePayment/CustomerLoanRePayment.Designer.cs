namespace CoOperativeSociety.Customer.Loans.LoanRePayment
{
    partial class CustomerLoanRePayment
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
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPhNo = new System.Windows.Forms.Label();
            this.pnlCustomerDetails = new System.Windows.Forms.Panel();
            this.txtROIAm = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrincipalAm = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpLastDayOfPaid = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPaidDay = new System.Windows.Forms.DateTimePicker();
            this.txtNoOfEmi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.RichTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.cmbLoanSlNo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPaid = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEMIIIdOfLoan = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cmbSocietySavingBank = new System.Windows.Forms.ComboBox();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.pnlCustomerDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(12, 70);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(511, 21);
            this.cmbCustomerName.TabIndex = 0;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 122;
            this.label9.Text = "Customer Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 112;
            this.label1.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.No;
            this.txtAddress.HideSelection = false;
            this.txtAddress.Location = new System.Drawing.Point(65, 40);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(440, 67);
            this.txtAddress.TabIndex = 114;
            this.txtAddress.Text = "XXX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 119;
            this.label5.Text = "DOB : ";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(51, 12);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(76, 13);
            this.lblDob.TabIndex = 120;
            this.lblDob.Text = "dd/MMM/yyyy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 121;
            this.label6.Text = "Ph. No. :";
            // 
            // lblPhNo
            // 
            this.lblPhNo.AutoSize = true;
            this.lblPhNo.Location = new System.Drawing.Point(198, 12);
            this.lblPhNo.Name = "lblPhNo";
            this.lblPhNo.Size = new System.Drawing.Size(74, 13);
            this.lblPhNo.TabIndex = 122;
            this.lblPhNo.Text = "+91XXXXXXX";
            // 
            // pnlCustomerDetails
            // 
            this.pnlCustomerDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlCustomerDetails.Controls.Add(this.lblPhNo);
            this.pnlCustomerDetails.Controls.Add(this.label6);
            this.pnlCustomerDetails.Controls.Add(this.lblDob);
            this.pnlCustomerDetails.Controls.Add(this.label5);
            this.pnlCustomerDetails.Controls.Add(this.txtAddress);
            this.pnlCustomerDetails.Controls.Add(this.label1);
            this.pnlCustomerDetails.Location = new System.Drawing.Point(10, 121);
            this.pnlCustomerDetails.Name = "pnlCustomerDetails";
            this.pnlCustomerDetails.Size = new System.Drawing.Size(516, 112);
            this.pnlCustomerDetails.TabIndex = 123;
            // 
            // txtROIAm
            // 
            this.txtROIAm.Location = new System.Drawing.Point(107, 270);
            this.txtROIAm.Name = "txtROIAm";
            this.txtROIAm.ReadOnly = true;
            this.txtROIAm.Size = new System.Drawing.Size(151, 20);
            this.txtROIAm.TabIndex = 134;
            this.txtROIAm.Text = "0";
            this.txtROIAm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 13);
            this.label15.TabIndex = 136;
            this.label15.Text = "Interest Repayment :";
            // 
            // txtPrincipalAm
            // 
            this.txtPrincipalAm.Location = new System.Drawing.Point(372, 244);
            this.txtPrincipalAm.Name = "txtPrincipalAm";
            this.txtPrincipalAm.ReadOnly = true;
            this.txtPrincipalAm.Size = new System.Drawing.Size(151, 20);
            this.txtPrincipalAm.TabIndex = 135;
            this.txtPrincipalAm.Text = "0";
            this.txtPrincipalAm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(266, 247);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 13);
            this.label16.TabIndex = 137;
            this.label16.Text = "Principal Repayment :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(40, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 138;
            this.label4.Text = "Payment ::";
            // 
            // dtpLastDayOfPaid
            // 
            this.dtpLastDayOfPaid.Enabled = false;
            this.dtpLastDayOfPaid.Location = new System.Drawing.Point(107, 244);
            this.dtpLastDayOfPaid.Name = "dtpLastDayOfPaid";
            this.dtpLastDayOfPaid.Size = new System.Drawing.Size(151, 20);
            this.dtpLastDayOfPaid.TabIndex = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 141;
            this.label2.Text = "Last Date of paid :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 143;
            this.label3.Text = "Paid Date :";
            // 
            // dtpPaidDay
            // 
            this.dtpPaidDay.Location = new System.Drawing.Point(107, 296);
            this.dtpPaidDay.Name = "dtpPaidDay";
            this.dtpPaidDay.Size = new System.Drawing.Size(151, 20);
            this.dtpPaidDay.TabIndex = 3;
            // 
            // txtNoOfEmi
            // 
            this.txtNoOfEmi.Location = new System.Drawing.Point(372, 273);
            this.txtNoOfEmi.Name = "txtNoOfEmi";
            this.txtNoOfEmi.ReadOnly = true;
            this.txtNoOfEmi.Size = new System.Drawing.Size(151, 20);
            this.txtNoOfEmi.TabIndex = 146;
            this.txtNoOfEmi.Text = "0";
            this.txtNoOfEmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 147;
            this.label8.Text = "No Of EMI :";
            // 
            // txtPurpose
            // 
            this.txtPurpose.BackColor = System.Drawing.SystemColors.Window;
            this.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurpose.Location = new System.Drawing.Point(5, 397);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(422, 58);
            this.txtPurpose.TabIndex = 5;
            this.txtPurpose.Text = "";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 381);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 13);
            this.label25.TabIndex = 153;
            this.label25.Text = "Purpose :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 154;
            this.label10.Text = "Voucher No :";
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.Location = new System.Drawing.Point(470, 15);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(13, 13);
            this.lblVoucherNo.TabIndex = 155;
            this.lblVoucherNo.Text = "0";
            // 
            // cmbLoanSlNo
            // 
            this.cmbLoanSlNo.FormattingEnabled = true;
            this.cmbLoanSlNo.Location = new System.Drawing.Point(72, 95);
            this.cmbLoanSlNo.Name = "cmbLoanSlNo";
            this.cmbLoanSlNo.Size = new System.Drawing.Size(355, 21);
            this.cmbLoanSlNo.TabIndex = 1;
            this.cmbLoanSlNo.SelectedIndexChanged += new System.EventHandler(this.cmbLoanSlNo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 157;
            this.label11.Text = "Loan No :";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CoOperativeSociety.Properties.Resources.information32X32;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 40);
            this.button1.TabIndex = 139;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPaid
            // 
            this.btnPaid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPaid.BackColor = System.Drawing.Color.Teal;
            this.btnPaid.FlatAppearance.BorderSize = 0;
            this.btnPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaid.ForeColor = System.Drawing.Color.White;
            this.btnPaid.Image = global::CoOperativeSociety.Properties.Resources.Loan_Receipt;
            this.btnPaid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaid.Location = new System.Drawing.Point(437, 418);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(89, 29);
            this.btnPaid.TabIndex = 6;
            this.btnPaid.Text = "&PAID";
            this.btnPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaid.UseVisualStyleBackColor = false;
            this.btnPaid.Click += new System.EventHandler(this.btnPaid_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(437, 95);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 24);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 165;
            this.label7.Text = "EMI ID";
            this.label7.Visible = false;
            // 
            // txtEMIIIdOfLoan
            // 
            this.txtEMIIIdOfLoan.Location = new System.Drawing.Point(210, 12);
            this.txtEMIIIdOfLoan.Name = "txtEMIIIdOfLoan";
            this.txtEMIIIdOfLoan.ReadOnly = true;
            this.txtEMIIIdOfLoan.Size = new System.Drawing.Size(147, 20);
            this.txtEMIIIdOfLoan.TabIndex = 164;
            this.txtEMIIIdOfLoan.Text = "0";
            this.txtEMIIIdOfLoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 333);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(195, 13);
            this.label36.TabIndex = 170;
            this.label36.Text = "Deposit To : (Socity Saving/Current AC)\r\n";
            // 
            // cmbSocietySavingBank
            // 
            this.cmbSocietySavingBank.FormattingEnabled = true;
            this.cmbSocietySavingBank.Location = new System.Drawing.Point(6, 349);
            this.cmbSocietySavingBank.Name = "cmbSocietySavingBank";
            this.cmbSocietySavingBank.Size = new System.Drawing.Size(516, 21);
            this.cmbSocietySavingBank.TabIndex = 4;
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(372, 299);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.ReadOnly = true;
            this.txtRefNo.Size = new System.Drawing.Size(150, 20);
            this.txtRefNo.TabIndex = 172;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(266, 303);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(44, 13);
            this.label39.TabIndex = 171;
            this.label39.Text = "Ref No.";
            // 
            // CustomerLoanRePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 459);
            this.Controls.Add(this.txtPrincipalAm);
            this.Controls.Add(this.txtRefNo);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.cmbSocietySavingBank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEMIIIdOfLoan);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbLoanSlNo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblVoucherNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNoOfEmi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpPaidDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpLastDayOfPaid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtROIAm);
            this.Controls.Add(this.pnlCustomerDetails);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCustomerName);
            this.Controls.Add(this.btnPaid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CustomerLoanRePayment";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerLoanRePayment_FormClosing);
            this.pnlCustomerDetails.ResumeLayout(false);
            this.pnlCustomerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPhNo;
        private System.Windows.Forms.Panel pnlCustomerDetails;
        private System.Windows.Forms.TextBox txtROIAm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrincipalAm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpLastDayOfPaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPaidDay;
        private System.Windows.Forms.TextBox txtNoOfEmi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtPurpose;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.ComboBox cmbLoanSlNo;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEMIIIdOfLoan;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cmbSocietySavingBank;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label39;
    }
}