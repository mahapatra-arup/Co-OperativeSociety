using BusinessEntities;
using CoOperativeSociety.Tools;
using SocietyBusinessAccess.Loans;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace CoOperativeSociety.Others
{
    public partial class LoanTypes : Form
    {
        LoanTypeBA loanTypeBA = new LoanTypeBA();
        public LoanTypes()
        {
            InitializeComponent();
            //===Loan Type===
            FillLoanTypeDetails();

            //========Loan Sub Type=========
            cmbLoanType.AddLoanType();
        }

        #region =====================loan Type==================

        private void SaveLoanType()
        {

            if (!txtLoanTypeName.Text.ISNullOrWhiteSpace())
            {
                if (!loanTypeBA.IsLoanTypesExist(txtLoanTypeName.Text))
                {
                    LoanType loanTypes = new LoanType { LoanTypeName = txtLoanTypeName.Text.ToUpper() };
                    if (loanTypeBA.InsertLoanType(loanTypes))
                    {
                        MessageBox.Show("Save SuccessFull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLoanTypeName.Clear();
                        FillLoanTypeDetails();
                    }

                }
                else
                {
                    MessageBox.Show("Loan Type Already Exist", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtLoanTypeName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Loan Type is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLoanTypeName.Focus();
            }
        }
        private void FillLoanTypeDetails()
        {
            //Get
            IEnumerable<LoanType> list = loanTypeBA.GetLoanTypes();

            //Fill
            if (list != null)
            {

                var bindingList = new BindingList<LoanType>(list.ToList());
                var source = new BindingSource(bindingList, null);
                dgvLoanType.DataSource = source;

                //Design
                dgvLoanType.Columns["LoanSubTypes"].Visible = false;
                dgvLoanType.Columns["Id"].Visible = false;
                dgvLoanType.Columns["LoanTypeName"].HeaderText = "Type Name";
            }
        }

        private void lnkSubTypeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbControl.SelectedIndex = 1;
            //For Loan SubType Combobox
            cmbLoanType.Text = dgvLoanType.SelectedRows[0].Cells["LoanTypeName"].Value.ConvertObjectToString();
        }
        private void btnADddLoanType_Click(object sender, System.EventArgs e)
        {
            SaveLoanType();
        }
        #endregion

        #region =====================Loan Sub Type==============
        #region ===Method==
        private LoanSubType GetFormValue()
        {
            //Type Id
            int _LoanTypeId = ((KeyValuePair<int, string>)cmbLoanType.SelectedItem).Key;

            LoanSubType loanTypes = new LoanSubType
            {
                SubTypeName = txtLoanSubType.Text,
                LoanTypeId = _LoanTypeId,
                MaxLoanAmount = txtloanMaxRs.Text.ConvertObjectToDouble(),
                MinLoanAmount = txtLoanMinRs.ConvertObjectToDouble(),
                EMIPeriodFormate = cmbPeriodFormate.Text,
                EMIPeriod = nudEmiPeriod.Value.ConvertObjectToInt(),
                IsCompoundInterest = false
            };
            
            return loanTypes;
        }
        private void SaveLoanSubType()
        {
            if (IsValidLoanSubTypeField())
            {
                //Execute
                if (loanTypeBA.InsertLoanSubType(GetFormValue()))
                {
                    MessageBox.Show("Save SuccessFull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillLoanSubTypeDetails();
                    ClearSubLoanTypeDetails();
                }

            }
        }
        private void FillLoanSubTypeDetails()
        {
            //Type Id
            int LoanTypeId = ((KeyValuePair<int, string>)cmbLoanType.SelectedItem).Key;
            //Get
            List<LoanSubType> list = loanTypeBA.GetLoanSubTypes(LoanTypeId);

            //Fill
            if (list != null)
            {
                //Source
                var bindingList = new BindingList<LoanSubType>(list);
                var source = new BindingSource(bindingList, null);
                dgvLoanSubTypeView.DataSource = source;

                #region ===============Design==================
                //Heser Cell text

                dgvLoanSubTypeView.Columns["SubTypeName"].HeaderText = "Type Name";
                dgvLoanSubTypeView.Columns["MinLoanAmount"].HeaderText = "Min Loan Amount";
                dgvLoanSubTypeView.Columns["MaxLoanAmount"].HeaderText = "Max Loan Amount";
                dgvLoanSubTypeView.Columns["EMIPeriodFormate"].HeaderText = "Formate";
                dgvLoanSubTypeView.Columns["EMIPeriod"].HeaderText = "Period";
                dgvLoanSubTypeView.Columns["IsCompoundInterest"].HeaderText = "IsCompoundInterest";

                //Design
                dgvLoanSubTypeView.Columns["LoanTypeId"].Visible = false;
                dgvLoanSubTypeView.Columns["Id"].Visible = false;
                #endregion
            }
        }
        private void ClearSubLoanTypeDetails()
        {
            txtLoanSubType.Text = "";
           txtloanMaxRs.Text = "0";
            txtLoanMinRs.Text = "0";
            cmbPeriodFormate.Text = "";
        }
        private bool IsValidLoanSubTypeField()
        {
            if (!cmbLoanType.Text.ISNullOrWhiteSpace())
            {
                if (!txtLoanSubType.Text.ISNullOrWhiteSpace())
                {
                    if (!txtloanMaxRs.Text.ISNullOrWhiteSpace())
                    {
                        if (!txtLoanMinRs.Text.ISNullOrWhiteSpace())
                        {
                            if (!cmbPeriodFormate.Text.ISNullOrWhiteSpace())
                            {

                                if (!loanTypeBA.IsLoanSubTypesExist(txtLoanSubType.Text))
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Loan SubType Already Exist", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Period Form is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                cmbPeriodFormate.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Min Amount is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            txtLoanMinRs.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Max Amount is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtloanMaxRs.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Sub Type is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtLoanSubType.Focus();
                }

            }
            else
            {
                MessageBox.Show("Loan Type is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbLoanType.Focus();
            }
            return false;
        } 
        #endregion

        #region ==Event==
        private void cmbLoanType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            FillLoanSubTypeDetails();
        }
        private void lbllnkBackToType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbControl.SelectedIndex = 0;
        }
        private void btnLoanSubtypeAdd_Click(object sender, System.EventArgs e)
        {
            SaveLoanSubType();
        }
       

        private void txtloanMaxRs_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.FlotingNumberValidation(sender, e);
        }
        #endregion

        #endregion

       
    }
}
