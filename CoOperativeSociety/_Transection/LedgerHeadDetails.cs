using BusinessEntities;
using BusinessEntities._enum;
using SocietyBusinessAccess.Ledgers;
using SocietyBusinessAccess.Transections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoOperativeSociety._Transection
{
    public partial class LedgerHeadDetails : Form
    {
        #region --------------------Object Type--------------
        //Objects
        #region --------------ADGV------------
        private DataTable _dtdgvLedgerDetails = new DataTable();
        private DataTable _dataTable = new DataTable();
        private DataSet _dataSet = new DataSet();
        #endregion

        DataTable _dtdgvLedgers = new DataTable();
        LedgerBA ledgerBa = new LedgerBA();
        TransectionBA transectionBA = new TransectionBA();
        #endregion

        public LedgerHeadDetails()
        {
            InitializeComponent();

            #region ====Event of ADGV====
            this.dgvLedgerDetails.SortStringChanged += new System.EventHandler(this.dgvLedgerDetails_SortStringChanged);
            this.dgvLedgerDetails.FilterStringChanged += new System.EventHandler(this.dgvLedgerDetails_FilterStringChanged);
            this.searchToolBar.Search += new ADGV.SearchToolBarSearchEventHandler(this.searchToolBar_Search);

            #endregion

            dgvLedgers.SelectionChanged -= dgvLedgers_SelectionChanged;
            //Ledger
            CreatedgvLedgersCol();
            GetLedgers();//fill
            dgvLedgers.SelectionChanged += dgvLedgers_SelectionChanged;

            //LedgerDetails
            SourceDgv();
            CreateColumn();
        }

        #region ====================Ledgers=================
        #region ----Method---
        private void CreatedgvLedgersCol()
        {
            _dtdgvLedgers.Clear();
            //Add Column
            _dtdgvLedgers.AddDataTableColumns(new List<string> { "LedgerId", "LedgerName" });

            //Source
            dgvLedgers.DataSource = _dtdgvLedgers;

            //===DESIGN==
            dgvLedgers.Columns["LedgerId"].Visible = false;
        }
        private void GetLedgers()
        {
            _dtdgvLedgers.Rows.Clear();

            //Get
            List<Ledger> lstLedger = ledgerBa.GetLedger();
            if (lstLedger.IsValidList())
            {
                //Fill
                foreach (Ledger item in lstLedger)
                {
                    _dtdgvLedgers.Rows.Add(item.LedgerId, item.LedgerName);
                }
            }
        }
        #endregion

        #region ----Event----
        private void dgvLedgers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLedgers.SelectedRows.Count > 0)
            {
                string _LedgerFrom = dgvLedgers.SelectedRows[0].Cells["LedgerId"].Value.ConvertObjectToString();
                FillLedgerDetails(_LedgerFrom);
            }
        }

        #endregion
        #endregion

        #region =============Ledgers Details================
        private void SourceDgv()
        {
            //initialize bindingsource
            bindingSourceForView.DataSource = _dataSet;

            //initialize datagridview
            dgvLedgerDetails.DataSource = bindingSourceForView;
        }

        private void CreateColumn()
        {
            _dtdgvLedgerDetails = new DataTable();

            //==========datatable table name iniatilize==========
            _dtdgvLedgerDetails = _dataSet.Tables.Add("ListTable");

            //Source Datatable
            _dtdgvLedgerDetails.AddDataTableColumns(new List<string> { "TransectionID", "Date", "No", "TransectionType", "Transection_Ref_No",
                                                    "LedgerIdFrom","LedgerName_From", "LedgerIdTo", "LedgerName_To",
                                                    "Amount_Dr", "Amount_Cr", "Mode", "BankName", "ChequeNo", "ChequeDate", "Narration", "Status"});


            //============initialize bindingsource=================
            bindingSourceForView.DataMember = _dtdgvLedgerDetails.TableName;

            searchToolBar.SetColumns(dgvLedgerDetails.Columns);

            //==========================Design=================
            dgvLedgerDetails.Columns["LedgerIdTo"].Visible = false;
            dgvLedgerDetails.Columns["LedgerIdFrom"].Visible = false;
            dgvLedgerDetails.Columns["TransectionID"].Visible = false;

        }

        private void FillLedgerDetails(string _LedgerFrom)
        {
            //Clear
            _dtdgvLedgerDetails.Rows.Clear();
            List<TransectionView> lstView = new List<TransectionView>();

            if (rbtnIndividually.Checked)
            {
                //individually
                lstView = transectionBA.GetTransectionsView(TransectionEnum._TransectionAttributes.LedgerIdFrom, _LedgerFrom, dtpFrom.Value, dtpTo.Value, string.Empty);
                splitContainer1.Panel1Collapsed = false;
            }
            else
            {
                //All
                lstView = transectionBA.GetTransectionsView();
                splitContainer1.Panel1Collapsed = true;
            }
            splitContainer1.Refresh();

            //Fill
            if (lstView.IsValidList())
            {
                foreach (var item in lstView)
                {
                    _dtdgvLedgerDetails.Rows.Add(item.TransectionID, item.Date.ToShortDateString(), item.No, item.TransectionType,
                       item.Transection_Ref_No, item.LedgerIdFrom, item.LedgerName_From, item.LedgerIdTo,
                       item.LedgerName_To, item.Amount_Dr, item.Amount_Cr, item.Mode, item.BankName, item.ChequeNo,
                       item.ChequeDate, item.Narration, item.Status);
                }
            }
        }
        #endregion
        
        #region====================== ADGV==================

        private void dgvLedgerDetails_SortStringChanged(object sender, System.EventArgs e)
        {
            bindingSourceForView.Sort = dgvLedgerDetails.SortString;
        }

        private void dgvLedgerDetails_FilterStringChanged(object sender, System.EventArgs e)
        {
            bindingSourceForView.Filter = dgvLedgerDetails.FilterString;
        }

        private void searchToolBar_Search(object sender, ADGV.SearchToolBarSearchEventArgs e)
        {
            bool restartsearch = true;
            int startColumn = 0;
            int startRow = 0;
            if (!e.FromBegin)
            {
                bool endcol = dgvLedgerDetails.CurrentCell.ColumnIndex + 1 >= dgvLedgerDetails.ColumnCount;
                bool endrow = dgvLedgerDetails.CurrentCell.RowIndex + 1 >= dgvLedgerDetails.RowCount;

                if (endcol && endrow)
                {
                    startColumn = dgvLedgerDetails.CurrentCell.ColumnIndex;
                    startRow = dgvLedgerDetails.CurrentCell.RowIndex;
                }
                else
                {
                    startColumn = endcol ? 0 : dgvLedgerDetails.CurrentCell.ColumnIndex + 1;
                    startRow = dgvLedgerDetails.CurrentCell.RowIndex + (endcol ? 1 : 0);
                }
            }
            DataGridViewCell c = dgvLedgerDetails.FindCell(
                e.ValueToSearch,
                e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                startRow,
                startColumn,
                e.WholeWord,
                e.CaseSensitive);
            if (c == null && restartsearch)
                c = dgvLedgerDetails.FindCell(
                    e.ValueToSearch,
                    e.ColumnToSearch != null ? e.ColumnToSearch.Name : null,
                    0,
                    0,
                    e.WholeWord,
                    e.CaseSensitive);
            if (c != null)
                dgvLedgerDetails.CurrentCell = c;
        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetLedgers();
            dgvLedgers_SelectionChanged(null, null);
        }

        private void rbtnIndividually_CheckedChanged(object sender, EventArgs e)
        {
            dgvLedgers_SelectionChanged(null, null);
        }
    }
}
