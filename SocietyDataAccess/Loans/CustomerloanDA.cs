using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SocietyDataAccess.Transections;
using BusinessEntities.CustomProperties;

namespace SocietyDataAccess.Loans
{
    public class CustomerloanDA
    {
        public bool InsertCustomerLoanWithLoanEMI(CustomerLoanDetail frmCLD, List<CustomerLoanEMI> frmlstCLE, List<Transection> frmListTransection)
        {
            #region -----------Variable Section----------
            //Query
            List<string> lst = new List<string>();
            //Parent
            List<List<SqlParameter>> sqlparam = new List<List<SqlParameter>>();

            #endregion

            //==Logic==
            #region ----------CustomerLoanDetail-------
            List<SqlParameter> sqlParCustLoan = new List<SqlParameter>();
            string queryCustomerLoanDetail = InsertQryofCustomerLoanDetails(frmCLD, out sqlParCustLoan);

            //Add Details
            sqlparam.Add(sqlParCustLoan);
            lst.Add(queryCustomerLoanDetail);
            #endregion


            #region --------------CustomerLoanEMI--------------
            foreach (CustomerLoanEMI EMI_Item in frmlstCLE)
            {
                List<SqlParameter> sqlParEMI = new List<SqlParameter>();
                string queryCustomerEMI = InsertQryOfCustomerLoanEMI(EMI_Item, out sqlParEMI);

                //Add Details
                sqlparam.Add(sqlParEMI);
                lst.Add(queryCustomerEMI);
            }
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

        #region =====================Customer loan Details================
        /// <summary>
        /// Get All Customer  Loan details
        /// </summary>
        /// <returns></returns>
        private string InsertQryofCustomerLoanDetails(CustomerLoanDetail frmCLD, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  CustomerLoanDetails(LoanId,SocietyLoanSlNo, Date, CustomerId, SanctionedAmount, RateOfInterest, EMIPrincipalAmount, EMIInterestAmount, ShareAmount, ROIShare, InsuranceAmount,  \r\n" +
            "PaidInsuranceFromSociety, PayableAmount, NoOfEMI, LoanTypeName, LoanSubTypeName, EMIPeriodFormate, EMIPeriod, EMIPaidDay, Remarks,IsCompoundInterest,Transection_Ref_No) \r\n" +
            "VALUES(@LoanId, @SocietyLoanSlNo, @Date, @CustomerId, @SanctionedAmount, @RateOfInterest, @EMIPrincipalAmount, @EMIInterestAmount, @ShareAmount, @ROIShare, @InsuranceAmount, \r\n" +
            "@PaidInsuranceFromSociety, @PayableAmount, @NoOfEMI, @LoanTypeName, @LoanSubTypeName, @EMIPeriodFormate, @EMIPeriod, @EMIPaidDay, @Remarks,@IsCompoundInterest,@Transection_Ref_No)";

            #region -----Sql Parameter------------

            ParamList.Add(new SqlParameter("@LoanId", frmCLD.LoanId));
            ParamList.Add(new SqlParameter("@SocietyLoanSlNo", frmCLD.SocietyLoanSlNo));
            ParamList.Add(new SqlParameter("@Date", frmCLD.Date));

            ParamList.Add(new SqlParameter("@CustomerId", frmCLD.CustomerId));
            ParamList.Add(new SqlParameter("@SanctionedAmount", frmCLD.SanctionedAmount));
            ParamList.Add(new SqlParameter("@RateOfInterest", frmCLD.RateOfInterest));

            ParamList.Add(new SqlParameter("@EMIPrincipalAmount", frmCLD.EMIPrincipalAmount));
            ParamList.Add(new SqlParameter("@EMIInterestAmount", frmCLD.EMIInterestAmount));
            ParamList.Add(new SqlParameter("@ShareAmount", frmCLD.ShareAmount));
            ParamList.Add(new SqlParameter("@ROIShare", frmCLD.ROIShare));
            ParamList.Add(new SqlParameter("@InsuranceAmount", frmCLD.InsuranceAmount));

            ParamList.Add(new SqlParameter("@PaidInsuranceFromSociety", frmCLD.PaidInsuranceFromSociety));
            ParamList.Add(new SqlParameter("@PayableAmount", frmCLD.PayableAmount));


            ParamList.Add(new SqlParameter("@NoOfEMI", frmCLD.NoOfEMI));
            ParamList.Add(new SqlParameter("@LoanTypeName", frmCLD.LoanTypeName));
            ParamList.Add(new SqlParameter("@LoanSubTypeName", frmCLD.LoanSubTypeName));

            ParamList.Add(new SqlParameter("@EMIPeriodFormate", frmCLD.EMIPeriodFormate));
            ParamList.Add(new SqlParameter("@EMIPeriod", frmCLD.EMIPeriod));
            ParamList.Add(new SqlParameter("@EMIPaidDay", frmCLD.EMIPaidDay));
            ParamList.Add(new SqlParameter("@Remarks", frmCLD.Remarks));
            ParamList.Add(new SqlParameter("@IsCompoundInterest", frmCLD.IsCompoundInterest));
            ParamList.Add(new SqlParameter("@Transection_Ref_No", frmCLD.Transection_Ref_No));

            #endregion

            return query;
        }
        public List<CustomerLoanDetail> GetCustomerLoanDetails()
        {
            List<CustomerLoanDetail> lstview = new List<CustomerLoanDetail>();
            string query = "select * from CustomerLoanDetails";
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lstview.Add(new CustomerLoanDetail
                    {
                        LoanId = item["LoanId"].ConvertToGuid(),
                        CustomerId = item["CustomerId"].ConvertToGuid(),
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
                        //-------
                        ShareAmount = item["ShareAmount"].ConvertObjectToDouble(),
                        ROIShare = item["ROIShare"].ConvertObjectToDouble(),
                        InsuranceAmount = item["InsuranceAmount"].ConvertObjectToDouble(),
                        PaidInsuranceFromSociety = item["PaidInsuranceFromSociety"].ConvertObjectToDouble(),
                        Transection_Ref_No = item["Transection_Ref_No"].ConvertObjectToString()
                    });

                }
            }
            return lstview;
        }
        /// <summary>
        /// Get  All Customer  All EMI
        /// </summary>
        /// <returns></returns> 
        #endregion

