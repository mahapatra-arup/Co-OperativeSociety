namespace CoOperativeSociety.Customer
{
    partial class CustomerWindow
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchToolBar = new ADGV.SearchToolBar();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvView = new ADGV.AdvancedDataGridView();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.bindingSourceOfCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOfCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCustomer,
            this.toolStripSeparator1,
            this.btnEdit,
            this.toolStripSeparator3,
            this.btnDelete,
            this.toolStripSeparator4,
            this.btnReload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(645, 38);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 5);
            this.panel2.TabIndex = 172;
            // 
            // searchToolBar
            // 
            this.searchToolBar.AllowMerge = false;
            this.searchToolBar.BackColor = System.Drawing.Color.White;
            this.searchToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchToolBar.Location = new System.Drawing.Point(0, 38);
            this.searchToolBar.MaximumSize = new System.Drawing.Size(0, 27);
            this.searchToolBar.MinimumSize = new System.Drawing.Size(0, 27);
            this.searchToolBar.Name = "searchToolBar";
            this.searchToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.searchToolBar.Size = new System.Drawing.Size(645, 27);
            this.searchToolBar.TabIndex = 174;
            this.searchToolBar.Text = "searchToolBar1";
            this.searchToolBar.Search += new ADGV.SearchToolBarSearchEventHandler(this.searchToolBar_Search);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(628, 3);
            this.label2.TabIndex = 190;
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvView.AutoGenerateContextFilters = true;
            this.dgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvView.ColumnHeadersHeight = 50;
            this.dgvView.DateWithTime = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvView.EnableHeadersVisualStyles = false;
            this.dgvView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgvView.Location = new System.Drawing.Point(3, 79);
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.RowHeadersWidth = 25;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.Size = new System.Drawing.Size(637, 312);
            this.dgvView.TabIndex = 189;
            this.dgvView.TimeFilter = false;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem,
            this.modifyCustomerToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(168, 48);
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.CheckOnClick = true;
            this.newCustomerToolStripMenuItem.Image = global::CoOperativeSociety.Properties.Resources.button_dark_plus_icon;
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newCustomerToolStripMenuItem.Text = "New Customer";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // modifyCustomerToolStripMenuItem
            // 
            this.modifyCustomerToolStripMenuItem.CheckOnClick = true;
            this.modifyCustomerToolStripMenuItem.Image = global::CoOperativeSociety.Properties.Resources.Student_Alter;
            this.modifyCustomerToolStripMenuItem.Name = "modifyCustomerToolStripMenuItem";
            this.modifyCustomerToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.modifyCustomerToolStripMenuItem.Text = "Modify Customer";
            this.modifyCustomerToolStripMenuItem.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Image = global::CoOperativeSociety.Properties.Resources.button_dark_plus_icon;
            this.btnAddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(35, 35);
            this.btnAddCustomer.Text = "ADD";
            this.btnAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::CoOperativeSociety.Properties.Resources.Student_Alter;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(31, 35);
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::CoOperativeSociety.Properties.Resources.Student_Alter;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 35);
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReload
            // 
            this.btnReload.Image = global::CoOperativeSociety.Properties.Resources.Refresh;
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(47, 35);
            this.btnReload.Text = "Reload";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReload.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // CustomerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(645, 394);
            this.ContextMenuStrip = this.metroContextMenu1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.searchToolBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CustomerWindow";
            this.Text = "CustomerWindow";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOfCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSourceOfCustomer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel panel2;
        private ADGV.SearchToolBar searchToolBar;
        private System.Windows.Forms.Label label2;
        private ADGV.AdvancedDataGridView dgvView;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyCustomerToolStripMenuItem;
    }
}