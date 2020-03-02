using BusinessEntities;
using SocietyBusinessAccess.FinancialYears;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CoOperativeSociety.FinancialYears
{
    public partial class FinancialYearWindow : Form
    {
        FinancialYearsBA financialYearsBA = new FinancialYearsBA();
        private bool IsSuccess = false;
        private int _SelectedFinYearId = 0;
        private string _SelectedFinYear = "";
        public FinancialYearWindow()
        {
            InitializeComponent();
            FillGried();
        }

        #region -----------------Method------------
        private void Insert()
        {
            if (IsValidField())
            {
                    IEnumerable<FinancialYear> lstyear = financialYearsBA.GetFinancialYearDetails(txtFinancialYear.Text.Trim());
                    string yearname = lstyear.ISValidIEnumerableList() ? lstyear.FirstOrDefault().FinancialYearName : "";
                    if (yearname.ISNullOrWhiteSpace())
                    {
                        IsSuccess= financialYearsBA.InsertFinancialYear(GetFormFieldData());
                    }
                    else
                    {
                        MessageBox.Show("Already Exist", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        txtFinancialYear.Select();
                    }

                if (IsSuccess)
                {
                    MessageBox.Show("Save SuccessFull", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    txtFinancialYear.Select();
                    FillGried();//relod Gried
                }
            }
        }
        private FinancialYear GetFormFieldData()
        {
            FinancialYear financialYear = new FinancialYear();
            financialYear.FinancialYearName = txtFinancialYear.Text.Trim();
            financialYear.IsCurentyear = chkIscurrentYear.Checked;
            financialYear.StartingDate = dtpStartDate.Value;
            financialYear.EndingDate = dtpEndDate.Value;
           
            return financialYear;
        }

        private void FillFormField(int id)
        {
            IEnumerable<FinancialYear> lstyear = financialYearsBA.GetFinancialYearDetails(id);
            if (lstyear.ISValidIEnumerableList())
            {
                txtFinancialYear.Text = lstyear.FirstOrDefault().FinancialYearName;
                chkIscurrentYear.Checked = lstyear.FirstOrDefault().IsCurentyear;
                dtpStartDate.Value = lstyear.FirstOrDefault().StartingDate;
                dtpEndDate.Value = lstyear.FirstOrDefault().EndingDate; 
            }
        }
        private void Clear()
        {
            txtFinancialYear.Text = string.Empty;
            chkIscurrentYear.Checked = false;
            //dtpStartDate.Text = string.Empty;
            //dtpEndDate.Text = string.Empty;
            _SelectedFinYearId = 0;
        }

        private void FillGried()
        {
            if (dgvLoanTypes.Rows.Count > 0)
            {
                dgvLoanTypes.Rows.Clear();
            }
            List<FinancialYear> lstFinancialYear = financialYearsBA.GetFinancialYearDetails();
            if (lstFinancialYear.IsValidList())
            {
                foreach (FinancialYear itemFinancialYear in lstFinancialYear)
                {
                    dgvLoanTypes.Rows.Add(itemFinancialYear.ID, itemFinancialYear.FinancialYearName, "Edit");
                }
            }
        }

        private bool IsValidField()
        {
            if (!txtFinancialYear.Text.ISNullOrWhiteSpace())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Year is required", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFinancialYear.Select();
            }
            return false;
        }

        private void UpdateData()
        {
            if (IsValidField())
            {
                if (_SelectedFinYearId > 0)
                {
                    string currentFinYear = txtFinancialYear.Text.Trim();

                    //Present or not check
                    IEnumerable<FinancialYear> lstyear = financialYearsBA.GetFinancialYearDetails(currentFinYear);
                    string yearname = lstyear.ISValidIEnumerableList() ? lstyear.FirstOrDefault().FinancialYearName : "";

                    //===Set Id====
                    FinancialYear fn = GetFormFieldData();
                    fn.ID = _SelectedFinYearId;


                    if (_SelectedFinYear == currentFinYear)
                    {
                        IsSuccess = financialYearsBA.UpdateFinancialYear(fn);
                    }
                    else if (yearname.ISNullOrWhiteSpace())
                    {
                        IsSuccess = financialYearsBA.UpdateFinancialYear(fn);
                    }
                    else
                    {
                        MessageBox.Show("Already Exist Session : " + currentFinYear, "invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }

                if (IsSuccess)
                {
                    MessageBox.Show("Update SuccessFull", "Save As", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    txtFinancialYear.Select();
                    FillGried();//relod Gried
                }
            }
        }
        #endregion

        #region --------------------Event-----------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dgvLoanTypes_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                dgvLoanTypes.CurrentCell = dgvLoanTypes.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
            catch (Exception)
            {
            }
        }
        #endregion

        private void dgvLoanTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex>=0&& dgvLoanTypes.Columns[e.ColumnIndex].Name== "Edit")
                {
                _SelectedFinYearId = Convert.ToInt32(dgvLoanTypes.Rows[dgvLoanTypes.CurrentCell.RowIndex].Cells["ID"].Value);
                 _SelectedFinYear = Convert.ToString(dgvLoanTypes.Rows[dgvLoanTypes.CurrentCell.RowIndex].Cells["YearName"].Value);

                FillFormField(this._SelectedFinYearId); 
                }
        }

        private void txtFinancialYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one [-]
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
