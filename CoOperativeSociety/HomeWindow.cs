using CoOperativeSociety._Transection;
using CoOperativeSociety.Customer;
using CoOperativeSociety.Customer.Loans.LoanRePayment;
using CoOperativeSociety.Customer.ViewList;
using CoOperativeSociety.FinancialYears;
using CoOperativeSociety.Help;
using CoOperativeSociety.IncomeExpence;
using CoOperativeSociety.Ledgers;
using CoOperativeSociety.Loans;
using CoOperativeSociety.Others;
using CoOperativeSociety.Setting;
using CoOperativeSociety.Society;
using CoOperativeSociety.Society.ListView;
using CoOperativeSociety.Society.Loans;
using CoOperativeSociety.Tools.Loger;
using CoOperativeSociety.Tools.ProjectTools;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoOperativeSociety
{
    public partial class HomeWindow : Form
    {
        public HomeWindow()
        {
            InitializeComponent();
            //Call Defult Class
            DefultClass lDefultClass = new DefultClass();
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {

        }
        private void HomeWindow_Shown(object sender, EventArgs e)
        {
            //dEFULT PAGE sHOW
            DefultPage childForm = new DefultPage();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }
        private void rbnAbout_Click(object sender, EventArgs e)
        {
            frmAbout childForm = new frmAbout();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Normal;
            childForm.Show();
        }


        #region =================HOME CONTEXT MENU STRIP===================
        private void refreshToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            HomeWindow frm = new HomeWindow();
            frm.Refresh();
        }

        private void homeClearToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                    childForm.Close(); 
            }
        }

        private void StatusBer_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = StatusBer.Checked;
        }

        private void toolBerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMenuBar.Visible = toolBerToolStripMenuItem.Checked;
        }

        private void captionBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ribbon1.CaptionBarVisible = captionBarToolStripMenuItem.Checked;
        }
        #endregion

        #region ============================Tools Section==================
        private void rbnFinancialYear_Click(object sender, EventArgs e)
        {
            FinancialYearWindow childForm = new FinancialYearWindow();
            childForm.WindowState = FormWindowState.Normal;
            childForm.ShowDialog();
        }

        private void rbnAddBankLedger_Click(object sender, EventArgs e)
        {
            BankLedgeEntry childForm = new BankLedgeEntry();
            childForm.WindowState = FormWindowState.Normal;
            childForm.ShowDialog();
        }

        private void rbnLoanTypes_Click(object sender, EventArgs e)
        {
            LoanTypes childForm = new LoanTypes();
            childForm.WindowState = FormWindowState.Normal;
            childForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            childForm.ShowDialog();
        }

        private void rbnLedgerEntry_Click(object sender, EventArgs e)
        {
            LedgerEntry childForm = new LedgerEntry();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Normal;
            childForm.Show();
        }

        private void rbnDecimalPoints_Click(object sender, EventArgs e)
        {
            DecimalPointSetting childForm = new DecimalPointSetting();
            childForm.WindowState = FormWindowState.Normal;
            childForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            childForm.ShowDialog();
        }

        #endregion

        #region =========================Society===========================

        private void rbnNewSocietyLoan_Click(object sender, EventArgs e)
        {
            SocietyLoanEntry childForm = new SocietyLoanEntry();
            childForm.WindowState = FormWindowState.Normal;
            childForm.ShowDialog();
        }

        private void rbnSocietyDetails_Click(object sender, EventArgs e)
        {
            SocityDetailsEntry childForm = new SocityDetailsEntry();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Normal;
            childForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            childForm.Show();
        }

        private void rbnLoanRePayment_Click(object sender, EventArgs e)
        {
            SocityLoanRePayment childForm = new SocityLoanRePayment();
            childForm.WindowState = FormWindowState.Normal;
            childForm.ShowDialog();
        }

        private void rbnEMIView_Click(object sender, EventArgs e)
        {
            SocityLoanEMIView childForm = new SocityLoanEMIView();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void rbnSocietyLoanStatement_Click(object sender, EventArgs e)
        {
            SocityLoanStatement childForm = new SocityLoanStatement();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }
        #endregion

        #region ===========================Customer========================
        private void rbnAssCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer childForm = new AddCustomer();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Normal;
            childForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            childForm.Show();
        }

        private void rbnCustomerNewLoan_Click(object sender, EventArgs e)
        {
            CustomerLoanEntry childForm = new CustomerLoanEntry();
            childForm.WindowState = FormWindowState.Normal;
            childForm.ShowDialog();

        }

        private void rbnCustomerLoanRePayment_Click(object sender, EventArgs e)
        {
            CustomerLoanRePayment childForm = new CustomerLoanRePayment();
            childForm.WindowState = FormWindowState.Normal;
            childForm.ShowDialog();

        }

        private void rbnCustomerEMIView_Click(object sender, EventArgs e)
        {
            CustomerEMIView childForm = new CustomerEMIView();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();

        }

        private void rbnCustomerLoanStatement_Click(object sender, EventArgs e)
        {
            CustomerLoanStatement childForm = new CustomerLoanStatement();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void rbnShareView_Click(object sender, EventArgs e)
        {
            ShareDepositListView childForm = new ShareDepositListView();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }
        #endregion

        #region ===========================Income && Expense===============
        private void rbnNewIncome_Click(object sender, EventArgs e)
        {
            IncomeEntry childForm = new IncomeEntry();
            childForm.WindowState = FormWindowState.Normal;
            childForm.ShowDialog();
        }

        private void rbnExpenseEntry_Click(object sender, EventArgs e)
        {
            ExpenseEntry childForm = new ExpenseEntry();
            childForm.WindowState = FormWindowState.Normal;
            childForm.ShowDialog();
        }

        private void rbnIncomeEcpenseView_Click(object sender, EventArgs e)
        {
            IncomeExpenceListView childForm = new IncomeExpenceListView();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        #endregion

        #region ============================Top============================

        private void rbnLogDisplay_Click(object sender, EventArgs e)
        {
            LogDisplay childForm = new LogDisplay();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void rbnCalculator_Click(object sender, EventArgs e)
        {
            LoanCalculator childForm = new LoanCalculator();
            childForm.WindowState = FormWindowState.Normal;
            childForm.ShowDialog();
        }



        #endregion

        #region =============================Theme Design==================

        private void rbnCmbStyle_TextBoxTextChanged(object sender, EventArgs e)
        {
            cboChooseTheme.Enabled = false;

            if (cboChooseTheme.TextBoxText == "Black")
                Theme.ThemeColor = RibbonTheme.Black;
            else if (cboChooseTheme.TextBoxText == "Green")
                Theme.ThemeColor = RibbonTheme.Green;
            else if (cboChooseTheme.TextBoxText == "Purple")
                Theme.ThemeColor = RibbonTheme.Purple;
            else if (cboChooseTheme.TextBoxText == "JellyBelly")
                Theme.ThemeColor = RibbonTheme.JellyBelly;
            else if (cboChooseTheme.TextBoxText == "Halloween")
                Theme.ThemeColor = RibbonTheme.Halloween;
            else
                Theme.ThemeColor = RibbonTheme.Normal;


            this.Refresh();
            cboChooseTheme.Enabled = true;
        }

        private void cboOfficeStyle_TextBoxTextChanged(object sender, EventArgs e)
        {
            if (cboOfficeStyle.TextBoxText == "Office 2007")
                ribbon1.OrbStyle = RibbonOrbStyle.Office_2007;
            if (cboOfficeStyle.TextBoxText == "Office 2010")
                ribbon1.OrbStyle = RibbonOrbStyle.Office_2010;
            if (cboOfficeStyle.TextBoxText == "Office 2013")
                ribbon1.OrbStyle = RibbonOrbStyle.Office_2013;
        }
        #endregion

        #region ======================Transection==========================
        private void rbnLedgerHeadView_Click(object sender, EventArgs e)
        {
            LedgerHeadDetails childForm = new LedgerHeadDetails();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        } 
        #endregion
    }
}
