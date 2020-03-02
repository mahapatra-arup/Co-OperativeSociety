using BusinessEntities;
using SocietyBusinessAccess.Loans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoOperativeSociety.Tools
{
  public static  class SocityLoanUtils
    {
        private static SocietyLoansBA societyLoansBA = new SocietyLoansBA();
        /// <summary>
        /// Add All LoanSerialNo  
        /// </summary>
        /// <param name="cmb"></param>
        public static void AddLoanSerialNo(this ComboBox cmb)
        {
            List<SocietyLoanDetail> lst = societyLoansBA.GetSocityLoanDetails();
            cmb.Items.Clear();
            if (lst.IsValidList())
            {
                foreach (SocietyLoanDetail item in lst)
                {
                    cmb.Items.Add(new KeyValuePair<long, string>(item.id, item.SocietyLoanSlNo));
                }
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";
            }
        }
      
        /// <summary>
        /// Get Loan Details Use By Loan Bank Id(_LedgerTo)
        /// </summary>
        /// <param name="cmb"></param>
        public static void AddLoanSerialNo(this ComboBox cmb,Guid _LoanBankLedger)
        {
            List<SocietyLoanDetail> lst = societyLoansBA.GetSocityLoanDetails(_LoanBankLedger);
            cmb.Items.Clear();
            if (lst.IsValidList())
            {
                foreach (SocietyLoanDetail item in lst)
                {
                    cmb.Items.Add(new KeyValuePair<long, string>(item.id, item.SocietyLoanSlNo));
                }
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";
            }
        }
    }
}
