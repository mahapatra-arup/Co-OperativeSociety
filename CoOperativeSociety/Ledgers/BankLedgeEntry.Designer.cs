namespace CoOperativeSociety.Ledgers
{
    partial class BankLedgeEntry
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
            this.cmbcrdr = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddBank = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbAcType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOpeningAmount = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLedgerName = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMICR = new System.Windows.Forms.TextBox();
            this.txtIFSC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAcNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBankName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlDETAILS = new System.Windows.Forms.Panel();
            this.txtBranchCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.pnlDETAILS.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbcrdr
            // 
            this.cmbcrdr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcrdr.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcrdr.FormattingEnabled = true;
            this.cmbcrdr.Items.AddRange(new object[] {
            "Dr.",
            "Cr."});
            this.cmbcrdr.Location = new System.Drawing.Point(341, 35);
            this.cmbcrdr.Name = "cmbcrdr";
            this.cmbcrdr.Size = new System.Drawing.Size(48, 25);
            this.cmbcrdr.TabIndex = 98;
            this.cmbcrdr.Tag = "Dr.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(289, 39);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 99;
            this.label13.Text = "Cr./Dr.";
            // 
            // btnAddBank
            // 
            this.btnAddBank.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBank.Location = new System.Drawing.Point(549, 13);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(23, 24);
            this.btnAddBank.TabIndex = 97;
            this.btnAddBank.Text = "+";
            this.btnAddBank.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(392, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 17);
            this.label10.TabIndex = 96;
            this.label10.Text = "On";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(422, 36);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(150, 25);
            this.dtpDate.TabIndex = 92;
            // 
            // cmbAcType
            // 
            this.cmbAcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAcType.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAcType.FormattingEnabled = true;
            this.cmbAcType.Location = new System.Drawing.Point(126, 55);
            this.cmbAcType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAcType.Name = "cmbAcType";
            this.cmbAcType.Size = new System.Drawing.Size(159, 25);
            this.cmbAcType.TabIndex = 88;
            this.cmbAcType.SelectedIndexChanged += new System.EventHandler(this.cmbBankName_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 95;
            this.label9.Text = "Account Type  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 93;
            this.label8.Text = "Opening Amount  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 94;
            this.label6.Text = "Address   :";
            // 
            // txtOpeningAmount
            // 
            this.txtOpeningAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpeningAmount.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpeningAmount.Location = new System.Drawing.Point(122, 35);
            this.txtOpeningAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtOpeningAmount.MaxLength = 12;
            this.txtOpeningAmount.Name = "txtOpeningAmount";
            this.txtOpeningAmount.Size = new System.Drawing.Size(159, 25);
            this.txtOpeningAmount.TabIndex = 89;
            this.txtOpeningAmount.Text = "0.00";
            this.txtOpeningAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOpeningAmount_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(134, 138);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(437, 54);
            this.txtAddress.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 90;
            this.label7.Text = "* Ledger Name  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 91;
            this.label5.Text = "Branch Name  :";
            // 
            // txtLedgerName
            // 
            this.txtLedgerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLedgerName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLedgerName.Location = new System.Drawing.Point(121, 6);
            this.txtLedgerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLedgerName.MaxLength = 50;
            this.txtLedgerName.Name = "txtLedgerName";
            this.txtLedgerName.Size = new System.Drawing.Size(450, 25);
            this.txtLedgerName.TabIndex = 86;
            // 
            // txtBranchName
            // 
            this.txtBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchName.Location = new System.Drawing.Point(135, 108);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBranchName.MaxLength = 50;
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(157, 25);
            this.txtBranchName.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 87;
            this.label4.Text = "MICR Code  :";
            // 
            // txtMICR
            // 
            this.txtMICR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMICR.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMICR.Location = new System.Drawing.Point(417, 78);
            this.txtMICR.Margin = new System.Windows.Forms.Padding(4);
            this.txtMICR.MaxLength = 20;
            this.txtMICR.Name = "txtMICR";
            this.txtMICR.Size = new System.Drawing.Size(155, 25);
            this.txtMICR.TabIndex = 83;
            // 
            // txtIFSC
            // 
            this.txtIFSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIFSC.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIFSC.Location = new System.Drawing.Point(135, 78);
            this.txtIFSC.Margin = new System.Windows.Forms.Padding(4);
            this.txtIFSC.MaxLength = 20;
            this.txtIFSC.Name = "txtIFSC";
            this.txtIFSC.Size = new System.Drawing.Size(157, 25);
            this.txtIFSC.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 82;
            this.label3.Text = "IFSC Code  :";
            // 
            // txtAcNo
            // 
            this.txtAcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAcNo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcNo.Location = new System.Drawing.Point(135, 46);
            this.txtAcNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcNo.MaxLength = 20;
            this.txtAcNo.Name = "txtAcNo";
            this.txtAcNo.Size = new System.Drawing.Size(436, 25);
            this.txtAcNo.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "* Account Number  :";
            // 
            // cmbBankName
            // 
            this.cmbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBankName.FormattingEnabled = true;
            this.cmbBankName.Location = new System.Drawing.Point(135, 14);
            this.cmbBankName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBankName.Name = "cmbBankName";
            this.cmbBankName.Size = new System.Drawing.Size(406, 25);
            this.cmbBankName.TabIndex = 78;
            this.cmbBankName.SelectedIndexChanged += new System.EventHandler(this.cmbBankName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "* Bank Name  :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CoOperativeSociety.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(424, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 29);
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "&SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Teal;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CoOperativeSociety.Properties.Resources.Cancel16X16;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(519, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 29);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = global::CoOperativeSociety.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(582, -1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(39, 40);
            this.btnHelp.TabIndex = 105;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 39);
            this.panel2.TabIndex = 103;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::CoOperativeSociety.Properties.Resources.information32X32;
            this.button2.Location = new System.Drawing.Point(0, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 40);
            this.button2.TabIndex = 171;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CoOperativeSociety.Properties.Resources.information32X32;
            this.button1.Location = new System.Drawing.Point(-671, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 40);
            this.button1.TabIndex = 123;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.GreenYellow;
            this.label11.Location = new System.Drawing.Point(42, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(261, 32);
            this.label11.TabIndex = 122;
            this.label11.Text = "Socity Bank Ledger  ::";
            // 
            // pnlDETAILS
            // 
            this.pnlDETAILS.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDETAILS.Controls.Add(this.txtBranchCode);
            this.pnlDETAILS.Controls.Add(this.label12);
            this.pnlDETAILS.Controls.Add(this.cmbBankName);
            this.pnlDETAILS.Controls.Add(this.label1);
            this.pnlDETAILS.Controls.Add(this.label2);
            this.pnlDETAILS.Controls.Add(this.txtAcNo);
            this.pnlDETAILS.Controls.Add(this.label3);
            this.pnlDETAILS.Controls.Add(this.txtIFSC);
            this.pnlDETAILS.Controls.Add(this.btnAddBank);
            this.pnlDETAILS.Controls.Add(this.txtMICR);
            this.pnlDETAILS.Controls.Add(this.label4);
            this.pnlDETAILS.Controls.Add(this.txtBranchName);
            this.pnlDETAILS.Controls.Add(this.label5);
            this.pnlDETAILS.Controls.Add(this.label6);
            this.pnlDETAILS.Controls.Add(this.txtAddress);
            this.pnlDETAILS.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDETAILS.Location = new System.Drawing.Point(16, 83);
            this.pnlDETAILS.Name = "pnlDETAILS";
            this.pnlDETAILS.Size = new System.Drawing.Size(591, 203);
            this.pnlDETAILS.TabIndex = 104;
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBranchCode.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchCode.Location = new System.Drawing.Point(417, 108);
            this.txtBranchCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBranchCode.MaxLength = 20;
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(155, 25);
            this.txtBranchCode.TabIndex = 98;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(322, 111);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 99;
            this.label12.Text = "Branch Code :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.txtLedgerName);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtOpeningAmount);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cmbcrdr);
            this.panel1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(16, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 61);
            this.panel1.TabIndex = 105;
            // 
            // BankLedgeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(623, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDETAILS);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbAcType);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "BankLedgeEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlDETAILS.ResumeLayout(false);
            this.pnlDETAILS.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbcrdr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddBank;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbAcType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOpeningAmount;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLedgerName;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMICR;
        private System.Windows.Forms.TextBox txtIFSC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAcNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBankName;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlDETAILS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBranchCode;
        private System.Windows.Forms.Label label12;
    }
}