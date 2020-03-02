using BusinessEntities;
using BusinessEntities._enum;
using SocietyBusinessAccess.Ledgers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CoOperativeSociety
{
   public static class LedgerUtils
    {
        private static LedgerBA ledgerBA = new LedgerBA();
        /// <summary>
        /// Show Ledger 
        /// </summary>
        /// <param name="cmb"></param>
        public static void AddLedger<T>(this ComboBox cmb, LedgerEnum._LedgerAttributes _type, T _AttributeValue)
        {
            List<Ledger> lstLedger = ledgerBA.GetLedger(_type, _AttributeValue);
            cmb.Items.Clear();
            if (lstLedger.ISValidObject())
            {
                foreach (Ledger item in lstLedger)
                {
                    cmb.Items.Add(new KeyValuePair<Guid, string>(item.LedgerId, item.LedgerName));
                }
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";
            }
        }

        public static void AddLedger(this ComboBox cmb, LedgerEnum._LedgerAttributes _type, List<LedgerEnum._LedgerCategoryValues> _lstAttributeValues)
        {
            List<Ledger> lstLedger = ledgerBA.GetLedger(_type, _lstAttributeValues);
            cmb.Items.Clear();
            if (lstLedger.ISValidObject())
            {
                foreach (Ledger item in lstLedger)
                {
                    cmb.Items.Add(new KeyValuePair<Guid, string>(item.LedgerId, item.LedgerName));
                }
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";
            }
        }
        /// <summary>
        ///  show Child Ledger use Parent LedgerId
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="_Parentledgerid"></param>
        /// <param name="_ledgerattrb"></param>
        /// <param name="_lstAttributeValues"></param>
        public static void AddChildLedgers(this ComboBox cmb,Guid _Parentledgerid,
            [Description("Column Name of Ledger table")]
            LedgerEnum._LedgerAttributes _ledgerattrb,
            [Description("Column value")]
            List<LedgerEnum._LedgerCategoryValues> _lstAttributeValues)
        {
            //Get Ledger By Parent
            IEnumerable<Ledger> lstLedger001 = ledgerBA.GetLedgersByParent(_Parentledgerid, _ledgerattrb, _lstAttributeValues);
            //Clear
            cmb.Items.Clear();

            //Logic
            if (lstLedger001.ISValidIEnumerableList())
            {
                //Loop
                foreach (Ledger item in lstLedger001)
                {
                    cmb.Items.Add(new KeyValuePair<Guid, string>(item.LedgerId, item.LedgerName));
                }
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";
            }
        }

       
        public static void AddSocityBankCategory(this ComboBox cmb)
        {
            cmb.Items.Add(LedgerEnum._LedgerCategoryValues.Society_Saving_AC.GetEnumName());
            cmb.Items.Add(LedgerEnum._LedgerCategoryValues.Society_Loan_AC.GetEnumName());
            cmb.Items.Add(LedgerEnum._LedgerCategoryValues.Society_Current_AC.GetEnumName());
        }
    }
}