        #region ===========================Customer Loan EMI==============
        public string UpdateQryOfCustomerLoanEMI(CustomerLoanEMI frmCLE, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "Update CustomerLoanEMI set IsPaid=@IsPaid, VoucherNo=@VoucherNo, PaidDate=@PaidDate, Remarks=@Remarks,Transection_Ref_No=@Transection_Ref_No  " +
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
        /// /Insert customer Loan Details With EMI And Insert Loan Transection
        /// </summary>
        /// <param name="frmCLD"></param>
        /// <param name="frmlstCLE"></param>
        /// <param name="frmListTransection"></param>
        /// <returns></returns>
        private string InsertQryOfCustomerLoanEMI(CustomerLoanEMI frmCLE, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  CustomerLoanEMI( LoanId, NoOfEMI, EMIDate, PrincipalAmount, InterestAmount, IsPaid, VoucherNo, PaidDate, Remarks) " +
            "VALUES(@LoanId, @NoOfEMI, @EMIDate, @PrincipalAmount, @InterestAmount, @IsPaid, @VoucherNo, @PaidDate, @Remarks)";

            #region ------------Sql Parameter--------
            ParamList.Add(new SqlParameter("@LoanId", frmCLE.LoanId));
            ParamList.Add(new SqlParameter("@NoOfEMI", frmCLE.NoOfEMI));
            ParamList.Add(new SqlParameter("@EMIDate", frmCLE.EMIDate));
            ParamList.Add(new SqlParameter("@PrincipalAmount", frmCLE.PrincipalAmount.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@InterestAmount", frmCLE.InterestAmount.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@IsPaid", frmCLE.IsPaid.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@VoucherNo", frmCLE.VoucherNo.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@PaidDate", frmCLE.PaidDate.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@Remarks", frmCLE.Remarks.ConvertNullToDBNull()));
            #endregion

            return query;
        }
        /// <summary>
        /// Delete & Update Paid EMIs
        /// </summary>
        /// <param name="_Transection_ref_No"></param>
        /// <param name="frmCLE"></param>
        /// <returns></returns>
        public bool DeletePaidLoanEMIsWithTransection(string _Transection_ref_No, CustomerLoanEMI frmCLE)
        {
            #region -----------Variable Section----------
            TransectionDA tfTransectionDA = new TransectionDA();
            //Query
            List<string> lst = new List<string>();
            //Parent
            List<List<SqlParameter>> sqlparam = new List<List<SqlParameter>>();

            #endregion

            #region --------------CustomerLoanEMI--------------
            List<SqlParameter> sqlParEMI = new List<SqlParameter>();
            string queryCustomerEMI = UpdateQryOfCustomerLoanEMI(frmCLE, out sqlParEMI);

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
        /// <summary>
        /// Get Customer Loan Emi Use Customer Id
        /// </summary>
        /// <param name="_customerId"></param>
        /// <returns></returns>
        public List<CustomerLoanEMI> GetCustomerLoanEMIByCustomer(Guid _customerId)
        {
            List<CustomerLoanEMI> lstview = new List<CustomerLoanEMI>();
            string query = "SELECT    DISTINCT   CustomerLoanDetails.CustomerId,dbo.CustomerLoanEMI.ID, dbo.CustomerLoanEMI.LoanId, dbo.CustomerLoanEMI.NoOfEMI, dbo.CustomerLoanEMI.EMIDate, dbo.CustomerLoanEMI.PrincipalAmount,dbo.CustomerLoanEMI.Transection_Ref_No, \r\n" +
            "                      dbo.CustomerLoanEMI.InterestAmount, dbo.CustomerLoanEMI.IsPaid, dbo.CustomerLoanEMI.VoucherNo, dbo.CustomerLoanEMI.PaidDate, dbo.CustomerLoanEMI.Remarks\r\n" +
            "FROM         dbo.CustomerLoanDetails INNER JOIN\r\n" +
            "                      dbo.CustomerLoanEMI ON dbo.CustomerLoanDetails.LoanId = dbo.CustomerLoanEMI.LoanId\r\n" +
            "                      WHERE CustomerLoanDetails.CustomerId=@CustomerId \r\n" +
            "ORDER BY dbo.CustomerLoanEMI.NoOfEMI ASC\r\n";

            //Param
            SqlHelper.MParameterList.Add(new SqlParameter("@CustomerId", _customerId));

            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lstview.Add(new CustomerLoanEMI
                    {
                        ID = item["ID"].ConvertObjectToInt(),
                        LoanId = item["LoanId"].ConvertToGuid(),
                        NoOfEMI = item["NoOfEMI"].ConvertObjectToInt(),
                        EMIDate = item["EMIDate"].ConvertObjectToDateTime(),
                        PrincipalAmount = item["PrincipalAmount"].ConvertObjectToDouble(),
                        InterestAmount = item["InterestAmount"].ConvertObjectToDouble(),
                        IsPaid = item["IsPaid"].ConvertObjectToBool(),
                        VoucherNo = item["VoucherNo"].ConvertObjectToInt(),
                        PaidDate = item["PaidDate"].ConvertObjectToDateTime(),
                        Remarks = item["Remarks"].ConvertObjectToString(),
                        Transection_Ref_No = item["Transection_Ref_No"].ConvertObjectToString()
                    });

                }
            }
            return lstview;
        }

        /// <summary>
        /// Get All Loan Emi
        /// </summary>
        /// <returns></returns>
        public List<CustomerLoanEMI> GetCustomerLoanEMI()
        {
            List<CustomerLoanEMI> lstview = new List<CustomerLoanEMI>();
            string query = "select * from CustomerLoanEMI";
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lstview.Add(new CustomerLoanEMI
                    {
                        ID = item["ID"].ConvertObjectToInt(),
                        LoanId = item["LoanId"].ConvertToGuid(),
                        NoOfEMI = item["NoOfEMI"].ConvertObjectToInt(),
                        EMIDate = item["EMIDate"].ConvertObjectToDateTime(),
                        PrincipalAmount = item["PrincipalAmount"].ConvertObjectToDouble(),
                        InterestAmount = item["InterestAmount"].ConvertObjectToDouble(),
                        IsPaid = item["IsPaid"].ConvertObjectToBool(),
                        VoucherNo = item["VoucherNo"].ConvertObjectToInt(),
                        PaidDate = item["PaidDate"].ConvertObjectToDateTime(),
                        Remarks = item["Remarks"].ConvertObjectToString(),
                        Transection_Ref_No = item["Transection_Ref_No"].ConvertObjectToString(),
                    });

                }
            }
            return lstview;
        }

