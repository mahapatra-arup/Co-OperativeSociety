using SocietyBusinessAccess.Ledgers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace CoOperativeSociety
{
   public static class SubAccountUtils
    {
        private static SubAccountBA _ledgerSubAccount = new SubAccountBA();
        /// <summary>
        /// Get And ADD all Sub [Ac Name]
        /// </summary>
        /// <param name="cmb"></param>
        public static void AddSubAccountName(this ComboBox cmb)
        {
            List<LedgerSubAccount> lstLedgerSubAccount = _ledgerSubAccount.GetSubAccount();
            cmb.Items.Clear();
            if (lstLedgerSubAccount.IsValidList())
            {
                foreach (LedgerSubAccount item in lstLedgerSubAccount)
                {
                    cmb.Items.Add(new KeyValuePair<int, string>(item.ID, item.AccountName));
                }
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";
            }
        }
    }
}
