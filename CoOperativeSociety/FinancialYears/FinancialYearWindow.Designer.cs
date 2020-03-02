namespace CoOperativeSociety.FinancialYears
{
    partial class FinancialYearWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvLoanTypes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iControl_Icon_Info1 = new BusinessEntities.IControl_Icon_Info();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iControl_GroupBox1 = new BusinessEntities.IControl_GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkIscurrentYear = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFinancialYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanTypes)).BeginInit();
            this.panel1.SuspendLayout();
            this.iControl_GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(307, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 26);
            this.button1.TabIndex = 118;
            this.button1.Text = "List of Year";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvLoanTypes
            // 
            this.dgvLoanTypes.AllowUserToAddRows = false;
            this.dgvLoanTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoanTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLoanTypes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLoanTypes.BackgroundColor = System.Drawing.Color.MintCream;
            this.dgvLoanTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLoanTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoanTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.YearName,
            this.Edit});
            this.dgvLoanTypes.Location = new System.Drawing.Point(307, 68);
            this.dgvLoanTypes.Name = "dgvLoanTypes";
            this.dgvLoanTypes.RowHeadersVisible = false;
            this.dgvLoanTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoanTypes.Size = new System.Drawing.Size(169, 228);
            this.dgvLoanTypes.TabIndex = 117;
            this.dgvLoanTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoanTypes_CellClick);
            this.dgvLoanTypes.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLoanTypes_CellMouseDown);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 24;
            // 
            // YearName
            // 
            this.YearName.HeaderText = "YearName";
            this.YearName.Name = "YearName";
            this.YearName.Width = 82;
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.HeaderText = "--Edit--";
            this.Edit.Name = "Edit";
            this.Edit.Width = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iControl_Icon_Info1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 37);
            this.panel1.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(40, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 104;
            this.label2.Text = "Financial Year";
            // 
            // iControl_Icon_Info1
            // 
            this.iControl_Icon_Info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iControl_Icon_Info1.ForeColor = System.Drawing.Color.Green;
            this.iControl_Icon_Info1.Location = new System.Drawing.Point(4, 3);
            this.iControl_Icon_Info1.Name = "iControl_Icon_Info1";
            this.iControl_Icon_Info1.Size = new System.Drawing.Size(33, 33);
            this.iControl_Icon_Info1.TabIndex = 103;
            this.iControl_Icon_Info1.Text = "iControl_Icon_Info1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 5);
            this.panel2.TabIndex = 173;
            // 
            // iControl_GroupBox1
            // 
            this.iControl_GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.iControl_GroupBox1.Controls.Add(this.btnUpdate);
            this.iControl_GroupBox1.Controls.Add(this.chkIscurrentYear);
            this.iControl_GroupBox1.Controls.Add(this.label5);
            this.iControl_GroupBox1.Controls.Add(this.label4);
            this.iControl_GroupBox1.Controls.Add(this.dtpEndDate);
            this.iControl_GroupBox1.Controls.Add(this.dtpStartDate);
            this.iControl_GroupBox1.Controls.Add(this.btnSave);
            this.iControl_GroupBox1.Controls.Add(this.btnCancel);
            this.iControl_GroupBox1.Controls.Add(this.txtFinancialYear);
            this.iControl_GroupBox1.Controls.Add(this.label1);
            this.iControl_GroupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iControl_GroupBox1.Location = new System.Drawing.Point(12, 51);
            this.iControl_GroupBox1.MinimumSize = new System.Drawing.Size(136, 50);
            this.iControl_GroupBox1.Name = "iControl_GroupBox1";
            this.iControl_GroupBox1.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.iControl_GroupBox1.Size = new System.Drawing.Size(289, 245);
            this.iControl_GroupBox1.TabIndex = 0;
            this.iControl_GroupBox1.Text = "Financial Year Entry";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::CoOperativeSociety.Properties.Resources.Save;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(99, 199);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 29);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // chkIscurrentYear
            // 
            this.chkIscurrentYear.AutoSize = true;
            this.chkIscurrentYear.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIscurrentYear.Location = new System.Drawing.Point(189, 159);
            this.chkIscurrentYear.Name = "chkIscurrentYear";
            this.chkIscurrentYear.Size = new System.Drawing.Size(88, 19);
            this.chkIscurrentYear.TabIndex = 3;
            this.chkIscurrentYear.Text = "Set Default ";
            this.chkIscurrentYear.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 120;
            this.label5.Text = "Date Between ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 119;
            this.label4.Text = "To";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(155, 118);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(110, 23);
            this.dtpEndDate.TabIndex = 2;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(12, 118);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(111, 23);
            this.dtpStartDate.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CoOperativeSociety.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(8, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&ADD";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Teal;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::CoOperativeSociety.Properties.Resources.Cancel16X16;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(189, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFinancialYear
            // 
            this.txtFinancialYear.Location = new System.Drawing.Point(12, 63);
            this.txtFinancialYear.Name = "txtFinancialYear";
            this.txtFinancialYear.Size = new System.Drawing.Size(253, 23);
            this.txtFinancialYear.TabIndex = 0;
            this.txtFinancialYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinancialYear_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 108;
            this.label1.Text = "Financial Year Name";
            // 
            // FinancialYearWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(480, 304);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLoanTypes);
            this.Controls.Add(this.iControl_GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FinancialYearWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoanTypes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.iControl_GroupBox1.ResumeLayout(false);
            this.iControl_GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BusinessEntities.IControl_GroupBox iControl_GroupBox1;
        private System.Windows.Forms.CheckBox chkIscurrentYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFinancialYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvLoanTypes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private BusinessEntities.IControl_Icon_Info iControl_Icon_Info1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearName;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        internal System.Windows.Forms.Button btnUpdate;
    }
}