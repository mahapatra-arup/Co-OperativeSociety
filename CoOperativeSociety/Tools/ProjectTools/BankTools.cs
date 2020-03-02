using BusinessEntities;
using SocietyBusinessAccess.Others;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CoOperativeSociety.Tools
{
   public static  class BankTools
    {
        private static BankDetailsBA bankDetailsBA = new BankDetailsBA();
        public static void AddBanksName(this ComboBox cmb)
        {
            List<Bank> lstbanknames = bankDetailsBA.GetBanksName();
            cmb.Items.Clear();
            if (lstbanknames.IsValidList())
            {
                foreach (Bank item in lstbanknames)
                {
                    cmb.Items.Add(new KeyValuePair<int, string>(item.ID, item.BankName));
                }
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";
            }
        }
    }
}
