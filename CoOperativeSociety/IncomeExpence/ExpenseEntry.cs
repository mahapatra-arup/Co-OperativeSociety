using BusinessEntities;
using BusinessEntities._enum;
using CoOperativeSociety.Tools;
using SocietyBusinessAccess.Transections;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoOperativeSociety.IncomeExpence
{
    public partial class ExpenseEntry : Form
    {
        TransectionBA transectionBA = new TransectionBA();
        public ExpenseEntry()
        {
            InitializeComponent();

            //Expence ledger
            cmbLedgerHead.AddLedger(LedgerEnum._LedgerAttributes.Type, LedgerEnum._LedgerTypeValues.Expense);

            //Set Reference No
            txtTransectionRefNo.Text = transectionBA.GenerateTransectionsRefNo();

            //Set slNo
            txtNo.Text = transectionBA.GenerateExpenseNoOfTransection().ConvertObjectToString();
        }

        #region =================Method=====================
        private void FillFromValues(out List<Transection> lstTransection)
        {
            lstTransection = new List<Transection>();
            //From
            Guid acHeadLedger = ((KeyValuePair<Guid, string>)cmbLedgerHead.SelectedItem).Key;
            //To
            Guid paidFromLedger = ((KeyValuePair<Guid, string>)cmbPaidFrom.SelectedItem).Key;

            #region @@@@@@@@@@@@First Transection <>@@@@@@@@@@@@@@@@@@
            //Transection  DR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = dtpTransectionDate.Value,
                No = txtNo.Text,
                TransectionType = TransectionEnum._TransectionTypeValues.Expense.GetEnumName(),

                //Ledger
                LedgerIdTo = paidFromLedger,
                LedgerIdFrom = acHeadLedger,

                //Amount
                Amount_Dr = txtAmount.Text.ConvertObjectToDouble(),
                Narration = txtRemarks.Text,
                Transection_Ref_No = txtTransectionRefNo.Text,


                //=====check Details=====
                Mode = cmbPaymentMethod.Text,
                BankName = cmbBank.Text,
                ChequeNo = txtChequeNo.Text,
                ChequeDate = cmbPaymentMethod.Text.ToUpper() == "CASH" ? null : (DateTime?)dtpChequeIssue.Value,

                Status = null,
            });

            //Transection CR
            lstTransection.Add(new Transection
            {
                TransectionID = Guid.NewGuid(),
                Date = dtpTransectionDate.Value,
                No = txtNo.Text,
                TransectionType = TransectionEnum._TransectionTypeValues.Expense.GetEnumName(),

                //Ledger
                LedgerIdTo = acHeadLedger,
                LedgerIdFrom = paidFromLedger,

                //Amount
                Amount_Cr = txtAmount.Text.ConvertObjectToDouble(),
                Narration = txtRemarks.Text,
                Transection_Ref_No = txtTransectionRefNo.Text,


                //=====check Details=====
                Mode = cmbPaymentMethod.Text,
                BankName = cmbBank.Text,
                ChequeNo = txtChequeNo.Text,
                ChequeDate = cmbPaymentMethod.Text.ToUpper()=="CASH"?null:(DateTime?)dtpChequeIssue.Value,

                Status = null,
            });
            #endregion

        }
        private void Save()
        {
            var lstTransection = new List<Transection>();
            FillFromValues(out lstTransection);

            if (lstTransection.IsValidList())
            {
                if (!transectionBA.IsExistTransection_Ref_No(txtTransectionRefNo.Text))
                {
                    if (transectionBA.InsertDataOfTransection(lstTransection))
                    {
                        MessageBox.Show("Transection Successfull", "Expense", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                    }
                }
                else
                {
                    MessageBox.Show("Transection Ref No Already Exist", "Exist", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
            else
            {
                MessageBox.Show("Something Wrong. Transection Details Not Valid", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        private void CashBankControl()
        {
            #region ==========SocietyBank==============
            List<LedgerEnum._LedgerCategoryValues> lstSocityBankAttribute = new List<LedgerEnum._LedgerCategoryValues>();
            lstSocityBankAttribute.Add(LedgerEnum._LedgerCategoryValues.Society_Saving_AC);
            lstSocityBankAttribute.Add(LedgerEnum._LedgerCategoryValues.Society_Current_AC);
            #endregion

            pnlChequeDetails.Enabled = true;
            switch (cmbPaymentMethod.Text.ToUpper())
            {

                case "CASH":
                    pnlChequeDetails.Enabled = false;
                    cmbPaidFrom.AddLedger(LedgerEnum._LedgerAttributes.Category, LedgerEnum._LedgerCategoryValues.Cash);
                    break;
                case "CHEQUE":
                case "RTGS":
                case "NEFT":
                case "IMPS":
                case "UPI":
                    cmbPaidFrom.AddLedger(LedgerEnum._LedgerAttributes.Category, lstSocityBankAttribute);
                    cmbBank.AddBanksName();
                    break;
            }
            //Change Header label
            lblcheckNoString.Text = cmbPaymentMethod.Text + " No";
        }
        private bool IsValid()
        {
            if (cmbLedgerHead.Text.ISNullOrWhiteSpace())
            {
                MessageBox.Show("Invalid Selection of account head", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbLedgerHead.Select();
                return false;
            }

            if (txtAmount.Text.ConvertObjectToDouble() <= 0)
            {
                MessageBox.Show("Amount is Required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Select();
                return false;
            }

            if (cmbPaymentMethod.Text.ISNullOrWhiteSpace())
            {
                MessageBox.Show("payment method is Required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPaymentMethod.Focus();
                return false;
            }

            if (cmbPaidFrom.Text.ISNullOrWhiteSpace())
            {
                MessageBox.Show("Paid Account is Required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbPaymentMethod.Focus();
                return false;
            }


            if (cmbPaymentMethod.Text.ToUpper()!="CASH")
            {
                if (cmbBank.Text.ISNullOrWhiteSpace())
                {
                    MessageBox.Show("Select valid bank name.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    cmbBank.Select();
                    return false;
                }
                if (txtChequeNo.Text.ISNullOrWhiteSpace() || txtChequeNo.Text.Length < 6)
                {
                    MessageBox.Show("Cheque No. is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtChequeNo.Select();
                    return false;
                }

            }
            return true;
        }
        private void ClearData()
        {
            cmbBank.Text = "";
            txtAmount.Text = "0.00";
            cmbPaymentMethod.SelectedIndex = -1;
            cmbPaidFrom.SelectedIndex = -1;
            cmbBank.SelectedIndex = -1;
            txtChequeNo.Text = "";
            txtRemarks.Text = "";

            //Set Reference No
            txtTransectionRefNo.Text = transectionBA.GenerateTransectionsRefNo();

            //Set slNo
            txtNo.Text = transectionBA.GenerateExpenseNoOfTransection().ConvertObjectToString();
        }
        #endregion

        #region ===================Event====================
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Save();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            CashBankControl();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationUtils.FlotingNumberValidation(sender, e);
        }
        #endregion

        private void txtTransectionRefNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
