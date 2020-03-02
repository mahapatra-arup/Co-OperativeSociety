using BusinessEntities;
using SocietyBusinessAccess.Others;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoOperativeSociety.Tools
{
    public static class DistAndStateUtils
    {
        private static StateAndDistBA frmDistAndState = new StateAndDistBA();
        public static void AddDist(this ComboBox cmb)
        {
            List<District> lstDist = frmDistAndState.GetDistricts();
            cmb.Items.Clear();
            if (lstDist.ISValidObject())
            {
                foreach (District item in lstDist)
                {
                   cmb.Items.Add(new KeyValuePair<int, string>(item.Id, item.DistName));
                }
                cmb.DisplayMember = "Value";
                cmb.ValueMember = "Key";
            }
        }

    }
}
