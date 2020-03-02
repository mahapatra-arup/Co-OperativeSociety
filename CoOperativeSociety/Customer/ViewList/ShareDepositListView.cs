using BusinessEntities;
using SocietyBusinessAccess.Loans;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CoOperativeSociety.Customer.ViewList
{
    public partial class ShareDepositListView : Form
    {
        //Objects
        #region --------------Object Type------------
        CustomerLoanBA customerLoanBA = new CustomerLoanBA();
        private DataTable _dtMainViewTable = new DataTable();
        private DataTable _dataTable = new DataTable();
        private DataSet _dataSet = new DataSet();
        #endregion
        public ShareDepositListView()
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


        #region ================Method===================
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

            _dtMainViewTable.AddDataTableColumns(new List<string> { "CustomerId", "LedgerId", "Sl.No.", "Customer Name", "DOB", "Mobile No.", "Date", "Reference No", "Loan No", "Amount" });

            //============initialize bindingsource=================
            bindingSourceForView.DataMember = _dtMainViewTable.TableName;

            searchToolBar.SetColumns(dgvView.Columns);

            //==========================Design=================
            dgvView.Columns["CustomerId"].Visible = false;
            dgvView.Columns["LedgerId"].Visible = false;
        }

        private void FillData()
        {
            _dtMainViewTable.Rows.Clear();
            List<GetSetValues<CustomerLoanDetail, CustomerList>> lst = customerLoanBA.GetCustomerLoanDetailsWithCustomer(dtpFrom.Value, dtpTo.Value);
            if (lst.ISValidObject())
            {
                foreach (var item in lst)
                {
                    CustomerLoanDetail _customerLoanDetail = item.Item1;
                    CustomerList _customerList = item.Item2;

                    _dtMainViewTable.Rows.Add(_customerList.CustomerId,
                    _customerList.LedgerId,
                    _dtMainViewTable.Rows.Count + 1,
                    _customerList.Customername,
                    _customerList.DOB.ConvertObjectToDateTime().ToShortDateString(),
                    _customerList.mNo,

                    //CustomerLoanDetail
                    _customerLoanDetail.Date,
                    _customerLoanDetail.Transection_Ref_No,
                    _customerLoanDetail.SocietyLoanSlNo,
                    _customerLoanDetail.ShareAmount);
                }
            }

            //======----TOTAL--=====
            #region ===Total Calculate==
            _dtMainViewTable.Rows.Add("", "", "", "", "", "","", "","TOTAL:-", lst.Sum(x => x.Item1.ShareAmount));

            //----===Design===----
            dgvView.DGVRowDesign(dgvView.Rows.Count - 1);

            Label lbl = new Label();
            lbl.Text = "Total:--";
            lbl.BackColor = Color.Khaki;
            lbl.ForeColor = Color.Black;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            dgvView.grid_LabelPaint(ref lbl, dgvView.Rows.Count - 1, 0,6);
            #endregion
        }
        #endregion
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillData();
        }

        #region====================== ADGV==================

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
    }
}
