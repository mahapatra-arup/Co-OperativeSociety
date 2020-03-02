using BusinessEntities;
using BusinessEntities.CustomProperties;
using SocietyBusinessAccess.Loans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoOperativeSociety.Customer.ViewList
{
    public partial class CustomerLoanStatement : Form
    {
        //Objects
        #region --------------Object Type---------------------
        CustomerLoanBA customerLoanBA = new CustomerLoanBA();
        private DataTable _dtMainViewTable = new DataTable();
        private DataTable _dataTable = new DataTable();
        private DataSet _dataSet = new DataSet();
        #endregion

        public CustomerLoanStatement()
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
            _dtMainViewTable.AddDataTableColumns(new List<string> { "Sl. No.", "CustomerID","Customer Name","Phone No", "Loan No", "Ref No", "Date", "Loan Amount", "Loan Interest", "Paid \nPrincipal Amount", "Paid \nInterest Amount", "Total Paid", "Total EMI","Paid EMI"});

            //============initialize bindingsource=================
            bindingSourceForView.DataMember = _dtMainViewTable.TableName;

            searchToolBar.SetColumns(dgvView.Columns);

            //==========================Design=================
            dgvView.Columns["CustomerID"].Visible = false;
            dgvView.Columns["Ref No"].Frozen = true;
        }

        private void FillData()
        {
            //Clear
            _dtMainViewTable.Rows.Clear();
            //Get
            List<CustomerLoanStatement_Properties> lst = customerLoanBA.GenerateCustometLoanStatement(dtpFrom.Value,dtpTo.Value);

            if (lst.IsValidList())
            {
                foreach (var item in lst)
                {
                    _dtMainViewTable.Rows.Add(_dtMainViewTable.Rows.Count + 1,
                     item.CustomerID, item.CustomerName, item.mNo,item.No,item.Transection_Ref_No,
                    item.Date.ToShortDateString(), item.TotalLoanAmount, item.TotalLoanInterestAmount,
                    item.TotalPaidPrincipalAmount, item.TotalPaidInterestAmount, (item.TotalPaidPrincipalAmount + item.TotalPaidInterestAmount),
                   item.TotalEMI, item.TotalPaidEMI
                 );
                }
            }

            //======----TOTAL--=====
            #region ===Total Calculate==
            _dtMainViewTable.Rows.Add("", "", "","","","", "TOTAL:-", lst.Sum(x => x.TotalLoanAmount), lst.Sum(x => x.TotalLoanInterestAmount)
               , lst.Sum(x => x.TotalPaidPrincipalAmount), lst.Sum(x => x.TotalPaidInterestAmount),
               (lst.Sum(x => x.TotalPaidPrincipalAmount) + lst.Sum(x => x.TotalPaidInterestAmount)),
                lst.Sum(x => x.TotalEMI),lst.Sum(x => x.TotalPaidEMI));

            //----===Design===----
            dgvView.DGVRowDesign(dgvView.Rows.Count - 1);

            Label lbl = new Label();
            lbl.Text = "Total";
            lbl.BackColor = Color.Khaki;
            lbl.ForeColor = Color.Black;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            dgvView.grid_LabelPaint(ref lbl, dgvView.Rows.Count - 1, 0, 6);
            #endregion
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
    
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillData();
        }
        #endregion

    }
}
