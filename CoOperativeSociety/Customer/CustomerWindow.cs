using BusinessEntities;
using SocietyBusinessAccess.Customer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CoOperativeSociety.Customer
{
    public partial class CustomerWindow : Form
    {
        //Objects
        CustomerDetailsBA customerDetailsBA = new CustomerDetailsBA();
        private DataTable _dtCustomerTable = new DataTable();
        private DataTable _dataTable = new DataTable();
        private DataSet _dataSet = new DataSet();
        public CustomerWindow()
        {
            InitializeComponent();
            SourceDgv();//1
            CreateColumn();//2
            FillData();//3
        }

        #region ================Method===================
        private void SourceDgv()
        {
            //initialize bindingsource
            bindingSourceOfCustomer.DataSource = _dataSet;

            //initialize datagridview
            dgvView.DataSource = bindingSourceOfCustomer;
        }
        private void CreateColumn()
        {
            _dtCustomerTable = new DataTable();
            //==========datatable table name iniatilize==========
            _dtCustomerTable = _dataSet.Tables.Add("ListTable");

            //Add
            _dtCustomerTable.AddDataTableColumns(new List<string> { "CustomerId","LedgerId",
            "Customer Name",
            "DOB",
            //=======permanent Address Details========
            "pmVill",
            "pmPS",
            "pmDist",
            "pmPIN",
            //=======Present Address Details========
            "PrVill",
            "PrPS",
            "prDist",
            "PrPIN",
            //==========Contect Details=========
            "Mobile No.",
            "Email",
            //========Bank Details========
            "Bank Name",
            "Branch Name",
            "Branch Code",
            "IFC",
            "MICR",
            "Account No.",
            //=========Identification================
            "Aadhaar No",
            "Pan No"});

            //============initialize bindingsource=================
            bindingSourceOfCustomer.DataMember = _dtCustomerTable.TableName;

            searchToolBar.SetColumns(dgvView.Columns);

            //===============Design===============
            dgvView.Columns["CustomerId"].Visible = false;
            dgvView.Columns["LedgerId"].Visible = false;
        }

        private void FillData()
        {
            _dtCustomerTable.Rows.Clear();
            List<CustomerList> lstCustomerList = customerDetailsBA.GetCustomerList();
            if (lstCustomerList.ISValidObject())
            {
                foreach (CustomerList item in lstCustomerList)
                {
                    _dtCustomerTable.Rows.Add(item.CustomerId, item.LedgerId, item.Customername, item.DOB.ConvertObjectToDateTime().ToShortDateString(),
                        item.PrVill, item.PrPS, item.prDist, item.PrPIN, item.pmVill, item.pmPS, item.pmDist, item.pmPIN,
                        item.mNo, item.emailID, item.BankName, item.BranchName, item.BranchCode, item.BankIFC, item.MICRCode,
                        item.AccountNo, item.AadhaarNo, item.PanNo);
                }
            }
        } 
        #endregion

        #region ==================Event======================
        private void btnAddCustomer_Click(object sender, System.EventArgs e)
        {
            AddCustomer childForm = new AddCustomer();
            childForm.WindowState = FormWindowState.Normal;
            childForm.onClose += FrmAddCustomer_onClose;
            childForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            FillData();
        }


        private void btnDelete_Click(object sender, System.EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            if (dgvView.SelectedRows.Count>0)
            {
                Guid _Customerid = dgvView.SelectedRows[0].Cells["CustomerId"].Value.ConvertToGuid();
                AddCustomer frmAddCustomer = new AddCustomer();
                frmAddCustomer._lCustomerId =_Customerid;
                frmAddCustomer._lIsForEdit = true;
                frmAddCustomer.onClose += FrmAddCustomer_onClose;     
              frmAddCustomer.ShowDialog();
            }
        }

        private void FrmAddCustomer_onClose()
        {
            btnReload.PerformClick();
        }
        #endregion

        #region====================== ADGV==================

        private void dgvView_SortStringChanged(object sender, System.EventArgs e)
        {
            bindingSourceOfCustomer.Sort = dgvView.SortString;
        }

        private void dgvView_FilterStringChanged(object sender, System.EventArgs e)
        {
            bindingSourceOfCustomer.Filter = dgvView.FilterString;
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
