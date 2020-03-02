using BusinessEntities;
using CoOperativeSociety.Society.Loans;
using SocietyBusinessAccess.Loans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CoOperativeSociety.Society.ListView
{
    public partial class SocityLoanEMIView : Form
    {
        //Object Type
        #region ===================Object Type======================
        SocietyLoansBA societyLoansBA = new SocietyLoansBA();
        #endregion

        public SocityLoanEMIView()
        {
            InitializeComponent();
        }

        #region ======================Method========================
       
        #region =============Society Loan EMI===========
        private void DeletePaidLoanEMIs()
        {
            DialogResult dialogResult = MsgBox.Show("Are you Sure you want to Delete Selected EMI", "Delete", MsgBox.Buttons.YesNo, MsgBox.Icon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //Value
                long _EmiId = dgvSocityloanEMI.SelectedRows[0].Cells["ID"].Value.ConvertObjectToLong();
                string _Transection_ref_No = dgvSocityloanEMI.SelectedRows[0].Cells["Transection_Ref_No"].Value.ConvertObjectToString();

                SocietyLoanEMI frmCLE = new SocietyLoanEMI()
                {
                    ID = _EmiId,
                    IsPaid = false,
                    VoucherNo = null,
                    PaidDate = null,
                    Remarks = null,
                    Transection_Ref_No = null,
                };
                if (societyLoansBA.DeletePaidLoanEMIsWithTransection(_Transection_ref_No, frmCLE))
                {
                    MsgBox.Show("Record Delete Successfull", "Delete", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                    btnRefresh.PerformClick();
                }
            }
        }
        public void FillSocityLoanEmi(string _LoanSlNo)
        {
            //Clear
            if (dgvSocityloanEMI.DataSource != null)
            {
                dgvSocityloanEMI.DataSource = null;
            }

            //Clear
            dgvSocityloanEMI.Columns.Clear();

            //Get
            var list = societyLoansBA.GetSocityLoanEMI(_LoanSlNo).OrderBy(m => m.NoOfEMI);

            //==Fill==
            if (list.ISValidIEnumerableList())
            {

                var bindingList = new BindingList<SocietyLoanEMI>(list.ToList());
                var source = new BindingSource(bindingList, null);
                dgvSocityloanEMI.DataSource = source;

                //==design==
                SocityLoanEMIColumnDesign();

                //===Dynamic Button====
                #region =====Dynamic Button====
                //1
                var btnCol = new DataGridViewImageColumn();
                btnCol.Name = "btnCol";
                btnCol.HeaderText = "Action";
                btnCol.DefaultCellStyle.BackColor = Color.BlueViolet;
                btnCol.Width = 200;
                this.dgvSocityloanEMI.Columns.Add(btnCol);

                // For Delete 
                var btnCol2 = new DataGridViewImageColumn();
                btnCol2.Name = "btnCol2";
                btnCol2.HeaderText = "";
                btnCol2.DefaultCellStyle.BackColor = Color.BlueViolet;
                btnCol2.Width = 200;
                btnCol2.Image = (System.Drawing.Image)Properties.Resources.Delete;
                btnCol2.ImageLayout = DataGridViewImageCellLayout.Normal;
                btnCol2.ToolTipText = "Delete";
                this.dgvSocityloanEMI.Columns.Add(btnCol2);
                #endregion

                //-==============Total Calculate===========
                var lstTotal = societyLoansBA.CalculateTotalofLoanEmi(list.ToList());
                rtxtTotalDetails.Text = "<<--Paid-->>::   Principle (Rs.) : " + lstTotal.TotalPaidPrinciple + "       ||     Interest (Rs.) : " + lstTotal.TotalPaidInterest + "      ||     No Of EMI : " + lstTotal.TotalPaidNoofEMI + Environment.NewLine +
                 "<<--Due-->> ::   Principle (Rs.) : " + lstTotal.TotalDuePrinciple + "       ||      Interest (Rs.) : " + lstTotal.TotalDueInterest + "      ||     No Of EMI : " + lstTotal.TotalDueNoofEMI;

            }

            //======Design===========
            dgvSocityloanEMI_CellFormatting();
        }
        private void dgvSocityloanEMI_CellFormatting()
        {
            int c = 0;

            if (dgvSocityloanEMI.Rows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow item in dgvSocityloanEMI.Rows)
                    {
                        //=================Repayment Buton=============
                        DataGridViewImageCell cellRepayment = item.Cells["btnCol"] as DataGridViewImageCell;

                        //================Delete Button=================
                        DataGridViewImageCell cellDelete = item.Cells["btnCol2"] as DataGridViewImageCell;
                        cellDelete.Value = (System.Drawing.Image)Properties.Resources.refresh1;
                        cellDelete.ToolTipText = "Currently not Working";

                        if (c <= 0)
                        {
                            if (item.Cells["IsPaid"].Value.ConvertObjectToBool())
                            {
                                #region =======================Already Done===============

                                //=================Repayment=============
                                cellRepayment.Value = (System.Drawing.Image)Properties.Resources.DefaultSmall;
                                cellRepayment.ToolTipText = "Already Done";

                                //================Delete Button=================
                                cellDelete.Value = (System.Drawing.Image)Properties.Resources.Delete;
                                cellDelete.ToolTipText = "Delete";


                                //==========Row design==========
                                item.ReadOnly = true;
                                item.DefaultCellStyle.BackColor = Color.LimeGreen;
                                item.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
                                item.DefaultCellStyle.ForeColor = Color.Black;
                                item.DefaultCellStyle.SelectionForeColor = Color.Black;

                                #endregion

                            }
                            else
                            {
                                #region =============="Paid Now"==============
                                //===============Repayment Button========
                                DataGridViewImageCell cell = item.Cells["btnCol"] as DataGridViewImageCell;
                                cell.Value = (System.Drawing.Image)Properties.Resources.Structure;
                                cell.ToolTipText = "Paid Now";

                                //==========Row design==================
                                item.ReadOnly = false;
                                item.DefaultCellStyle.BackColor = Color.DarkOrange;
                                item.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
                                item.DefaultCellStyle.SelectionForeColor = Color.Black;
                                c++;
                                #endregion
                            }
                        }
                        else
                        {
                            #region ============="Processiong"================
                            //=================Repayment Buton=============
                            cellRepayment.Value = (System.Drawing.Image)Properties.Resources.Refresh;
                            cellRepayment.ToolTipText = "Processiong";


                            //==Row Color===========
                            item.ReadOnly = true;
                            item.DefaultCellStyle.BackColor = Color.LightCyan;
                            item.DefaultCellStyle.SelectionBackColor = Color.LightCyan;
                            item.DefaultCellStyle.ForeColor = Color.Black;
                            item.DefaultCellStyle.SelectionForeColor = Color.Black;
                            #endregion
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
            dgvSocityloanEMI.Refresh();
        }

        private void SocityLoanEMIColumnDesign()
        {
            //Design
            //Header Text
            dgvSocityloanEMI.Columns["NoOfEMI"].HeaderText = "No Of EMI";
            dgvSocityloanEMI.Columns["EMIDate"].HeaderText = "EMI Date";
            dgvSocityloanEMI.Columns["PrincipalAmount"].HeaderText = "Principal Amount";
            dgvSocityloanEMI.Columns["InterestAmount"].HeaderText = "Interest Amount";
            dgvSocityloanEMI.Columns["VoucherNo"].HeaderText = "Voucher No";
            dgvSocityloanEMI.Columns["PaidDate"].HeaderText = "Paid Date";
            dgvSocityloanEMI.Columns["Remarks"].HeaderText = "Remarks";
            dgvSocityloanEMI.Columns["Transection_Ref_No"].HeaderText = "Ref No";

            //Visible
            dgvSocityloanEMI.Columns["ID"].Visible = false;
            dgvSocityloanEMI.Columns["SocietyLoanSlNo"].Visible = false;
            dgvSocityloanEMI.Columns["SocietyLoanDetail"].Visible = false;

        }
        #endregion

        #region ==============Society Loan Details======
        public void FillSocityLoanDetails()
        {
            //=============Clear===============
            if (dgvSocityloanDetails.DataSource != null)
            {
                dgvSocityloanDetails.DataSource = null;
            }

            //===============Get=================
            IEnumerable<SocietyLoanDetail> list = societyLoansBA.GetSocityLoanDetails();

            //================Fill================
            if (list.ISValidIEnumerableList())
            {
                var bindingList = new BindingList<SocietyLoanDetail>(list.ToList());
                var source = new BindingSource(bindingList, null);
                dgvSocityloanDetails.DataSource = source;

                //================Design==============
                SocietyLoanDetailsColumnDesign();
            }
        }
        private void SocietyLoanDetailsColumnDesign()
        {
            //Visible
            dgvSocityloanDetails.Columns["id"].Visible = false;
            dgvSocityloanDetails.Columns["LedgerFrom"].Visible = false;
            dgvSocityloanDetails.Columns["LedgerTo"].Visible = false;
        }
        #endregion
        private void Clear()
        {
            //Socity loan Details Gried 
            if (dgvSocityloanDetails.DataSource != null)
            {
                dgvSocityloanDetails.DataSource = null;
            }

            //Customer loan EMI Gried 
            if (dgvSocityloanEMI.DataSource != null)
            {
                dgvSocityloanEMI.DataSource = null;
            }

        }

        #endregion

        #region =========================Event======================
        private void dgvSocityloanDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSocityloanDetails.SelectedRows.Count > 0)
            {
                string _SocietyLoanSlNo = dgvSocityloanDetails.SelectedRows[0].Cells["SocietyLoanSlNo"].Value.ConvertObjectToString();
                FillSocityLoanEmi(_SocietyLoanSlNo);
            }
        }


        private void dgvSocityloanEMI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == dgvSocityloanEMI.NewRowIndex || e.RowIndex < 0)
                return;

            //Handle ========Repayment Button Column Click=================
            #region ===================Repayment===================
            if (e.ColumnIndex == dgvSocityloanEMI.Columns["btnCol"].Index)
            {
                if (dgvSocityloanEMI.Rows[e.RowIndex].Cells["IsPaid"].Value.ConvertObjectToBool())
                {
                    //MessageBox.Show("---Already Paid---");
                }
                else
                {
                    if (dgvSocityloanEMI.Rows[e.RowIndex].ReadOnly == false)
                    {
                        SocityLoanRePayment childForm = new SocityLoanRePayment();
                        childForm.WindowState = FormWindowState.Normal;
                        childForm.onClose += ChildForm_onClose;
                        childForm.ShowDialog();
                    }
                }
            }
            #endregion

            //Handle ========Delete Button Column Click=================
            #region ===================Delete===================
            if (e.ColumnIndex == dgvSocityloanEMI.Columns["btnCol2"].Index)
            {
                if (dgvSocityloanEMI.Rows[e.RowIndex].Cells["IsPaid"].Value.ConvertObjectToBool())
                {
                    //("---Already Paid---");
                    DeletePaidLoanEMIs();
                }

            }
            #endregion
        }

        private void ChildForm_onClose()
        {
            btnRefresh.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvSocityloanDetails.Rows.Count > 0 ? dgvSocityloanDetails.SelectedRows[0].Index : 0;
            //
            Clear();
            //Fill Socity Loan Details
            FillSocityLoanDetails();

            //After Refresh Select Previous Index
            try { dgvSocityloanDetails.Rows[selectedRowIndex].Selected = true; } catch (Exception ex) { ex.ToWriteLog(Environment.StackTrace, "N/A"); };
        }

        #endregion
    }
}
