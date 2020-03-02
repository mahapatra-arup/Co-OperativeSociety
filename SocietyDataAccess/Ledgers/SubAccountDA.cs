using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyDataAccess.Ledgers
{
    public class SubAccountDA
    {
        public List<LedgerSubAccount> GetSubAccount()
        {
            List<LedgerSubAccount> lstSubAc = new List<LedgerSubAccount>();
            string query = "Select * from LedgerSubAccount order by AccountName";
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lstSubAc.Add(new LedgerSubAccount
                    {
                        ID = item["ID"].ConvertObjectToInt(),
                        AccountName = item["AccountName"].ConvertObjectToString(),
                        ParentAccount = item["ParentAccount"].ConvertObjectToString(),
                        Nature = item["Nature"].ConvertObjectToString(),
                        IsFixed = item["IsFixed"].ConvertObjectToBool()
                    });
                }
            }
            return lstSubAc;
        }
    }
}
