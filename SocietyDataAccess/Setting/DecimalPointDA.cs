using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyDataAccess.Setting
{
    public class DecimalPointDA
    {
        /// <summary>
        /// Update Decimal point Number
        /// </summary>
        /// <param name="decimalPointTools"></param>
        /// <returns></returns>
        public bool UpdateOfDecimalPointTools(DecimalPointTool decimalPointTools)
        {
            //query
            string query = "Update DecimalPointTools set DecimalPointNo=@DecimalPointNo";

            #region ------------Sql Parameter--------
            SqlHelper.MParameterList.Add(new SqlParameter("@DecimalPointNo", decimalPointTools.DecimalPointNo));
            #endregion
            //Execution
            if (SqlHelper.GetInstance().ExcuteQuery(query))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get DecimalPointTool Details
        /// </summary>
        /// <returns></returns>
        public DecimalPointTool GetDecimalPointTool()
        {
            DecimalPointTool _DecimalPointTool = new DecimalPointTool();
            //query
            string query = "select * from DecimalPointTools";

            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                _DecimalPointTool.Id = dt.Rows[0]["Id"].ConvertObjectToLong();
                _DecimalPointTool.DecimalPointNo = dt.Rows[0]["DecimalPointNo"].ConvertObjectToInt();
            }
            return _DecimalPointTool;
        }
    }
}
