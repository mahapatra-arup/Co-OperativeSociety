using BusinessEntities;
using BusinessEntities.CustomProperties;
using SocietyDataAccess.Transections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SocietyDataAccess.Loans
{
    public class SocietyLoansDA
    {
      
        /// <summary>
        /// Insert Socity Loan Details With EMI and Insert Transection 
        /// </summary>
        /// <param name="frmSLD"></param>
        /// <param name="frmlstSLE"></param>
        /// <param name="frmListTransection"></param>
        /// <returns></returns>
        public bool InsertSocityLoanWithLoanEMI(SocietyLoanDetail frmSLD, List<SocietyLoanEMI> frmlstSLE, List<Transection> frmListTransection)
        {
            #region -----------Variable Section----------
            //Query
            List<string> lst = new List<string>();
            //Parent
            List<List<SqlParameter>> sqlparam = new List<List<SqlParameter>>();
            #endregion

            //==Logic==
            #region ----------SocityLoanDetail-------
            List<SqlParameter> sqlSLD = new List<SqlParameter>();
            string queryCLD = InsertQryOfSocietyLoanDetails(frmSLD, out sqlSLD);

            //Add Details
            sqlparam.Add(sqlSLD);
            lst.Add(queryCLD);
            #endregion


            #region --------------SocityLoanEMI--------------
            foreach (SocietyLoanEMI SLE_Item in frmlstSLE)
            {
                List<SqlParameter> sqlSLE = new List<SqlParameter>();
                string querySLE = InsertQryOfSocietyLoanEMI(SLE_Item, out sqlSLE);

                //Add Details
                sqlparam.Add(sqlSLE);
                lst.Add(querySLE);
            }
            #endregion


            #region --------------Transection--------------
            foreach (Transection item_Transection in frmListTransection)
            {
                List<SqlParameter> sql_Transection = new List<SqlParameter>();
                TransectionDA tfTransectionDA = new TransectionDA();
                string query_Transection = tfTransectionDA.InsertQryOfTransection(item_Transection, out sql_Transection);

                //Add Details
                sqlparam.Add(sql_Transection);
                lst.Add(query_Transection);
            }
            #endregion

            //Execution
            if (SqlHelper.GetInstance().ExecuteTransection(lst, sqlparam))
            {
                return true;
            }
            return false;
        }

        #region ====================Socity Loan Details===================

        private string InsertQryOfSocietyLoanDetails(SocietyLoanDetail frmSLD, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  SocietyLoanDetails(SocietyLoanSlNo, SanctionedAmount, Date, RateOfInterest, EMIPrincipalAmount, EMIInterestAmount, PayableAmount, NoOfEMI, LoanTypeName, LoanSubTypeName, \r\n" +
            "EMIPeriodFormate, EMIPeriod, EMIPaidDay, Remarks,IsCompoundInterest,LedgerFrom,LedgerTo,Transection_Ref_No) " +
            "VALUES( @SocietyLoanSlNo, @SanctionedAmount, @Date, @RateOfInterest, @EMIPrincipalAmount, @EMIInterestAmount, @PayableAmount, @NoOfEMI, @LoanTypeName, @LoanSubTypeName,  \r\n" +
            "@EMIPeriodFormate, @EMIPeriod, @EMIPaidDay, @Remarks,@IsCompoundInterest,@LedgerFrom,@LedgerTo,@Transection_Ref_No)";

            #region -----Sql Parameter------------

            ParamList.Add(new SqlParameter("@SocietyLoanSlNo", frmSLD.SocietyLoanSlNo));
            ParamList.Add(new SqlParameter("@SanctionedAmount", frmSLD.SanctionedAmount));
            ParamList.Add(new SqlParameter("@Date", frmSLD.Date));
            ParamList.Add(new SqlParameter("@RateOfInterest", frmSLD.RateOfInterest));

            ParamList.Add(new SqlParameter("@EMIPrincipalAmount", frmSLD.EMIPrincipalAmount));
            ParamList.Add(new SqlParameter("@EMIInterestAmount", frmSLD.EMIInterestAmount));
            ParamList.Add(new SqlParameter("@PayableAmount", frmSLD.PayableAmount));

            ParamList.Add(new SqlParameter("@NoOfEMI", frmSLD.NoOfEMI));
            ParamList.Add(new SqlParameter("@LoanTypeName", frmSLD.LoanTypeName));
            ParamList.Add(new SqlParameter("@LoanSubTypeName", frmSLD.LoanSubTypeName));
            ParamList.Add(new SqlParameter("@EMIPeriodFormate", frmSLD.EMIPeriodFormate));

            ParamList.Add(new SqlParameter("@EMIPeriod", frmSLD.EMIPeriod.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@EMIPaidDay", frmSLD.EMIPaidDay.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@Remarks", frmSLD.Remarks.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@IsCompoundInterest", frmSLD.IsCompoundInterest));
            ParamList.Add(new SqlParameter("@LedgerFrom", frmSLD.LedgerFrom.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@LedgerTo", frmSLD.LedgerTo.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@Transection_Ref_No", frmSLD.Transection_Ref_No));

            #endregion

            return query;
        }

        /// <summary>
        /// Get Loan Details Of Socity
        /// </summary>
        /// <param name="frmSLD"></param>
        /// <param name="ParamList"></param>
        /// <returns></returns>
        public List<SocietyLoanDetail> GetSocityLoanDetails()
        {
            List<SocietyLoanDetail> lstview = new List<SocietyLoanDetail>();
            string query = "select * from SocietyLoanDetails";
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lstview.Add(new SocietyLoanDetail
                    {
                        id = Convert.ToInt32(item["id"]),
                        SocietyLoanSlNo = item["SocietyLoanSlNo"].ConvertObjectToString(),
                        SanctionedAmount = item["SanctionedAmount"].ConvertObjectToDouble(),
                        Date = item["Date"].ConvertObjectToDateTime(),
                        RateOfInterest = item["RateOfInterest"].ConvertObjectToDouble(),
                        EMIPrincipalAmount = item["EMIPrincipalAmount"].ConvertObjectToDouble(),
                        EMIInterestAmount = item["EMIInterestAmount"].ConvertObjectToDouble(),
                        PayableAmount = item["PayableAmount"].ConvertObjectToDouble(),
                        NoOfEMI = item["NoOfEMI"].ConvertObjectToInt(),
                        LoanTypeName = item["LoanTypeName"].ConvertObjectToString(),
                        LoanSubTypeName = item["LoanSubTypeName"].ConvertObjectToString(),
                        EMIPeriodFormate = item["EMIPeriodFormate"].ConvertObjectToString(),
                        EMIPeriod = item["EMIPeriod"].ConvertObjectToInt(),
                        EMIPaidDay = item["EMIPaidDay"].ConvertObjectToInt(),
                        Remarks = item["Remarks"].ConvertObjectToString(),
                        IsCompoundInterest = item["IsCompoundInterest"].ConvertObjectToBool(),
                        LedgerFrom = item["LedgerFrom"].ConvertToGuid(),
                        LedgerTo = item["LedgerTo"].ConvertToGuid(),
                        Transection_Ref_No = item["Transection_Ref_No"].ConvertObjectToString()
                    });
                }
            }
            return lstview;
        }

        #endregion

        #region =====================Socity loan EMI======================
        public List<SocietyLoanEMI> GetSocityLoanEMI()
        {
            List<SocietyLoanEMI> lstview = new List<SocietyLoanEMI>();
            string query = "select * from SocietyLoanEMI ORDER BY ID, NoOfEMI, EMIDate ";
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lstview.Add(new SocietyLoanEMI
                    {
                        ID=item["ID"].ConvertObjectToLong(),
                        SocietyLoanSlNo = item["SocietyLoanSlNo"].ConvertObjectToString(),
                        NoOfEMI = item["NoOfEMI"].ConvertObjectToLong(),
                        EMIDate = item["EMIDate"].ConvertObjectToDateTime(),
                        PrincipalAmount = item["PrincipalAmount"].ConvertObjectToDouble(),
                        InterestAmount = item["InterestAmount"].ConvertObjectToDouble(),
                        IsPaid = item["IsPaid"].ConvertObjectToBool(),
                        VoucherNo = item["VoucherNo"].ConvertObjectToString(),
                        PaidDate = item["PaidDate"].ConvertObjectToDateTimeWithNull(),
                        Remarks = item["Remarks"].ConvertObjectToString(),
                        Transection_Ref_No = item["Transection_Ref_No"].ConvertObjectToString()
                    });
                }
            }
            return lstview;
        }
        private string InsertQryOfSocietyLoanEMI(SocietyLoanEMI frmSLE, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  SocietyLoanEMI( SocietyLoanSlNo, NoOfEMI, EMIDate, PrincipalAmount, InterestAmount,IsPaid) " +
            "VALUES( @SocietyLoanSlNo, @NoOfEMI, @EMIDate, @PrincipalAmount, @InterestAmount,@IsPaid)";

            #region ------------Sql Parameter--------
            ParamList.Add(new SqlParameter("@SocietyLoanSlNo", frmSLE.SocietyLoanSlNo));
            ParamList.Add(new SqlParameter("@NoOfEMI", frmSLE.NoOfEMI));
            ParamList.Add(new SqlParameter("@EMIDate", frmSLE.EMIDate));
            ParamList.Add(new SqlParameter("@PrincipalAmount", frmSLE.PrincipalAmount));
            ParamList.Add(new SqlParameter("@InterestAmount", frmSLE.InterestAmount));
            ParamList.Add(new SqlParameter("@IsPaid", frmSLE.IsPaid));

            #endregion

            return query;
        }

        private string UpdateQryOfSocityLoanEMI(SocietyLoanEMI frmCLE, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "Update SocietyLoanEMI set IsPaid=@IsPaid, VoucherNo=@VoucherNo, PaidDate=@PaidDate, Remarks=@Remarks,Transection_Ref_No=@Transection_Ref_No  " +
                "where ID=@ID";

            #region ------------Sql Parameter--------
            ParamList.Add(new SqlParameter("@ID", frmCLE.ID));
            ParamList.Add(new SqlParameter("@IsPaid", frmCLE.IsPaid.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@VoucherNo", frmCLE.VoucherNo.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@PaidDate", frmCLE.PaidDate.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@Remarks", frmCLE.Remarks.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@Transection_Ref_No", frmCLE.Transection_Ref_No.ConvertNullToDBNull()));

            #endregion

            return query;
        }

        /// <summary>
        /// Delete&Update Already Payment Loan Emi Details 
        /// </summary>
        /// <param name="frmSLE"></param>
        /// <returns></returns>
        public bool DeletePaidLoanEMIsWithTransection(string _Transection_ref_No, SocietyLoanEMI frmSLE)
        {
            #region -----------Variable Section----------
            TransectionDA tfTransectionDA = new TransectionDA();
            //Query
            List<string> lst = new List<string>();
            //Parent
            List<List<SqlParameter>> sqlparam = new List<List<SqlParameter>>();

            #endregion

            #region --------------Society Loan EMI--------------
            List<SqlParameter> sqlParEMI = new List<SqlParameter>();
            string queryCustomerEMI = UpdateQryOfSocityLoanEMI(frmSLE, out sqlParEMI);

            //Add Details
            sqlparam.Add(sqlParEMI);
            lst.Add(queryCustomerEMI);
            #endregion

            #region --------------Transection--------------
            List<SqlParameter> sqlEMI_Transection = new List<SqlParameter>();
            string queryEMI_Transection = tfTransectionDA.DeleteTransections(_Transection_ref_No, out sqlEMI_Transection);

            //Add Details
            sqlparam.Add(sqlEMI_Transection);
            lst.Add(queryEMI_Transection);
            #endregion

            //Execution
            if (SqlHelper.GetInstance().ExecuteTransection(lst, sqlparam))
            {
                return true;
            }
            return false;
        }

        #endregion

        #region ========================Generate View=====================
        public List<SocietyLoanStatement_Properties> GenerateSocityLoanStatement(DateTime from, DateTime to)
        {
            List<SocietyLoanStatement_Properties> lst = new List<SocietyLoanStatement_Properties>();

            //Query
            string query = "Select SocietyLoanDetails.*,tbLedgerFrom.LedgerNameFrom,tbLedgerTO.LedgerNameTO,SocietyLoanEMI.* from (Select  SocietyLoanSlNo, Date, Transection_Ref_No,Remarks,LedgerFrom,LedgerTo,\r\n" +
"-------------------------lOAN AMOUNT Sum------------------------\r\n" +
"SUM(isnull(SanctionedAmount,0)) as TotalLoanAmount,SUM(isnull(EMIInterestAmount,0)) as TotalLoanInterestAmount,NoOfEMI from SocietyLoanDetails \r\n" +
"-------------------------Group By--------------------\r\n" +
"group by  SocietyLoanSlNo, Date, Transection_Ref_No,Remarks,NoOfEMI,LedgerFrom,LedgerTo) as SocietyLoanDetails \r\n" +
"---------------------------joining-------------------\r\n" +
"left join\r\n" +
"(Select SocietyLoanSlNo as SocietyLoanEMI_SocietyLoanSlNo,\r\n" +
"------------------------- Paid Amount Sum--------------\r\n" +
"SUM(isnull(PrincipalAmount,0)) as  TotalPaidPrincipalAmount,SUM(isnull(InterestAmount,0)) as TotalPaidInterestAmount,COUNT(NoOfEMI) as NoOfPaidEMI \r\n" +
"----------------------------- -----------------------\r\n" +
"from SocietyLoanEMI where IsPaid='True' group by SocietyLoanSlNo) as SocietyLoanEMI on SocietyLoanEMI.SocietyLoanEMI_SocietyLoanSlNo=SocietyLoanDetails.SocietyLoanSlNo\r\n" +
"-------------------------------Ledger------------ -\r\n" +
"inner join ( select LedgerId,LedgerName as LedgerNameFrom from Ledgers) as tbLedgerFrom on SocietyLoanDetails.LedgerFrom=tbLedgerFrom.LedgerId\r\n" +
"inner join ( select LedgerId,LedgerName as LedgerNameTO from Ledgers) as tbLedgerTO on SocietyLoanDetails.LedgerTo=tbLedgerTO.LedgerId\r\n" +
"-------------------------------Where Cause-------------\r\n" +
"where CAST(FLOOR(CAST(SocietyLoanDetails.Date AS FLOAT)) AS DATETIME) between @from and @to;\r\n";



            #region -----Sql Parameter------------
            SqlHelper.MParameterList.Add(new SqlParameter("@from", from.Date.ToShortDateString()));
            SqlHelper.MParameterList.Add(new SqlParameter("@to", to.Date.ToShortDateString()));
            #endregion

            //Execute
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lst.Add(
                       new SocietyLoanStatement_Properties
                       {
                           Transection_Ref_No = item["Transection_Ref_No"].ConvertObjectToString(),
                           No = item["SocietyLoanSlNo"].ConvertObjectToString(),
                           Date = item["Date"].ConvertObjectToDateTime(),
                           
                           //Loan
                           TotalLoanAmount = item["TotalLoanAmount"].ConvertObjectToDouble(),
                           TotalLoanInterestAmount = item["TotalLoanInterestAmount"].ConvertObjectToDouble(),

                           //Paid
                           TotalPaidPrincipalAmount  = item["TotalPaidPrincipalAmount"].ConvertObjectToDouble(),
                           TotalPaidInterestAmount = item["TotalPaidInterestAmount"].ConvertObjectToDouble(),

                           //EMI
                           TotalEMI = item["NoOfEMI"].ConvertObjectToInt(),
                           TotalPaidEMI = item["NoOfPaidEMI"].ConvertObjectToInt(),

                           //--=Ledger==-
                           LoanBankLedgerId = item["LedgerFrom"].ConvertObjectToGuid(),
                           LoanBank = item["LedgerNameTO"].ConvertObjectToString(),
                           LoanReceiveLedgerId = item["LedgerTo"].ConvertObjectToGuid(),
                           LoanReceiveBank = item["LedgerNameFrom"].ConvertObjectToString(),


                       }
                    );
                }
            }
            return lst;
        }

        #endregion

        #region ============================Loan Repayment================
       
        public bool UpdateSocityLoanEmiWithTransection(SocietyLoanEMI frmSLE, List<Transection> frmListTransection)
        {
            #region -----------Variable Section----------
            //Query
            List<string> lst = new List<string>();
            //Parent
            List<List<SqlParameter>> sqlparam = new List<List<SqlParameter>>();
            #endregion

            #region --------------Socity Loan EMI--------------

            List<SqlParameter> sqlParEMI = new List<SqlParameter>();
            string querySocityEMI = UpdateQryOfSocityLoanEMI(frmSLE, out sqlParEMI);

            //Add Details
            sqlparam.Add(sqlParEMI);
            lst.Add(querySocityEMI);
            #endregion

            #region --------------Transection--------------
            foreach (Transection EMI_Transection in frmListTransection)
            {
                List<SqlParameter> sqlEMI_Transection = new List<SqlParameter>();
                TransectionDA tfTransectionDA = new TransectionDA();
                string queryEMI_Transection = tfTransectionDA.InsertQryOfTransection(EMI_Transection, out sqlEMI_Transection);

                //Add Details
                sqlparam.Add(sqlEMI_Transection);
                lst.Add(queryEMI_Transection);
            }
            #endregion

            //Execution
            if (SqlHelper.GetInstance().ExecuteTransection(lst, sqlparam))
            {
                return true;
            }
            return false;
        }
        #endregion

    }
}
