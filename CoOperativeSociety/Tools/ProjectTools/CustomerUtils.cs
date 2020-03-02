using BusinessEntities;
using SocietyBusinessAccess.Customer;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoOperativeSociety.Tools
{
    public static class CustomerUtils
    {
        private static CustomerDetailsBA customerDetailsBA = new CustomerDetailsBA();
        public static void AddCustomerName(this ComboBox cmb)
        {
            List<CustomerList> lst = customerDetailsBA.GetCustomerList();
            cmb.Items.Clear();
            if (lst.IsValidList())
            {
                foreach (CustomerList item in lst)
                {
                    cmb.Items.Add(new KeyValuePair<string, string>(item.CustomerId.ToString(), item.Customername));
                }
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";
            }
        }
    }
}
