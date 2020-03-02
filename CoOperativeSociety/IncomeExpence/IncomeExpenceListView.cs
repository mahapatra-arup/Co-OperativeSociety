using BusinessEntities;
using BusinessEntities._enum;
using SocietyBusinessAccess.Transections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CoOperativeSociety.IncomeExpence
{
    public partial class IncomeExpenceListView : Form
    {
        //Objects
        #region --------------Object Type---------------------
        TransectionBA transectionBA = new TransectionBA();
        private DataTable _dtMainViewTable = new DataTable();
        private DataTable _dataTable = new DataTable();
        private DataSet _dataSet = new DataSet();
        #endregion

        public IncomeExpenceListView()
        {
            InitializeComponent();

            #region ====Event of ADGV====
            this.dgvView.SortStringChanged += new System.EventHandler(this.dgvView_SortStringChanged);
            this.dgvView.FilterStringChanged += new System.EventHandler(this.dgvView_FilterStringChanged);
            this.searchToolBar.Search += new ADGV.SearchToolBarSearchEventHandler(this.searchToolBar_Search);
            #endregion

            SourceDgv();//1
            CreateColumn();//2
        }

        #region ================Method========================
        private void SourceDgv()
        {
            //initialize bindingsource
            bindingSourceForView.DataSource = _dataSet;

            //initialize datagridview
            dgvView.DataSource = bindingSourceForView;
        }

        private void CreateColumn()
        {
            _dtMainViewTable = new DataTable();
            //==========datatable table name iniatilize==========
            _dtMainViewTable = _dataSet.Tables.Add("ListTable");

            //Add Column
            _dtMainViewTable.AddDataTableColumns(new List<string> { "Sl.No.", "TransectionID", "Ref No","No", "Date", "Amount", "Mode", "Bank Name", "Cheque No", "Cheque Date", "Narration" });
            //MessageBox.Show(dtcolumn.Columns.Count.ToString());

            //============initialize bindingsource=================
            bindingSourceForView.DataMember = _dtMainViewTable.TableName;

            searchToolBar.SetColumns(dgvView.Columns);

            //==========================Design=================
            dgvView.Columns["TransectionID"].Visible = false;
        }

        private void FillInComeData()
        {
            _dtMainViewTable.Rows.Clear();

            string _OthersQuery = "isnull(Amount_Dr,0)>0";
            List<TransectionView> lst = transectionBA.GetTransectionsView(TransectionEnum._TransectionAttributes.TransectionType,TransectionEnum._TransectionTypeValues.Income, dtpFrom.Value, dtpTo.Value, _OthersQuery);

            if (lst.ISValidObject())
            {
                foreach (var item in lst)
                {
                    _dtMainViewTable.Rows.Add(_dtMainViewTable.Rows.Count + 1,
                        item.TransectionID, item.Transection_Ref_No, item.No,
                    item.Date.ToShortDateString(), item.Amount_Dr, item.Mode, item.BankName,
                   item.ChequeNo, item.ChequeDate.ISValidObject() ? item.ChequeDate.ConvertObjectToDateTime().ToString("dd-MMM-yyyy") : "", item.Narration
                 );
                }
            }
            //======----TOTAL--=====
            #region ===Total Calculate==
            _dtMainViewTable.Rows.Add("", "", "", "","TOTAL:-", lst.Sum(x => x.Amount_Dr));

            //----===Design===----
            dgvView.DGVRowDesign(dgvView.Rows.Count - 1);

            //First Part
            #region Label
            Label lbl = new Label();
            lbl.Text = "----Total:----";
            lbl.BackColor = Color.Khaki;
            lbl.ForeColor = Color.Black;
            lbl.TextAlign = ContentAlignment.MiddleCenter; 
            #endregion
            dgvView.grid_LabelPaint(ref lbl, dgvView.Rows.Count - 1, 0, 4);
            #endregion
        }

        private void FillExpenceData()
        {
            _dtMainViewTable.Rows.Clear();
            string _OthersQuery = "isnull(Amount_Dr,0)>0";
            List<TransectionView> lst = transectionBA.GetTransectionsView(TransectionEnum._TransectionAttributes.TransectionType, TransectionEnum._TransectionTypeValues.Expense, dtpFrom.Value, dtpTo.Value, _OthersQuery);
            if (lst.ISValidObject())
            {
                foreach (var item in lst)
                {
                    _dtMainViewTable.Rows.Add(_dtMainViewTable.Rows.Count + 1,
                        item.TransectionID, item.Transection_Ref_No, item.No,
                    item.Date.ToShortDateString(), item.Amount_Dr, item.Mode, item.BankName,
                   item.ChequeNo, item.ChequeDate.ISValidObject()? item.ChequeDate.ConvertObjectToDateTime().ToString("dd-MMM-yyyy"):"", item.Narration
                        );
                }
            }
            //======----TOTAL--=====
            #region ===Total Calculate==
            _dtMainViewTable.Rows.Add("", "", "", "", "TOTAL:-", lst.Sum(x => x.Amount_Dr));

            //----===Design===----
            dgvView.DGVRowDesign(dgvView.Rows.Count - 1);

            //First Part
            #region Label
            Label lbl = new Label();
            lbl.Text = "----Total :-- ";
            lbl.BackColor = Color.Khaki;
            lbl.ForeColor = Color.Black;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            #endregion
            dgvView.grid_LabelPaint(ref lbl, dgvView.Rows.Count - 1, 0, 3);
            #endregion
        }
        private void IncomeExpenseControl()
        {
            switch (rbtnIncome.Checked)
            {
                case true:
                    FillInComeData();
                    break;

                case false:
                    FillExpenceData();
                    break;

            }
        }
        #endregion

        #region====================== ADGV===================

        private void dgvView_SortStringChanged(object sender, System.EventArgs e)
        {
            bindingSourceForView.Sort = dgvView.SortString;
        }

        private void dgvView_FilterStringChanged(object sender, System.EventArgs e)
        {
            bindingSourceForView.Filter = dgvView.FilterString;
        }

        private void searchToolBar_Search(object sender, ADGV.SearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = dgvView.CurrentCell.ColumnIndex + 1 >= dgvView.ColumnCount;
                bool endrow = dgvView.CurrentCell.RowIndex + 1 >= dgvView.RowCount;

                if (endcol && endrow)
                {
                    startColumn = dgvView.CurrentCell.ColumnIndex;
                    startRow = dgvView.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : dgvView.CurrentCell.ColumnIndex + 1;
                    startRow = dgvView.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }
            DataGridViewCell c = dgvView.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = dgvView.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                dgvView.CurrentCell = c;
        }

        #endregion

        #region ================Event=========================

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IncomeExpenseControl();
        }

        private void rbtnIncome_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
