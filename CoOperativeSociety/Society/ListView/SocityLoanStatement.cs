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

namespace CoOperativeSociety.Society.ListView
{
    public partial class SocityLoanStatement : Form
    {
        //Objects
        #region --------------Object Type---------------------
        SocietyLoansBA societyLoansBA = new SocietyLoansBA();
        private DataTable _dtMainViewTable = new DataTable();
        private DataTable _dataTable = new DataTable();
        private DataSet _dataSet = new DataSet();
        #endregion

        public SocityLoanStatement()
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
            _dtMainViewTable.AddDataTableColumns(new List<string> { "Sl.No.", "Date", "Loan No", "Ref No", "Loan Amount", "Loan Interest","Paid \nPrincipal Amount", "Paid \nInterest Amount","Total Paid", "Total EMI", "Paid EMI", "Loan Bank", "Loan \nReceive Bank" });

            //============initialize bindingsource=================
            bindingSourceForView.DataMember = _dtMainViewTable.TableName;

            searchToolBar.SetColumns(dgvView.Columns);

            //==========Setting================
            dgvView.Columns["Ref No"].Frozen = true;
        }

        private void FillData()
        {
            //Clear
            _dtMainViewTable.Rows.Clear();
            //Get
            List<SocietyLoanStatement_Properties> lstView = societyLoansBA.GenerateSocityLoanStatement(dtpFrom.Value, dtpTo.Value);
            if (lstView.IsValidList())
            {
                foreach (var item in lstView)
                {
                    _dtMainViewTable.Rows.Add(_dtMainViewTable.Rows.Count + 1, item.Date.ToShortDateString(),
                    item.No, item.Transection_Ref_No, item.TotalLoanAmount, item.TotalLoanInterestAmount,
                    item.TotalPaidPrincipalAmount,item.TotalPaidInterestAmount, (item.TotalPaidPrincipalAmount+item.TotalPaidInterestAmount)
                    , item.TotalEMI, item.TotalPaidEMI,item.LoanBank, item.LoanReceiveBank
                    );
                }
            }

            //======----TOTAL--=====
            #region ===Total Calculate==
            _dtMainViewTable.Rows.Add("", "", "", "TOTAL:-", lstView.Sum(x => x.TotalLoanAmount), lstView.Sum(x => x.TotalLoanInterestAmount)
               ,lstView.Sum(x => x.TotalPaidPrincipalAmount), lstView.Sum(x => x.TotalPaidInterestAmount),
               (lstView.Sum(x => x.TotalPaidPrincipalAmount)+ lstView.Sum(x => x.TotalPaidInterestAmount)),
               lstView.Sum(x => x.TotalEMI),lstView.Sum(x => x.TotalPaidEMI));

            //----===Design===----
            dgvView.DGVRowDesign(dgvView.Rows.Count - 1);

            Label lbl = new Label();
            lbl.Text = "Total";
            lbl.BackColor = Color.Khaki;
            lbl.ForeColor = Color.Black;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            dgvView.grid_LabelPaint(ref lbl, dgvView.Rows.Count - 1, 0, 3);
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

        #endregion

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            FillData();
        }
    }
}
