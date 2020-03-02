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
using System.Windows.Forms;

namespace CoOperativeSociety
{
    public partial class HomeWindows : Form
    {
        public HomeWindows()
        {
            InitializeComponent();

            //Call Defult Class
            DefultClass lDefultClass=new DefultClass();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnAddSocity_Click(object sender, EventArgs e)
        {
            //SocityDetailsEntry childForm = new SocityDetailsEntry();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.Show();
        }
        private void logDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LogDisplay childForm = new LogDisplay();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Maximized;
            //childForm.Show();
        }
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddCustomer childForm = new AddCustomer();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //childForm.Show();
        }
        private void customerViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CustomerWindow childForm = new CustomerWindow();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Maximized;
            //childForm.Show();
        }
        private void financialYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FinancialYearWindow childForm = new FinancialYearWindow();
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.ShowDialog();
        }
        private void loanCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LoanCalculator childForm = new LoanCalculator();
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.ShowDialog();
        }
        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //SocietyLoanEntry childForm = new SocietyLoanEntry();
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.ShowDialog();
        }
        private void newToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
        //    CustomerLoanEntry childForm = new CustomerLoanEntry();
        //    childForm.WindowState = FormWindowState.Normal;
        //    childForm.ShowDialog();
        }
        private void ledgerEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LedgerEntry childForm = new LedgerEntry();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.Show();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAbout childForm = new frmAbout();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.Show();
        }
        private void emiPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CustomerLoanRePayment childForm = new CustomerLoanRePayment();
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.ShowDialog();
        }
        private void customerEmiViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CustomerEMIView childForm = new CustomerEMIView();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Maximized;
            //childForm.Show();
        }
        private void addBankLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BankLedgeEntry childForm = new BankLedgeEntry();
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.ShowDialog();
        }
        private void shareDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShareDepositListView childForm = new ShareDepositListView();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Maximized;
            //childForm.Show();
        }
        private void newToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //IncomeEntry childForm = new IncomeEntry();
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.ShowDialog();
        }
        private void newToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //ExpenseEntry childForm = new ExpenseEntry();
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.ShowDialog();
        }
        private void loanStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CustomerLoanStatement childForm = new CustomerLoanStatement();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Maximized;
            //childForm.Show();
        }
        private void eMIPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //SocityLoanRePayment childForm = new SocityLoanRePayment();
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.ShowDialog();
        }
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //IncomeExpenceListView childForm = new IncomeExpenceListView();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Maximized;
            //childForm.Show();
        }
        private void ledgerHeadViewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //LedgerHeadDetails childForm = new LedgerHeadDetails();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Maximized;
            //childForm.Show();
        }

        private void eMIViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SocityLoanEMIView childForm = new SocityLoanEMIView();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Maximized;
            //childForm.Show();
        }

        private void loanStatementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //SocityLoanStatement childForm = new SocityLoanStatement();
            //childForm.MdiParent = this;
            //childForm.WindowState = FormWindowState.Maximized;
            //childForm.Show();
        }

        private void decimalPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DecimalPointSetting childForm = new DecimalPointSetting();
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //childForm.ShowDialog();
        }

        private void loanTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LoanTypes childForm = new LoanTypes();
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //childForm.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //HomeWindows frm = new HomeWindows();
            //frm.Refresh();
        }

        private void homeClearToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
           // HomeWindows.ActiveForm.Close();
        }

        private void closeFormToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //foreach (Form childForm in MdiChildren)
            //{
            //    childForm.Close();
            //}
        }
    }
}
