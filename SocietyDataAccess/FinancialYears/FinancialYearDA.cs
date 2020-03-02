using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace SocietyDataAccess
{
    public class FinancialYearDA
    {
        /// <summary>
        /// Insert FinancialYearlike  FinancialYearName, StartingDate, EndingDate, IsCurentyear
        /// </summary>
        /// <param name="FinancialYearName"></param>
        /// <param name="StartingDate"></param>
        /// <param name="EndingDate"></param>
        /// <param name="IsCurentyear"></param>
        /// <param name="ParamList"></param>
        /// <returns></returns>
        public bool InsertFinancialYear(FinancialYear fn)
        {
            List<SqlParameter> ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  FinancialYear(FinancialYearName, StartingDate, EndingDate, IsCurentyear) " +
            "VALUES(@FinancialYearName, @StartingDate, @EndingDate, @IsCurentyear)";

            #region --------------Parameters-----------
            ParamList.Add(new SqlParameter("@FinancialYearName", fn.FinancialYearName));
            ParamList.Add(new SqlParameter("@StartingDate", fn.StartingDate));
            ParamList.Add(new SqlParameter("@EndingDate", fn.EndingDate));
            ParamList.Add(new SqlParameter("@IsCurentyear", fn.IsCurentyear));
            #endregion

            //Source  SqlParameter 
            SqlHelper.MParameterList = ParamList;

            //Execute Query
            if (SqlHelper.GetInstance().ExcuteQuery(query))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Only Update StartingDate, EndingDate, IsCurentyear
        /// </summary>
        /// <param name="FinancialYearName"></param>
        /// <param name="StartingDate"></param>
        /// <param name="EndingDate"></param>
        /// <param name="IsCurentyear"></param>
        /// <param name="ParamList"></param>
        /// <returns></returns>
        public bool UpdateFinancialYear(FinancialYear fn)
        {
            List<SqlParameter> ParamList = new List<SqlParameter>();

            string query = "update FinancialYear set  FinancialYearName=@FinancialYearName,StartingDate=@StartingDate, EndingDate=@EndingDate, IsCurentyear=@IsCurentyear where ID=@ID";

            #region --------------Parameters-----------
            ParamList.Add(new SqlParameter("@FinancialYearName", fn.FinancialYearName));
            ParamList.Add(new SqlParameter("@StartingDate", fn.StartingDate));
            ParamList.Add(new SqlParameter("@EndingDate", fn.EndingDate));
            ParamList.Add(new SqlParameter("@IsCurentyear", fn.IsCurentyear));
            ParamList.Add(new SqlParameter("@ID", fn.ID));
            #endregion

            //Source  SqlParameter 
            SqlHelper.MParameterList = ParamList;

            //Execute Query
            if (SqlHelper.GetInstance().ExcuteQuery(query))
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Only Update IsCurentyear 
        /// </summary>
        /// <param name="FinancialYearName"></param>
        /// <param name="StartingDate"></param>
        /// <param name="EndingDate"></param>
        /// <param name="IsCurentyear"></param>
        /// <param name="ParamList"></param>
        /// <returns></returns>
        public bool UpdateFinancialCurrentYear(object ID, bool IsCurentyear)
        {
            List<SqlParameter> ParamList = new List<SqlParameter>();

            string query = "update FinancialYear set  IsCurentyear=@IsCurentyear where ID=@ID";

            #region --------------Parameters-----------
            ParamList.Add(new SqlParameter("@ID", ID));
            ParamList.Add(new SqlParameter("@IsCurentyear", IsCurentyear));
            #endregion

            //Source  SqlParameter
            SqlHelper.MParameterList = ParamList;

            //Execute Query
            if (SqlHelper.GetInstance().ExcuteQuery(query))
            {
                return true;
            }
            return false;
        }

        public List<FinancialYear> GetFinancialYearDetails()
        {
            List<FinancialYear> lstfinancialYear = new List<FinancialYear>();
            string query = "Select * from  FinancialYear";

            //Execute Query
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lstfinancialYear.Add(new FinancialYear
                    {
                        ID=Convert.ToInt32(item["ID"]),
                        FinancialYearName= Convert.ToString(item["FinancialYearName"]),
                        StartingDate= Convert.ToDateTime(item["StartingDate"]),
                        EndingDate= Convert.ToDateTime(item["EndingDate"]),
                        IsCurentyear= Convert.ToBoolean(item["IsCurentyear"])
                    });
                }  
            }
            return lstfinancialYear;
        }

    }
}
