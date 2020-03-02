namespace CoOperativeSociety.Society.Loans
{
    partial class SocietyLoanEntry
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
            this.label32 = new System.Windows.Forms.Label();
            this.nudSectionROI = new System.Windows.Forms.NumericUpDown();
            this.pnlForLoanType = new System.Windows.Forms.Panel();
            this.txtEmiPeriod = new System.Windows.Forms.TextBox();
            this.txtInstallMentPeriodFormate = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.nudEmiPaidDay = new System.Windows.Forms.NumericUpDown();
            this.txtPayableAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iControl_Button_21 = new BusinessEntities.IControl_Button_2();
            this.dgvEMIView = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Installment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Principal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbLoanBank = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.RichTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMonthlyEMIAm = new System.Windows.Forms.TextBox();
            this.txtPrincipalAm = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnLoanCalculator = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLoanDetails = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSectionROIAm = new System.Windows.Forms.TextBox();
            this.nudNoOfEmi = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbLoanSubType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbLoanType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbLoanSlNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateOfLoan = new System.Windows.Forms.DateTimePicker();
            this.txtSectionAm = new System.Windows.Forms.TextBox();
            this.pnlBankDetails001 = new System.Windows.Forms.Panel();
            this.cmbLedgerBank = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSavingBank = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSectionROI)).BeginInit();
            this.pnlForLoanType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmiPaidDay)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMIView)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlLoanDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfEmi)).BeginInit();
            this.pnlBankDetails001.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(401, 121);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(19, 15);
            this.label32.TabIndex = 160;
            this.label32.Text = "%";
            // 
            // nudSectionROI
            // 
            this.nudSectionROI.Location = new System.Drawing.Point(124, 117);
            this.nudSectionROI.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSectionROI.Name = "nudSectionROI";
            this.nudSectionROI.Size = new System.Drawing.Size(274, 23);
            this.nudSectionROI.TabIndex = 6;
            this.nudSectionROI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSectionROI.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudSectionROI.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSectionROI.ValueChanged += new System.EventHandler(this.nudSectionROI_ValueChanged);
            // 
            // pnlForLoanType
            // 
            this.pnlForLoanType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlForLoanType.Controls.Add(this.txtEmiPeriod);
            this.pnlForLoanType.Controls.Add(this.txtInstallMentPeriodFormate);
            this.pnlForLoanType.Controls.Add(this.label31);
            this.pnlForLoanType.Controls.Add(this.label29);
            this.pnlForLoanType.Location = new System.Drawing.Point(272, 40);
            this.pnlForLoanType.Name = "pnlForLoanType";
            this.pnlForLoanType.Size = new System.Drawing.Size(341, 32);
            this.pnlForLoanType.TabIndex = 157;
            // 
            // txtEmiPeriod
            // 
            this.txtEmiPeriod.ForeColor = System.Drawing.Color.Black;
            this.txtEmiPeriod.Location = new System.Drawing.Point(89, 5);
            this.txtEmiPeriod.Name = "txtEmiPeriod";
            this.txtEmiPeriod.ReadOnly = true;
            this.txtEmiPeriod.Size = new System.Drawing.Size(74, 23);
            this.txtEmiPeriod.TabIndex = 146;
            // 
            // txtInstallMentPeriodFormate
            // 
            this.txtInstallMentPeriodFormate.Location = new System.Drawing.Point(226, 6);
            this.txtInstallMentPeriodFormate.Name = "txtInstallMentPeriodFormate";
            this.txtInstallMentPeriodFormate.ReadOnly = true;
            this.txtInstallMentPeriodFormate.Size = new System.Drawing.Size(103, 23);
            this.txtInstallMentPeriodFormate.TabIndex = 145;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(17, 8);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(74, 15);
            this.label31.TabIndex = 143;
            this.label31.Text = "EMI Period :\r\n";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(169, 9);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(58, 15);
            this.label29.TabIndex = 141;
            this.label29.Text = "Formate :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(478, 222);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(103, 15);
            this.label28.TabIndex = 156;
            this.label28.Text = "Payable Amount :";
            // 
            // nudEmiPaidDay
            // 
            this.nudEmiPaidDay.Location = new System.Drawing.Point(557, 122);
            this.nudEmiPaidDay.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.nudEmiPaidDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEmiPaidDay.Name = "nudEmiPaidDay";
            this.nudEmiPaidDay.Size = new System.Drawing.Size(224, 23);
            this.nudEmiPaidDay.TabIndex = 9;
            this.nudEmiPaidDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudEmiPaidDay.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudEmiPaidDay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtPayableAmount
            // 
            this.txtPayableAmount.Location = new System.Drawing.Point(582, 219);
            this.txtPayableAmount.Name = "txtPayableAmount";
            this.txtPayableAmount.ReadOnly = true;
            this.txtPayableAmount.Size = new System.Drawing.Size(128, 23);
            this.txtPayableAmount.TabIndex = 12;
            this.txtPayableAmount.Text = "0";
            this.txtPayableAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CoOperativeSociety.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(647, 496);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.Controls.Add(this.iControl_Button_21);
            this.panel4.Controls.Add(this.dgvEMIView);
            this.panel4.Location = new System.Drawing.Point(3, 365);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(793, 274);
            this.panel4.TabIndex = 2;
            // 
            // iControl_Button_21
            // 
            this.iControl_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iControl_Button_21.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iControl_Button_21.ForeColor = System.Drawing.Color.White;
            this.iControl_Button_21.Image = null;
            this.iControl_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iControl_Button_21.Location = new System.Drawing.Point(172, 5);
            this.iControl_Button_21.Name = "iControl_Button_21";
            this.iControl_Button_21.Size = new System.Drawing.Size(464, 27);
            this.iControl_Button_21.TabIndex = 23;
            this.iControl_Button_21.Text = "Monthly Installment Details";
            this.iControl_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dgvEMIView
            // 
            this.dgvEMIView.AllowUserToAddRows = false;
            this.dgvEMIView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvEMIView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEMIView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEMIView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEMIView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEMIView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEMIView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEMIView.ColumnHeadersHeight = 20;
            this.dgvEMIView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.Installment,
            this.Interest,
            this.Principal,
            this.Balance});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEMIView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEMIView.Location = new System.Drawing.Point(3, 32);
            this.dgvEMIView.Name = "dgvEMIView";
            this.dgvEMIView.Size = new System.Drawing.Size(787, 239);
            this.dgvEMIView.TabIndex = 21;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 15);
            this.label9.TabIndex = 120;
            this.label9.Text = "Loan Bank A/C:";
            // 
            // cmbLoanBank
            // 
            this.cmbLoanBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanBank.FormattingEnabled = true;
            this.cmbLoanBank.Location = new System.Drawing.Point(124, 37);
            this.cmbLoanBank.Name = "cmbLoanBank";
            this.cmbLoanBank.Size = new System.Drawing.Size(657, 23);
            this.cmbLoanBank.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::CoOperativeSociety.Properties.Resources.refresh1;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(715, 216);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Teal;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CoOperativeSociety.Properties.Resources.Cancel16X16;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(742, 496);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.BackColor = System.Drawing.Color.Blue;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Location = new System.Drawing.Point(0, 183);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(794, 2);
            this.label27.TabIndex = 154;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label26.Location = new System.Drawing.Point(0, 77);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(794, 2);
            this.label26.TabIndex = 153;
            // 
            // txtPurpose
            // 
            this.txtPurpose.BackColor = System.Drawing.SystemColors.Window;
            this.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurpose.Location = new System.Drawing.Point(73, 197);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(398, 45);
            this.txtPurpose.TabIndex = 10;
            this.txtPurpose.Text = "";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 202);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 15);
            this.label25.TabIndex = 151;
            this.label25.Text = "Purpose :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(439, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 15);
            this.label16.TabIndex = 133;
            this.label16.Text = "Principal Amount :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(480, 202);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 15);
            this.label22.TabIndex = 146;
            this.label22.Text = "Monthly EMI";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(439, 114);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 30);
            this.label19.TabIndex = 138;
            this.label19.Text = "EMI Paid Day\r\n (Collection Date):";
            // 
            // txtMonthlyEMIAm
            // 
            this.txtMonthlyEMIAm.Location = new System.Drawing.Point(582, 193);
            this.txtMonthlyEMIAm.Name = "txtMonthlyEMIAm";
            this.txtMonthlyEMIAm.ReadOnly = true;
            this.txtMonthlyEMIAm.Size = new System.Drawing.Size(128, 23);
            this.txtMonthlyEMIAm.TabIndex = 11;
            this.txtMonthlyEMIAm.Text = "0";
            this.txtMonthlyEMIAm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrincipalAm
            // 
            this.txtPrincipalAm.Location = new System.Drawing.Point(557, 93);
            this.txtPrincipalAm.Name = "txtPrincipalAm";
            this.txtPrincipalAm.ReadOnly = true;
            this.txtPrincipalAm.Size = new System.Drawing.Size(224, 23);
            this.txtPrincipalAm.TabIndex = 8;
            this.txtPrincipalAm.Text = "0";
            this.txtPrincipalAm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrincipalAm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSectionAm_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(618, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 15);
            this.label17.TabIndex = 135;
            this.label17.Text = "No Of EMI :";
            // 
            // btnLoanCalculator
            // 
            this.btnLoanCalculator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoanCalculator.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoanCalculator.FlatAppearance.BorderSize = 0;
            this.btnLoanCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanCalculator.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanCalculator.ForeColor = System.Drawing.Color.White;
            this.btnLoanCalculator.Image = global::CoOperativeSociety.Properties.Resources.calculator_18;
            this.btnLoanCalculator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoanCalculator.Location = new System.Drawing.Point(762, 6);
            this.btnLoanCalculator.Name = "btnLoanCalculator";
            this.btnLoanCalculator.Size = new System.Drawing.Size(29, 29);
            this.btnLoanCalculator.TabIndex = 123;
            this.btnLoanCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoanCalculator.UseVisualStyleBackColor = false;
            this.btnLoanCalculator.Click += new System.EventHandler(this.btnLoanCalculator_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 5);
            this.panel2.TabIndex = 111;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(4, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(830, 448);
            this.panel3.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.pnlLoanDetails);
            this.flowLayoutPanel1.Controls.Add(this.pnlBankDetails001);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(818, 430);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlLoanDetails
            // 
            this.pnlLoanDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLoanDetails.BackColor = System.Drawing.Color.White;
            this.pnlLoanDetails.Controls.Add(this.label15);
            this.pnlLoanDetails.Controls.Add(this.txtSectionROIAm);
            this.pnlLoanDetails.Controls.Add(this.btnRefresh);
            this.pnlLoanDetails.Controls.Add(this.label32);
            this.pnlLoanDetails.Controls.Add(this.nudSectionROI);
            this.pnlLoanDetails.Controls.Add(this.pnlForLoanType);
            this.pnlLoanDetails.Controls.Add(this.label28);
            this.pnlLoanDetails.Controls.Add(this.nudEmiPaidDay);
            this.pnlLoanDetails.Controls.Add(this.txtPayableAmount);
            this.pnlLoanDetails.Controls.Add(this.label27);
            this.pnlLoanDetails.Controls.Add(this.label26);
            this.pnlLoanDetails.Controls.Add(this.txtPurpose);
            this.pnlLoanDetails.Controls.Add(this.label25);
            this.pnlLoanDetails.Controls.Add(this.label16);
            this.pnlLoanDetails.Controls.Add(this.label22);
            this.pnlLoanDetails.Controls.Add(this.label19);
            this.pnlLoanDetails.Controls.Add(this.txtMonthlyEMIAm);
            this.pnlLoanDetails.Controls.Add(this.txtPrincipalAm);
            this.pnlLoanDetails.Controls.Add(this.label17);
            this.pnlLoanDetails.Controls.Add(this.nudNoOfEmi);
            this.pnlLoanDetails.Controls.Add(this.label14);
            this.pnlLoanDetails.Controls.Add(this.label13);
            this.pnlLoanDetails.Controls.Add(this.cmbLoanSubType);
            this.pnlLoanDetails.Controls.Add(this.label12);
            this.pnlLoanDetails.Controls.Add(this.cmbLoanType);
            this.pnlLoanDetails.Controls.Add(this.label11);
            this.pnlLoanDetails.Controls.Add(this.label10);
            this.pnlLoanDetails.Controls.Add(this.cmbLoanSlNo);
            this.pnlLoanDetails.Controls.Add(this.label8);
            this.pnlLoanDetails.Controls.Add(this.label7);
            this.pnlLoanDetails.Controls.Add(this.dtpDateOfLoan);
            this.pnlLoanDetails.Controls.Add(this.txtSectionAm);
            this.pnlLoanDetails.Location = new System.Drawing.Point(3, 3);
            this.pnlLoanDetails.Name = "pnlLoanDetails";
            this.pnlLoanDetails.Size = new System.Drawing.Size(794, 248);
            this.pnlLoanDetails.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 15);
            this.label15.TabIndex = 165;
            this.label15.Text = "Interest Amount :";
            // 
            // txtSectionROIAm
            // 
            this.txtSectionROIAm.Location = new System.Drawing.Point(124, 144);
            this.txtSectionROIAm.Name = "txtSectionROIAm";
            this.txtSectionROIAm.Size = new System.Drawing.Size(295, 23);
            this.txtSectionROIAm.TabIndex = 7;
            this.txtSectionROIAm.Text = "0";
            this.txtSectionROIAm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudNoOfEmi
            // 
            this.nudNoOfEmi.Location = new System.Drawing.Point(688, 47);
            this.nudNoOfEmi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfEmi.Name = "nudNoOfEmi";
            this.nudNoOfEmi.Size = new System.Drawing.Size(93, 23);
            this.nudNoOfEmi.TabIndex = 4;
            this.nudNoOfEmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNoOfEmi.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nudNoOfEmi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfEmi.ValueChanged += new System.EventHandler(this.nudSectionROI_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 15);
            this.label14.TabIndex = 130;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 15);
            this.label13.TabIndex = 128;
            this.label13.Text = "Rate of Interest : ";
            // 
            // cmbLoanSubType
            // 
            this.cmbLoanSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanSubType.FormattingEnabled = true;
            this.cmbLoanSubType.Location = new System.Drawing.Point(105, 46);
            this.cmbLoanSubType.Name = "cmbLoanSubType";
            this.cmbLoanSubType.Size = new System.Drawing.Size(157, 23);
            this.cmbLoanSubType.TabIndex = 3;
            this.cmbLoanSubType.SelectedIndexChanged += new System.EventHandler(this.cmbLoanSubType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 15);
            this.label12.TabIndex = 125;
            this.label12.Text = "Loan Sub Type :";
            // 
            // cmbLoanType
            // 
            this.cmbLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanType.FormattingEnabled = true;
            this.cmbLoanType.Location = new System.Drawing.Point(647, 10);
            this.cmbLoanType.Name = "cmbLoanType";
            this.cmbLoanType.Size = new System.Drawing.Size(134, 23);
            this.cmbLoanType.TabIndex = 2;
            this.cmbLoanType.SelectedIndexChanged += new System.EventHandler(this.cmbLoanType_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(575, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 15);
            this.label11.TabIndex = 123;
            this.label11.Text = "Loan Type :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 15);
            this.label10.TabIndex = 121;
            this.label10.Text = "Sanction Amount :";
            // 
            // cmbLoanSlNo
            // 
            this.cmbLoanSlNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbLoanSlNo.FormattingEnabled = true;
            this.cmbLoanSlNo.Location = new System.Drawing.Point(105, 11);
            this.cmbLoanSlNo.Name = "cmbLoanSlNo";
            this.cmbLoanSlNo.Size = new System.Drawing.Size(280, 23);
            this.cmbLoanSlNo.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 115;
            this.label8.Text = "Socity Loan No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 113;
            this.label7.Text = "Date of Loan :";
            // 
            // dtpDateOfLoan
            // 
            this.dtpDateOfLoan.CustomFormat = "dd-MMM-yyyy";
            this.dtpDateOfLoan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfLoan.Location = new System.Drawing.Point(473, 11);
            this.dtpDateOfLoan.Name = "dtpDateOfLoan";
            this.dtpDateOfLoan.Size = new System.Drawing.Size(95, 23);
            this.dtpDateOfLoan.TabIndex = 1;
            // 
            // txtSectionAm
            // 
            this.txtSectionAm.Location = new System.Drawing.Point(124, 90);
            this.txtSectionAm.Name = "txtSectionAm";
            this.txtSectionAm.Size = new System.Drawing.Size(295, 23);
            this.txtSectionAm.TabIndex = 5;
            this.txtSectionAm.Text = "0";
            this.txtSectionAm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSectionAm.TextChanged += new System.EventHandler(this.txtSectionAm_TextChanged);
            this.txtSectionAm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSectionAm_KeyPress);
            // 
            // pnlBankDetails001
            // 
            this.pnlBankDetails001.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlBankDetails001.Controls.Add(this.cmbLedgerBank);
            this.pnlBankDetails001.Controls.Add(this.label3);
            this.pnlBankDetails001.Controls.Add(this.label2);
            this.pnlBankDetails001.Controls.Add(this.cmbSavingBank);
            this.pnlBankDetails001.Controls.Add(this.label1);
            this.pnlBankDetails001.Controls.Add(this.cmbLoanBank);
            this.pnlBankDetails001.Controls.Add(this.label9);
            this.pnlBankDetails001.Location = new System.Drawing.Point(3, 257);
            this.pnlBankDetails001.Name = "pnlBankDetails001";
            this.pnlBankDetails001.Size = new System.Drawing.Size(794, 102);
            this.pnlBankDetails001.TabIndex = 1;
            // 
            // cmbLedgerBank
            // 
            this.cmbLedgerBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLedgerBank.FormattingEnabled = true;
            this.cmbLedgerBank.Location = new System.Drawing.Point(124, 6);
            this.cmbLedgerBank.Name = "cmbLedgerBank";
            this.cmbLedgerBank.Size = new System.Drawing.Size(657, 23);
            this.cmbLedgerBank.TabIndex = 0;
            this.cmbLedgerBank.SelectedIndexChanged += new System.EventHandler(this.cmbLedgerBank_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 124;
            this.label3.Text = "Bank Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 123;
            this.label2.Text = "Saving Bank A/C :";
            // 
            // cmbSavingBank
            // 
            this.cmbSavingBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSavingBank.FormattingEnabled = true;
            this.cmbSavingBank.Location = new System.Drawing.Point(124, 76);
            this.cmbSavingBank.Name = "cmbSavingBank";
            this.cmbSavingBank.Size = new System.Drawing.Size(657, 23);
            this.cmbSavingBank.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(394, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 121;
            this.label1.Text = "To";
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::CoOperativeSociety.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(795, -2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(39, 40);
            this.btnHelp.TabIndex = 105;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(43, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 104;
            this.label4.Text = "New Loan ::";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtRefNo);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLoanCalculator);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 533);
            this.panel1.TabIndex = 0;
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(258, 12);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.ReadOnly = true;
            this.txtRefNo.Size = new System.Drawing.Size(214, 23);
            this.txtRefNo.TabIndex = 127;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(201, 15);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(47, 15);
            this.label39.TabIndex = 126;
            this.label39.Text = "Ref No.";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CoOperativeSociety.Properties.Resources.information32X32;
            this.button1.Location = new System.Drawing.Point(4, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 40);
            this.button1.TabIndex = 124;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SocietyLoanEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 533);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SocietyLoanEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.nudSectionROI)).EndInit();
            this.pnlForLoanType.ResumeLayout(false);
            this.pnlForLoanType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmiPaidDay)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMIView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlLoanDetails.ResumeLayout(false);
            this.pnlLoanDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfEmi)).EndInit();
            this.pnlBankDetails001.ResumeLayout(false);
            this.pnlBankDetails001.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown nudSectionROI;
        private System.Windows.Forms.Panel pnlForLoanType;
        private System.Windows.Forms.TextBox txtEmiPeriod;
        private System.Windows.Forms.TextBox txtInstallMentPeriodFormate;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown nudEmiPaidDay;
        private System.Windows.Forms.TextBox txtPayableAmount;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvEMIView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Installment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbLoanBank;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.RichTextBox txtPurpose;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMonthlyEMIAm;
        private System.Windows.Forms.TextBox txtPrincipalAm;
        private System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Button btnLoanCalculator;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlLoanDetails;
        private System.Windows.Forms.NumericUpDown nudNoOfEmi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbLoanSubType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbLoanType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbLoanSlNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDateOfLoan;
        private System.Windows.Forms.TextBox txtSectionAm;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBankDetails001;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSavingBank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSectionROIAm;
        private System.Windows.Forms.ComboBox cmbLedgerBank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRefNo;
        private System.Windows.Forms.Label label39;
        private BusinessEntities.IControl_Button_2 iControl_Button_21;
    }
}