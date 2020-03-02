using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;


namespace SocietyDataAccess.Others
{
   public class BankDetailsDA
    {
        public List<Bank> GetBanksName()
        {
            List<Bank> lstBank = new List<Bank>();
            string query = "Select * from Bank";
            DataTable dtData = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dtData.IsValidDataTable())
            {
                foreach (DataRow item in dtData.Rows)
                {
                    int id = Convert.ToInt32(item["Id"]);
                    lstBank.Add(new Bank
                    {
                        ID = id,
                        BankName = Convert.ToString(item["BankName"]),
                        Code = Convert.ToString(item["Code"])
                    });
                }
            }
            return lstBank;
        }
    }
}
