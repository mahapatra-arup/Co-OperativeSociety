using BusinessEntities;
using SocietyBusinessAccess.Loans;
using System.Collections.Generic;

using System.Windows.Forms;

namespace CoOperativeSociety.Tools
{
    public static class LoanTypesUtils
    {
      private static  LoanTypeBA loanTypeBA = new LoanTypeBA();
        public static void AddLoanType(this ComboBox cmb)
        {
            List<LoanType> lst = loanTypeBA.GetLoanTypes();
            cmb.Items.Clear();
            if (lst.IsValidList())
            {
                foreach (LoanType item in lst)
                {
                    cmb.Items.Add(new KeyValuePair<int, string>((int)item.Id, item.LoanTypeName));
                }
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";
            }
        }

        public static void AddLoanSubType(this ComboBox cmb,int LoanTypeId)
        {
            List<LoanSubType> lst = loanTypeBA.GetLoanSubTypes(LoanTypeId);
            cmb.Items.Clear();
            if (lst.IsValidList())
            {
                foreach (LoanSubType item in lst)
                {
                    cmb.Items.Add(new KeyValuePair<int, string>((int)item.Id, item.SubTypeName));
                }
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";
            }
        }
    }
}
