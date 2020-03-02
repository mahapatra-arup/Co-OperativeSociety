using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace SocietyDataAccess.Loans
{
    public class LoantypesDA
    {
        #region ==================Loan Type===========
        public bool InsertLoanType(LoanType lty)
        {
            List<SqlParameter> ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  LoanType( LoanTypeName) " +
            "VALUES(@LoanTypeName)";

            ParamList.Add(new SqlParameter("@LoanTypeName", lty.LoanTypeName));

            //Source 
            SqlHelper.MParameterList = ParamList;

            //Execute Query
            if (SqlHelper.GetInstance().ExcuteQuery(query))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Get Loan Types
        /// </summary>
        /// <returns></returns>
        public List<LoanType> GetLoanTypes()
        {
            List<LoanType> lty = new List<LoanType>();

            string query = " select * from LoanType";

            //Execute Query
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lty.Add(
                               new LoanType
                               {
                                   Id = Convert.ToInt32(item["Id"]),
                                   LoanTypeName = Convert.ToString(item["LoanTypeName"]),
                               }
                           );
                }
            }
            return lty;
        }


        #endregion

        #region ================Loan Sub Type=============
        public bool InsertLoanSubType(LoanSubType lty)
        {
            List<SqlParameter> ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  LoanSubType( SubTypeName, LoanTypeId, MaxLoanAmount, MinLoanAmount,IsCompoundInterest, EMIPeriodFormate, EMIPeriod) " +
            "VALUES( @SubTypeName, @LoanTypeId, @MaxLoanAmount, @MinLoanAmount,@IsCompoundInterest, @EMIPeriodFormate, @EMIPeriod)";

            //Parameter
            ParamList.Add(new SqlParameter("@SubTypeName", lty.SubTypeName));
            ParamList.Add(new SqlParameter("@LoanTypeId", lty.LoanTypeId));
            ParamList.Add(new SqlParameter("@MaxLoanAmount", lty.MaxLoanAmount));
            ParamList.Add(new SqlParameter("@MinLoanAmount", lty.MinLoanAmount));
            ParamList.Add(new SqlParameter("@IsCompoundInterest", lty.IsCompoundInterest));
            ParamList.Add(new SqlParameter("@EMIPeriodFormate", lty.EMIPeriodFormate));
            ParamList.Add(new SqlParameter("@EMIPeriod", lty.EMIPeriod));

            //Source 
            SqlHelper.MParameterList = ParamList;

            //Execute Query
            if (SqlHelper.GetInstance().ExcuteQuery(query))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Get LoanSubTypes Use Loan Type
        /// </summary>
        /// <param name="LoanTypeId"></param>
        /// <returns>List<LoanSubType></returns>
        public List<LoanSubType> GetLoanSubTypes()
        {
            List<LoanSubType> lty = new List<LoanSubType>();
            string query = " select * from LoanSubType";
           
            //Execute Query
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lty.Add(
                               new LoanSubType
                               {

                                   Id = Convert.ToInt32(item["Id"]),
                                   LoanTypeId = Convert.ToInt32(item["LoanTypeId"]),
                                   SubTypeName = Convert.ToString(item["SubTypeName"]),
                                   MaxLoanAmount = Convert.ToDouble(item["MaxLoanAmount"]),
                                   MinLoanAmount = Convert.ToDouble(item["MinLoanAmount"]),
                                   IsCompoundInterest = item["IsCompoundInterest"].ISValidObject()?Convert.ToBoolean(item["IsCompoundInterest"]):false,
                                   EMIPeriodFormate = Convert.ToString(item["EMIPeriodFormate"]),

                                   EMIPeriod = Convert.ToInt32(item["EMIPeriod"])

                               }
                           );
                }
            }
            return lty;
        }

        #endregion
    }
}
