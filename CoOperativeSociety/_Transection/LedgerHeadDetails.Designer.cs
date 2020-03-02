namespace CoOperativeSociety._Transection
{
    partial class LedgerHeadDetails
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvLedgers = new System.Windows.Forms.DataGridView();
            this.searchToolBar = new ADGV.SearchToolBar();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvLedgerDetails = new ADGV.AdvancedDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSourceForView = new System.Windows.Forms.BindingSource(this.components);
            this.rbtnIndividually = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.btnSearch = new BusinessEntities.IControl_Button_2();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedgers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedgerDetails)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceForView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(1, 52);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dtpTo);
            this.splitContainer1.Panel1.Controls.Add(this.dtpFrom);
            this.splitContainer1.Panel1.Controls.Add(this.dgvLedgers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.searchToolBar);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.dgvLedgerDetails);
            this.splitContainer1.Size = new System.Drawing.Size(632, 458);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(-3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 3);
            this.label2.TabIndex = 185;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 183;
            this.label1.Text = "To";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(117, 6);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(87, 20);
            this.dtpTo.TabIndex = 182;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(7, 6);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(88, 20);
            this.dtpFrom.TabIndex = 181;
            // 
            // dgvLedgers
            // 
            this.dgvLedgers.AllowUserToAddRows = false;
            this.dgvLedgers.AllowUserToDeleteRows = false;
            this.dgvLedgers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLedgers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLedgers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLedgers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLedgers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLedgers.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLedgers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLedgers.EnableHeadersVisualStyles = false;
            this.dgvLedgers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvLedgers.Location = new System.Drawing.Point(0, 34);
            this.dgvLedgers.Name = "dgvLedgers";
            this.dgvLedgers.ReadOnly = true;
            this.dgvLedgers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvLedgers.RowHeadersVisible = false;
            this.dgvLedgers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLedgers.Size = new System.Drawing.Size(290, 424);
            this.dgvLedgers.TabIndex = 1;
            this.dgvLedgers.SelectionChanged += new System.EventHandler(this.dgvLedgers_SelectionChanged);
            // 
            // searchToolBar
            // 
            this.searchToolBar.AllowMerge = false;
            this.searchToolBar.BackColor = System.Drawing.Color.White;
            this.searchToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolBar.Location = new System.Drawing.Point(0, 0);
            this.searchToolBar.MaximumSize = new System.Drawing.Size(0, 27);
            this.searchToolBar.MinimumSize = new System.Drawing.Size(0, 27);
            this.searchToolBar.Name = "searchToolBar";
            this.searchToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.searchToolBar.Size = new System.Drawing.Size(338, 27);
            this.searchToolBar.TabIndex = 187;
            this.searchToolBar.Text = "searchToolBar1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(2, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 4);
            this.label3.TabIndex = 186;
            // 
            // dgvLedgerDetails
            // 
            this.dgvLedgerDetails.AllowUserToAddRows = false;
            this.dgvLedgerDetails.AllowUserToDeleteRows = false;
            this.dgvLedgerDetails.AllowUserToResizeColumns = false;
            this.dgvLedgerDetails.AllowUserToResizeRows = false;
            this.dgvLedgerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLedgerDetails.AutoGenerateContextFilters = true;
            this.dgvLedgerDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLedgerDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLedgerDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLedgerDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvLedgerDetails.ColumnHeadersHeight = 40;
            this.dgvLedgerDetails.DateWithTime = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLedgerDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLedgerDetails.EnableHeadersVisualStyles = false;
            this.dgvLedgerDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvLedgerDetails.Location = new System.Drawing.Point(0, 35);
            this.dgvLedgerDetails.Name = "dgvLedgerDetails";
            this.dgvLedgerDetails.ReadOnly = true;
            this.dgvLedgerDetails.RowHeadersWidth = 25;
            this.dgvLedgerDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLedgerDetails.Size = new System.Drawing.Size(338, 422);
            this.dgvLedgerDetails.TabIndex = 181;
            this.dgvLedgerDetails.TimeFilter = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.rbtnAll);
            this.panel1.Controls.Add(this.rbtnIndividually);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 46);
            this.panel1.TabIndex = 171;
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
            this.button1.TabIndex = 180;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(42, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 25);
            this.label4.TabIndex = 102;
            this.label4.Text = "Account Head Report ::";
            // 
            // rbtnIndividually
            // 
            this.rbtnIndividually.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnIndividually.AutoSize = true;
            this.rbtnIndividually.Checked = true;
            this.rbtnIndividually.Location = new System.Drawing.Point(497, 11);
            this.rbtnIndividually.Name = "rbtnIndividually";
            this.rbtnIndividually.Size = new System.Drawing.Size(77, 17);
            this.rbtnIndividually.TabIndex = 181;
            this.rbtnIndividually.TabStop = true;
            this.rbtnIndividually.Text = "Individually";
            this.rbtnIndividually.UseVisualStyleBackColor = true;
            this.rbtnIndividually.CheckedChanged += new System.EventHandler(this.rbtnIndividually_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(585, 12);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(36, 17);
            this.rbtnAll.TabIndex = 182;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnIndividually_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = null;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(207, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 25);
            this.btnSearch.TabIndex = 184;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LedgerHeadDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LedgerHeadDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedgers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedgerDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceForView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvLedgers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private BusinessEntities.IControl_Button_2 btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ADGV.AdvancedDataGridView dgvLedgerDetails;
        private System.Windows.Forms.BindingSource bindingSourceForView;
        private ADGV.SearchToolBar searchToolBar;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnIndividually;
    }
}