        /// <summary>
        /// Get  Customer Loan Emi Ispaid:(Due List=false,Paid List=True)
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <param name="SocietyLoanSlNo"></param>
        /// <param name="IsPaid"></param>
        /// <returns></returns>
        public List<CustomerLoanEMI> GetCustomerLoanEMI(Guid CustomerId, string SocietyLoanSlNo, bool IsPaid)
        {
            List<CustomerLoanEMI> lstview = new List<CustomerLoanEMI>();
            string query = "SELECT    DISTINCT   CustomerLoanDetails.CustomerId,dbo.CustomerLoanEMI.ID,dbo.CustomerLoanEMI.Transection_Ref_No, dbo.CustomerLoanEMI.LoanId, dbo.CustomerLoanEMI.NoOfEMI, dbo.CustomerLoanEMI.EMIDate, dbo.CustomerLoanEMI.PrincipalAmount, \r\n" +
            "dbo.CustomerLoanEMI.InterestAmount, dbo.CustomerLoanEMI.IsPaid, dbo.CustomerLoanEMI.VoucherNo, dbo.CustomerLoanEMI.PaidDate, dbo.CustomerLoanEMI.Remarks\r\n" +
            "FROM         dbo.CustomerLoanDetails INNER JOIN\r\n" +
            "dbo.CustomerLoanEMI ON dbo.CustomerLoanDetails.LoanId = dbo.CustomerLoanEMI.LoanId\r\n" +
            "WHERE CustomerLoanDetails.CustomerId=@CustomerId and CustomerLoanDetails.SocietyLoanSlNo=@SocietyLoanSlNo  and isnull(IsPaid,'False')=@IsPaid \r\n" +
            "ORDER BY dbo.CustomerLoanEMI.NoOfEMI ASC\r\n";

            SqlHelper.MParameterList.Add(new SqlParameter("@CustomerId", CustomerId));
            SqlHelper.MParameterList.Add(new SqlParameter("@SocietyLoanSlNo", SocietyLoanSlNo));
            SqlHelper.MParameterList.Add(new SqlParameter("@IsPaid", IsPaid));

            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lstview.Add(new CustomerLoanEMI
                    {
                        ID = item["ID"].ConvertObjectToInt(),
                        LoanId = item["LoanId"].ConvertToGuid(),
                        NoOfEMI = item["NoOfEMI"].ConvertObjectToInt(),
                        EMIDate = item["EMIDate"].ConvertObjectToDateTime(),
                        PrincipalAmount = item["PrincipalAmount"].ConvertObjectToDouble(),
                        InterestAmount = item["InterestAmount"].ConvertObjectToDouble(),
                        IsPaid = item["IsPaid"].ConvertObjectToBool(),
                        VoucherNo = item["VoucherNo"].ConvertObjectToInt(),
                        PaidDate = item["PaidDate"].ConvertObjectToDateTime(),
                        Remarks = item["Remarks"].ConvertObjectToString(),
                        Transection_Ref_No = item["Transection_Ref_No"].ConvertObjectToString()

                    });

                }
            }
            return lstview;
        }

        #endregion

        #region ============================Loan Repayment================
       
        public bool UpdateCustomerLoanEmiWithTransection(CustomerLoanEMI frmCLE, List<Transection> frmListTransection)
        {
            #region -----------Variable Section----------
            //Query
            List<string> lst = new List<string>();
            //Parent
            List<List<SqlParameter>> sqlparam = new List<List<SqlParameter>>();
            #endregion

            #region --------------CustomerLoanEMI--------------

            List<SqlParameter> sqlParEMI = new List<SqlParameter>();
            string queryCustomerEMI = UpdateQryOfCustomerLoanEMI(frmCLE, out sqlParEMI);

            //Add Details
            sqlparam.Add(sqlParEMI);
            lst.Add(queryCustomerEMI);
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

        #region ======================All Mixing==========================
        /// <summary>
        /// Get Customer details With loan Details 
        /// use Table : [CustomerloanDetails] and [CustomerDetails]
        /// </summary>
        /// <returns></returns>
        public List<GetSetValues<CustomerLoanDetail, CustomerList>> GetCustomerLoanDetailsWithCustomer(DateTime from, DateTime to)
        {
            List<GetSetValues<CustomerLoanDetail, CustomerList>> lst = new List<GetSetValues<CustomerLoanDetail, CustomerList>>();

            //Query
            string query = "SELECT  *   FROM        CustomerList inner JOIN " +
            "CustomerLoanDetails on CustomerLoanDetails.CustomerId = CustomerList.CustomerId " +
            "where CAST(FLOOR(CAST(CustomerLoanDetails.Date AS FLOAT)) AS DATETIME) between @from and @to";

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
                    lst.Add(new GetSetValues<CustomerLoanDetail, CustomerList>()
                    {
                        //Value I
                        Item1 = new CustomerLoanDetail
                        {
                            LoanId = item["LoanId"].ConvertToGuid(),
                            CustomerId = item["CustomerId"].ConvertToGuid(),
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
                            //-------
                            ShareAmount = item["ShareAmount"].ConvertObjectToDouble(),
                            ROIShare = item["ROIShare"].ConvertObjectToDouble(),
                            InsuranceAmount = item["InsuranceAmount"].ConvertObjectToDouble(),
                            PaidInsuranceFromSociety = item["PaidInsuranceFromSociety"].ConvertObjectToDouble(),
                            Transection_Ref_No = item["Transection_Ref_No"].ConvertObjectToString(),
                        },

                        //value II
                        Item2 = new CustomerList
                        {
                            CustomerId = (Guid)item["CustomerId"],
                            LedgerId = (Guid)item["LedgerId"],
                            Customername = Convert.ToString(item["Customername"]),
                            PanNo = Convert.ToString(item["PanNo"]),
                            AadhaarNo = Convert.ToString(item["AadhaarNo"]),
                            DOB = Convert.ToDateTime(item["DOB"]),

                            BankID = Convert.ToInt32(item["BankID"]),
                            BranchName = Convert.ToString((item["BranchName"])),
                            BankIFC = Convert.ToString((item["BankIFC"])),
                            MICRCode = Convert.ToString((item["MICRCode"])),
                            AccountNo = Convert.ToString((item["AccountNo"])),
                            BranchCode = Convert.ToString((item["BranchCode"])),

                            PrVill = Convert.ToString((item["PrVill"])),
                            PrPS = Convert.ToString((item["PrPS"])),
                            PrPIN = Convert.ToString((item["PrPIN"])),
                            prDist = Convert.ToString((item["prDist"])),
                            pmVill = Convert.ToString((item["pmVill"])),
                            pmPS = Convert.ToString((item["pmPS"])),
                            pmPIN = Convert.ToString((item["pmPIN"])),
                            pmDist = Convert.ToString((item["pmDist"])),
                            mNo = Convert.ToString((item["mNo"])),
                            lNo = Convert.ToString((item["lNo"])),
                            emailID = Convert.ToString((item["emailID"])),
                            BankName = Convert.ToString((item["BankName"])),
                            Code = Convert.ToString((item["Code"]))
                        }
                    });
                }
            }
            return lst;
        }


        #endregion

        #region ========================Generate View=====================
        public List<CustomerLoanStatement_Properties> GenerateCustometLoanStatement(DateTime from, DateTime to)
        {
            List<CustomerLoanStatement_Properties> lst = new List<CustomerLoanStatement_Properties>();

            //Query
            string query = "Select CustomerList.Customername,CustomerList.DOB,CustomerList.mNo,CustomerLoanDetails.*,CustomerLoanEMI.* from (Select  LoanId, SocietyLoanSlNo, Date, CustomerId,Transection_Ref_No,Remarks,\r\n" +
"-------------------------Sum------------------------\r\n" +
"SUM(isnull(SanctionedAmount,0)) as TotalLoanAmount,SUM(isnull(EMIInterestAmount,0)) as TotalLoanInterestAmount,NoOfEMI from CustomerLoanDetails \r\n" +
"-------------------------Group By--------------------\r\n" +
"group by LoanId, SocietyLoanSlNo, Date, CustomerId,Transection_Ref_No,Remarks,NoOfEMI) as CustomerLoanDetails \r\n" +
"---------------------------joining-------------------\r\n" +
"left join\r\n" +
"(Select LoanId as CustomerLoanEMI_LoanId,\r\n" +
"-------------------------Sum Paid Amount--------------\r\n" +
"SUM(isnull(PrincipalAmount,0)) as TotalPaidPrincipalAmount,SUM(isnull(InterestAmount,0)) as TotalPaidInterestAmount,COUNT(NoOfEMI) as NoOfPaidEMI \r\n" +
"----------------------------- -----------------------\r\n" +
"from CustomerLoanEMI where IsPaid='True' group by LoanId) as CustomerLoanEMI on CustomerLoanEMI.CustomerLoanEMI_LoanId=CustomerLoanDetails.LoanId\r\n" +
"-------------------------------Customer Details------------ -\r\n" +
"inner join CustomerList on CustomerList.CustomerId=CustomerLoanDetails.CustomerId\r\n" +
"-------------------------------Where Cause-------------\r\n" +
"where  CAST(FLOOR(CAST(CustomerLoanDetails.Date AS FLOAT)) AS DATETIME) between @from and @to;\r\n";


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
                       new CustomerLoanStatement_Properties
                       {
                           CustomerID = item["CustomerId"].ConvertToGuid(),
                           CustomerName = item["Customername"].ConvertObjectToString(),
                           mNo = item["mNo"].ConvertObjectToString(),
                           Transection_Ref_No = item["Transection_Ref_No"].ConvertObjectToString(),
                           No = item["SocietyLoanSlNo"].ConvertObjectToString(),
                           Date = item["Date"].ConvertObjectToDateTime(),
                           //Loan
                           TotalLoanAmount = item["TotalLoanAmount"].ConvertObjectToDouble(),
                           TotalLoanInterestAmount = item["TotalLoanInterestAmount"].ConvertObjectToDouble(),

                           //Paid
                           TotalPaidPrincipalAmount = item["TotalPaidPrincipalAmount"].ConvertObjectToDouble(),
                           TotalPaidInterestAmount = item["TotalPaidInterestAmount"].ConvertObjectToDouble(),

                           //EMI
                           TotalEMI = item["NoOfEMI"].ConvertObjectToInt(),
                           TotalPaidEMI = item["NoOfPaidEMI"].ConvertObjectToInt(),
                       }
                    );
                }
            }
            return lst;
        }

        #endregion
    }
}
