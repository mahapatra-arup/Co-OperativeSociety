namespace CoOperativeSociety.Others
{
    partial class LoanTypes
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbControl = new BusinessEntities.IControl_TabControl();
            this.tbpType = new System.Windows.Forms.TabPage();
            this.iControl_GroupBox1 = new BusinessEntities.IControl_GroupBox();
            this.iControl_Button_21 = new BusinessEntities.IControl_Button_2();
            this.dgvLoanType = new System.Windows.Forms.DataGridView();
            this.lnkSubTypeLink = new System.Windows.Forms.LinkLabel();
            this.btnADddLoanType = new BusinessEntities.IControl_Button_2();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLoanTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpSubType = new System.Windows.Forms.TabPage();
            this.lbllnkBackToType = new System.Windows.Forms.LinkLabel();
            this.dgvLoanSubTypeView = new System.Windows.Forms.DataGridView();
            this.btnLoanSubtypeAdd = new BusinessEntities.IControl_Button_2();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.nudEmiPeriod = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPeriodFormate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLoanMinRs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLoanType = new System.Windows.Forms.ComboBox();
            this.txtLoanSubType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtloanMaxRs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tbpType.SuspendLayout();
            this.iControl_GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanType)).BeginInit();
            this.tbpSubType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanSubTypeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmiPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 45);
            this.panel1.TabIndex = 106;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::CoOperativeSociety.Properties.Resources.information32X32;
            this.button2.Location = new System.Drawing.Point(3, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 40);
            this.button2.TabIndex = 122;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.GreenYellow;
            this.label4.Location = new System.Drawing.Point(42, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 28);
            this.label4.TabIndex = 104;
            this.label4.Text = "Loan Types / Sub Types ::\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 5);
            this.panel2.TabIndex = 172;
            // 
            // tbControl
            // 
            this.tbControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbControl.Controls.Add(this.tbpType);
            this.tbControl.Controls.Add(this.tbpSubType);
            this.tbControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tbControl.ItemSize = new System.Drawing.Size(44, 135);
            this.tbControl.Location = new System.Drawing.Point(0, 47);
            this.tbControl.Multiline = true;
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(673, 322);
            this.tbControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbControl.TabIndex = 0;
            // 
            // tbpType
            // 
            this.tbpType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tbpType.Controls.Add(this.iControl_GroupBox1);
            this.tbpType.Location = new System.Drawing.Point(139, 4);
            this.tbpType.Name = "tbpType";
            this.tbpType.Padding = new System.Windows.Forms.Padding(3);
            this.tbpType.Size = new System.Drawing.Size(530, 314);
            this.tbpType.TabIndex = 0;
            this.tbpType.Text = "Type";
            // 
            // iControl_GroupBox1
            // 
            this.iControl_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iControl_GroupBox1.Controls.Add(this.iControl_Button_21);
            this.iControl_GroupBox1.Controls.Add(this.dgvLoanType);
            this.iControl_GroupBox1.Controls.Add(this.lnkSubTypeLink);
            this.iControl_GroupBox1.Controls.Add(this.btnADddLoanType);
            this.iControl_GroupBox1.Controls.Add(this.button1);
            this.iControl_GroupBox1.Controls.Add(this.txtLoanTypeName);
            this.iControl_GroupBox1.Controls.Add(this.label1);
            this.iControl_GroupBox1.Location = new System.Drawing.Point(15, 15);
            this.iControl_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iControl_GroupBox1.Name = "iControl_GroupBox1";
            this.iControl_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iControl_GroupBox1.Size = new System.Drawing.Size(509, 290);
            this.iControl_GroupBox1.TabIndex = 115;
            this.iControl_GroupBox1.Text = "Loan Type Entry";
            // 
            // iControl_Button_21
            // 
            this.iControl_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iControl_Button_21.Enabled = false;
            this.iControl_Button_21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iControl_Button_21.ForeColor = System.Drawing.Color.White;
            this.iControl_Button_21.Image = null;
            this.iControl_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iControl_Button_21.Location = new System.Drawing.Point(48, 0);
            this.iControl_Button_21.Name = "iControl_Button_21";
            this.iControl_Button_21.Size = new System.Drawing.Size(410, 23);
            this.iControl_Button_21.TabIndex = 133;
            this.iControl_Button_21.Text = "Loan Type Entry";
            this.iControl_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dgvLoanType
            // 
            this.dgvLoanType.AllowUserToAddRows = false;
            this.dgvLoanType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoanType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoanType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoanType.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvLoanType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoanType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoanType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoanType.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoanType.Location = new System.Drawing.Point(11, 117);
            this.dgvLoanType.Name = "dgvLoanType";
            this.dgvLoanType.RowHeadersVisible = false;
            this.dgvLoanType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoanType.Size = new System.Drawing.Size(490, 145);
            this.dgvLoanType.TabIndex = 132;
            // 
            // lnkSubTypeLink
            // 
            this.lnkSubTypeLink.AutoSize = true;
            this.lnkSubTypeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubTypeLink.Location = new System.Drawing.Point(339, 265);
            this.lnkSubTypeLink.Name = "lnkSubTypeLink";
            this.lnkSubTypeLink.Size = new System.Drawing.Size(161, 16);
            this.lnkSubTypeLink.TabIndex = 131;
            this.lnkSubTypeLink.TabStop = true;
            this.lnkSubTypeLink.Text = "Go To Loan Sub Type  >>";
            this.lnkSubTypeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubTypeLink_LinkClicked);
            // 
            // btnADddLoanType
            // 
            this.btnADddLoanType.BackColor = System.Drawing.Color.Transparent;
            this.btnADddLoanType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADddLoanType.ForeColor = System.Drawing.Color.White;
            this.btnADddLoanType.Image = null;
            this.btnADddLoanType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADddLoanType.Location = new System.Drawing.Point(393, 56);
            this.btnADddLoanType.Name = "btnADddLoanType";
            this.btnADddLoanType.Size = new System.Drawing.Size(107, 23);
            this.btnADddLoanType.TabIndex = 130;
            this.btnADddLoanType.Text = "ADD";
            this.btnADddLoanType.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnADddLoanType.Click += new System.EventHandler(this.btnADddLoanType_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Beige;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(11, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(490, 23);
            this.button1.TabIndex = 129;
            this.button1.Text = "List Of Loan types";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtLoanTypeName
            // 
            this.txtLoanTypeName.Location = new System.Drawing.Point(14, 57);
            this.txtLoanTypeName.Name = "txtLoanTypeName";
            this.txtLoanTypeName.Size = new System.Drawing.Size(373, 20);
            this.txtLoanTypeName.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Loan Type";
            // 
            // tbpSubType
            // 
            this.tbpSubType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tbpSubType.Controls.Add(this.lbllnkBackToType);
            this.tbpSubType.Controls.Add(this.dgvLoanSubTypeView);
            this.tbpSubType.Controls.Add(this.btnLoanSubtypeAdd);
            this.tbpSubType.Controls.Add(this.button3);
            this.tbpSubType.Controls.Add(this.label10);
            this.tbpSubType.Controls.Add(this.nudEmiPeriod);
            this.tbpSubType.Controls.Add(this.label9);
            this.tbpSubType.Controls.Add(this.label8);
            this.tbpSubType.Controls.Add(this.cmbPeriodFormate);
            this.tbpSubType.Controls.Add(this.label7);
            this.tbpSubType.Controls.Add(this.txtLoanMinRs);
            this.tbpSubType.Controls.Add(this.label6);
            this.tbpSubType.Controls.Add(this.cmbLoanType);
            this.tbpSubType.Controls.Add(this.txtLoanSubType);
            this.tbpSubType.Controls.Add(this.label5);
            this.tbpSubType.Controls.Add(this.label2);
            this.tbpSubType.Controls.Add(this.txtloanMaxRs);
            this.tbpSubType.Controls.Add(this.label3);
            this.tbpSubType.Location = new System.Drawing.Point(139, 4);
            this.tbpSubType.Name = "tbpSubType";
            this.tbpSubType.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSubType.Size = new System.Drawing.Size(530, 314);
            this.tbpSubType.TabIndex = 1;
            this.tbpSubType.Text = "SubType";
            // 
            // lbllnkBackToType
            // 
            this.lbllnkBackToType.AutoSize = true;
            this.lbllnkBackToType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllnkBackToType.Location = new System.Drawing.Point(11, 295);
            this.lbllnkBackToType.Name = "lbllnkBackToType";
            this.lbllnkBackToType.Size = new System.Drawing.Size(56, 16);
            this.lbllnkBackToType.TabIndex = 134;
            this.lbllnkBackToType.TabStop = true;
            this.lbllnkBackToType.Text = "Back >>";
            this.lbllnkBackToType.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllnkBackToType_LinkClicked);
            // 
            // dgvLoanSubTypeView
            // 
            this.dgvLoanSubTypeView.AllowUserToAddRows = false;
            this.dgvLoanSubTypeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoanSubTypeView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoanSubTypeView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoanSubTypeView.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvLoanSubTypeView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoanSubTypeView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoanSubTypeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoanSubTypeView.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoanSubTypeView.Location = new System.Drawing.Point(3, 158);
            this.dgvLoanSubTypeView.Name = "dgvLoanSubTypeView";
            this.dgvLoanSubTypeView.RowHeadersVisible = false;
            this.dgvLoanSubTypeView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoanSubTypeView.Size = new System.Drawing.Size(524, 136);
            this.dgvLoanSubTypeView.TabIndex = 133;
            // 
            // btnLoanSubtypeAdd
            // 
            this.btnLoanSubtypeAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnLoanSubtypeAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanSubtypeAdd.ForeColor = System.Drawing.Color.White;
            this.btnLoanSubtypeAdd.Image = null;
            this.btnLoanSubtypeAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoanSubtypeAdd.Location = new System.Drawing.Point(434, 74);
            this.btnLoanSubtypeAdd.Name = "btnLoanSubtypeAdd";
            this.btnLoanSubtypeAdd.Size = new System.Drawing.Size(87, 23);
            this.btnLoanSubtypeAdd.TabIndex = 6;
            this.btnLoanSubtypeAdd.Text = "ADD";
            this.btnLoanSubtypeAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLoanSubtypeAdd.Click += new System.EventHandler(this.btnLoanSubtypeAdd_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Beige;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(3, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(524, 23);
            this.button3.TabIndex = 127;
            this.button3.Text = "List Of Loan Sub types";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(9, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 13);
            this.label10.TabIndex = 125;
            this.label10.Text = "YEAR / DAY : This Time are Not Available in EMI Period Form\r\n";
            this.label10.Visible = false;
            // 
            // nudEmiPeriod
            // 
            this.nudEmiPeriod.Location = new System.Drawing.Point(362, 76);
            this.nudEmiPeriod.Name = "nudEmiPeriod";
            this.nudEmiPeriod.Size = new System.Drawing.Size(66, 20);
            this.nudEmiPeriod.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 123;
            this.label9.Text = "EMI Period";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 122;
            this.label8.Text = "EMI Period Formate";
            // 
            // cmbPeriodFormate
            // 
            this.cmbPeriodFormate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodFormate.FormattingEnabled = true;
            this.cmbPeriodFormate.Items.AddRange(new object[] {
            "MONTH"});
            this.cmbPeriodFormate.Location = new System.Drawing.Point(166, 76);
            this.cmbPeriodFormate.Name = "cmbPeriodFormate";
            this.cmbPeriodFormate.Size = new System.Drawing.Size(184, 21);
            this.cmbPeriodFormate.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 120;
            this.label7.Text = "Loan Min Amount";
            // 
            // txtLoanMinRs
            // 
            this.txtLoanMinRs.Location = new System.Drawing.Point(10, 77);
            this.txtLoanMinRs.Name = "txtLoanMinRs";
            this.txtLoanMinRs.Size = new System.Drawing.Size(150, 20);
            this.txtLoanMinRs.TabIndex = 3;
            this.txtLoanMinRs.Text = "0";
            this.txtLoanMinRs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLoanMinRs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtloanMaxRs_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 118;
            this.label6.Text = "Loan Type";
            // 
            // cmbLoanType
            // 
            this.cmbLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoanType.FormattingEnabled = true;
            this.cmbLoanType.Location = new System.Drawing.Point(10, 25);
            this.cmbLoanType.Name = "cmbLoanType";
            this.cmbLoanType.Size = new System.Drawing.Size(184, 21);
            this.cmbLoanType.TabIndex = 0;
            this.cmbLoanType.SelectedIndexChanged += new System.EventHandler(this.cmbLoanType_SelectedIndexChanged);
            // 
            // txtLoanSubType
            // 
            this.txtLoanSubType.Location = new System.Drawing.Point(205, 26);
            this.txtLoanSubType.Name = "txtLoanSubType";
            this.txtLoanSubType.Size = new System.Drawing.Size(159, 20);
            this.txtLoanSubType.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 116;
            this.label5.Text = "Loan Sub Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Loan Max Amount";
            // 
            // txtloanMaxRs
            // 
            this.txtloanMaxRs.Location = new System.Drawing.Point(370, 26);
            this.txtloanMaxRs.Name = "txtloanMaxRs";
            this.txtloanMaxRs.Size = new System.Drawing.Size(154, 20);
            this.txtloanMaxRs.TabIndex = 2;
            this.txtloanMaxRs.Text = "0";
            this.txtloanMaxRs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtloanMaxRs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtloanMaxRs_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "EX: 3 Month=Quarterly, 6 Month=Half Yearly,12 Month=Yearly ";
            // 
            // LoanTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(677, 375);
            this.Controls.Add(this.tbControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "LoanTypes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tbpType.ResumeLayout(false);
            this.iControl_GroupBox1.ResumeLayout(false);
            this.iControl_GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanType)).EndInit();
            this.tbpSubType.ResumeLayout(false);
            this.tbpSubType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanSubTypeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmiPeriod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoanTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtloanMaxRs;
        private BusinessEntities.IControl_GroupBox iControl_GroupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private BusinessEntities.IControl_TabControl tbControl;
        private System.Windows.Forms.TabPage tbpType;
        private System.Windows.Forms.TabPage tbpSubType;
        private System.Windows.Forms.NumericUpDown nudEmiPeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPeriodFormate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLoanMinRs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLoanType;
        private System.Windows.Forms.TextBox txtLoanSubType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private BusinessEntities.IControl_Button_2 btnADddLoanType;
        private System.Windows.Forms.Button button1;
        private BusinessEntities.IControl_Button_2 btnLoanSubtypeAdd;
        private System.Windows.Forms.LinkLabel lnkSubTypeLink;
        private System.Windows.Forms.DataGridView dgvLoanType;
        private System.Windows.Forms.DataGridView dgvLoanSubTypeView;
        private System.Windows.Forms.LinkLabel lbllnkBackToType;
        private BusinessEntities.IControl_Button_2 iControl_Button_21;
    }
}