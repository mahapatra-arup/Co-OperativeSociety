using BusinessEntities;
using CoOperativeSociety.Customer.Loans.LoanRePayment;
using CoOperativeSociety.Tools;
using SocietyBusinessAccess.Customer;
using SocietyBusinessAccess.Loans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CoOperativeSociety
{
    public partial class CustomerEMIView : Form
    {
        //Object Type
        #region ==================Object Type===================
        string _CustomerId = string.Empty;
        CustomerLoanBA customerLoanBA = new CustomerLoanBA();
        CustomerDetailsBA customerBA = new CustomerDetailsBA();
        #endregion
        public CustomerEMIView()
        {
            InitializeComponent();

            //==GetCustomer==
            cmbCustomerName.AddCustomerName();
        }

        #region ======================Method====================
        #region ================Customer Loan Details==========
        public void FillCustomerDetails()
        {
            CustomerList cul = customerBA.GetCustomerList(_CustomerId);
            lblDob.Text = cul.DOB.ConvertObjectToDateTime().ToShortDateString();
            lblPhNo.Text = cul.mNo.ConvertObjectToString();
        }
        public void FillCustomerLoanDetails()
        {
            //Clear
            if (dgvCustomerloanDetails.DataSource != null)
            {
                dgvCustomerloanDetails.DataSource = null;
            }

            //Get
            IEnumerable<CustomerLoanDetail> list = customerLoanBA.GetCustomerLoanDetails(_CustomerId.ConvertToGuid());

            //Fill
            if (list.ISValidIEnumerableList())
            {

                var bindingList = new BindingList<CustomerLoanDetail>(list.ToList());
                var source = new BindingSource(bindingList, null);
                dgvCustomerloanDetails.DataSource = source;

                //Design after source
                CustomerLoanDetailsColumnDesign();
            }
        }
        private void CustomerLoanDetailsColumnDesign()
        {
            //Design
            #region ============================Design========================

            //Visible
            dgvCustomerloanDetails.Columns["LoanId"].Visible = false;
            dgvCustomerloanDetails.Columns["CustomerId"].Visible = false;

            #endregion
        }
        #endregion

        #region ===============Customer Loan EMI===============
        public void FillCustomerLoanEmi(Guid _LoanId)
        {
            //Clear
            if (dgvCustomerloanEMI.DataSource != null)
            {
                dgvCustomerloanEMI.DataSource = null;
            }
            //Clear
            dgvCustomerloanEMI.Columns.Clear();

            //Get
            var list = customerLoanBA.GetCustomerLoanEMI(_LoanId).OrderBy(m => m.NoOfEMI);

            //==Fill==
            if (list!=null)
            {

                var bindingList = new BindingList<CustomerLoanEMI>(list.ToList());
                var source = new BindingSource(bindingList, null);
                dgvCustomerloanEMI.DataSource = source;

                //Column Design
                CustomerLoanEMIColumnDesign();

                //===Dynamic Button====
                #region =====Dynamic Button====
                //1
                var btnCol = new DataGridViewImageColumn();
                btnCol.Name = "btnCol";
                btnCol.HeaderText = "Action";
                btnCol.DefaultCellStyle.BackColor = Color.BlueViolet;
                btnCol.Width = 200;
                //btnCol.DividerWidth = 3;
                this.dgvCustomerloanEMI.Columns.Add(btnCol);

                // For Delete 
                var btnCol2 = new DataGridViewImageColumn();
                btnCol2.Name = "btnCol2";
                btnCol2.HeaderText = "";
                btnCol2.DefaultCellStyle.BackColor = Color.BlueViolet;
                btnCol2.Width = 200;
                btnCol2.Image = (System.Drawing.Image)Properties.Resources.Delete;
                btnCol2.ImageLayout = DataGridViewImageCellLayout.Normal;
                btnCol2.ToolTipText = "Delete";
                this.dgvCustomerloanEMI.Columns.Add(btnCol2);
                #endregion

                //-==============Total Calculate===========
                var lstTotal = customerLoanBA.CalculateTotalofLoanEmi(list.ToList());
                rtxtTotalDetails.Text = "<<--Paid-->>::   Principle (Rs.) : " + lstTotal.TotalPaidPrinciple + "     ||     Interest (Rs.) : " + lstTotal.TotalPaidInterest + "      ||     No Of EMI : " + lstTotal.TotalPaidNoofEMI + Environment.NewLine +
                 "<<--Due-->> ::   Principle (Rs.) : " + lstTotal.TotalDuePrinciple + "       ||      Interest (Rs.) : " + lstTotal.TotalDueInterest + "      ||     No Of EMI : " + lstTotal.TotalDueNoofEMI;
            }

            //======Design===========
            dgvCustomerloanEMI_CellFormatting();
        }
        private void CustomerLoanEMIColumnDesign()
        {
            //Design
            #region ============================Design========================
            //Header Text
            dgvCustomerloanEMI.Columns["NoOfEMI"].HeaderText = "No Of EMI";
            dgvCustomerloanEMI.Columns["EMIDate"].HeaderText = "EMI Date";
            dgvCustomerloanEMI.Columns["PrincipalAmount"].HeaderText = "Principal Amount";
            dgvCustomerloanEMI.Columns["InterestAmount"].HeaderText = "Interest Amount";
            dgvCustomerloanEMI.Columns["VoucherNo"].HeaderText = "Voucher No";
            dgvCustomerloanEMI.Columns["PaidDate"].HeaderText = "Paid Date";
            dgvCustomerloanEMI.Columns["Remarks"].HeaderText = "Remarks";
            dgvCustomerloanEMI.Columns["Transection_Ref_No"].HeaderText = "Ref No";

            //Visible
            dgvCustomerloanEMI.Columns["ID"].Visible = false;
            dgvCustomerloanEMI.Columns["LoanId"].Visible = false;
            dgvCustomerloanEMI.Columns["CustomerLoanDetail"].Visible = false;

            #endregion
        }
        private void Clear()
        {
            //Customer Details
            lblDob.Text = string.Empty;
            lblPhNo.Text = string.Empty;

            //Customer loan Details Gried 
            if (dgvCustomerloanDetails.DataSource != null)
            {
                dgvCustomerloanDetails.DataSource = null;
            }

            //Customer loan EMI Gried 
            if (dgvCustomerloanEMI.DataSource != null)
            {
                dgvCustomerloanEMI.DataSource = null;
            }

        }
        private void DeletePaidLoanEMIs()
        {
            DialogResult dialogResult = MsgBox.Show("Are you Sure you want to Delete Selected EMI", "Delete", MsgBox.Buttons.YesNo, MsgBox.Icon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //Value
                long _EmiId = dgvCustomerloanEMI.SelectedRows[0].Cells["ID"].Value.ConvertObjectToLong();
                string _Transection_ref_No = dgvCustomerloanEMI.SelectedRows[0].Cells["Transection_Ref_No"].Value.ConvertObjectToString();

                CustomerLoanEMI frmCLE = new CustomerLoanEMI()
                {
                    ID = _EmiId,
                    IsPaid = false,
                    VoucherNo = null,
                    PaidDate = null,
                    Remarks = null,
                    Transection_Ref_No = null,
                };
                if (customerLoanBA.DeletePaidLoanEMIsWithTransection(_Transection_ref_No, frmCLE))
                {
                    MsgBox.Show("Record Delete Successfull", "Delete", MsgBox.Buttons.OK, MsgBox.Icon.Info);
                    btnRefresh.PerformClick();
                }
            }
        }

        private void dgvCustomerloanEMI_CellFormatting()
        {
            int c = 0;

            if (dgvCustomerloanEMI.Rows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow item in dgvCustomerloanEMI.Rows)
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
        }
        #endregion
        #endregion

        #region =======================Event===================
        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            int selectedRowIndex = dgvCustomerloanDetails.Rows.Count>0? dgvCustomerloanDetails.SelectedRows[0].Index:0;
            //
            Clear();
            if (cmbCustomerName.SelectedIndex >= 0)
            {
                //Customer
                FillCustomerDetails();
                //Customer loan
                FillCustomerLoanDetails();
               
                dgvCustomerloanEMI_CellFormatting();//Design
            }
            else
            {
                MessageBox.Show("Invalid Selection", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbCustomerName.Focus();
            }

            //After Refresh Select Previous Index
            try {dgvCustomerloanDetails.Rows[selectedRowIndex].Selected = true; } catch (Exception ex) { ex.ToWriteLog(Environment.StackTrace, "N/A"); };
        }
        private void cmbCustomerName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbCustomerName.SelectedIndex >= 0)
            {
                //Customer Id
                _CustomerId = ((KeyValuePair<string, string>)cmbCustomerName.SelectedItem).Key;
            }
        }
        private void dgvCustomerloanDetails_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dgvCustomerloanDetails.SelectedRows.Count > 0)
            {
                Guid _loanId = dgvCustomerloanDetails.SelectedRows[0].Cells["LoanId"].Value.ConvertToGuid();
                FillCustomerLoanEmi(_loanId);
            }
        }
       
        private void dgvCustomerloanEMI_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == dgvCustomerloanEMI.NewRowIndex || e.RowIndex < 0)
                return;

            //Handle ========Repayment Button Column Click=================
            #region ===================Repayment===================
            if (e.ColumnIndex == dgvCustomerloanEMI.Columns["btnCol"].Index)
            {
                if (dgvCustomerloanEMI.Rows[e.RowIndex].Cells["IsPaid"].Value.ConvertObjectToBool())
                {
                    //MessageBox.Show("---Already Paid---");
                }
                else
                {
                    if (dgvCustomerloanEMI.Rows[e.RowIndex].ReadOnly == false)
                    {
                        CustomerLoanRePayment childForm = new CustomerLoanRePayment();
                        childForm.WindowState = FormWindowState.Normal;
                        childForm.onClose += ChildForm_onClose;
                        childForm.ShowDialog();
                    }
                }
            }
            #endregion

            //Handle ========Delete Button Column Click=================
            #region ===================Delete===================
            if (e.ColumnIndex == dgvCustomerloanEMI.Columns["btnCol2"].Index)
            {
                if (dgvCustomerloanEMI.Rows[e.RowIndex].Cells["IsPaid"].Value.ConvertObjectToBool())
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
        #endregion
    }
}
