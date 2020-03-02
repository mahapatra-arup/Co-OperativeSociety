using BusinessEntities;
using SocietyDataAccess.Ledgers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SocietyDataAccess.Customer
{
    public class CustomerDetailsDA
    {
        #region ------------------Insert Section---------------
        private string InsertQryOfCustomerDetails(CustomerDetail frmCD, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  CustomerDetails( CustomerId, Customername, PanNo, AadhaarNo, DOB, LedgerId) " +
            "VALUES( @CustomerId, @Customername, @PanNo, @AadhaarNo, @DOB, @LedgerId)";

            #region ------------Sql Parameter--------

            ParamList.Add(new SqlParameter("@CustomerId", frmCD.CustomerId));
            ParamList.Add(new SqlParameter("@Customername", frmCD.Customername));
            ParamList.Add(new SqlParameter("@PanNo", frmCD.PanNo));
            ParamList.Add(new SqlParameter("@AadhaarNo", frmCD.AadhaarNo));
            ParamList.Add(new SqlParameter("@DOB", frmCD.DOB));
            ParamList.Add(new SqlParameter("@LedgerId", frmCD.LedgerId));
            #endregion

            return query;
        }

        private string InsertQryOfCustomerAddressDetails(CustomerAddressDetail frmCAD, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  CustomerAddressDetails( CustomerId, PrVill, PrPS, PrPIN, prDist, pmVill, pmPS, pmPIN, pmDist, mNo, lNo, emailID) " +
            "VALUES(@CustomerId, @PrVill, @PrPS, @PrPIN, @prDist, @pmVill, @pmPS, @pmPIN, @pmDist, @mNo, @lNo, @emailID)";

            #region ------------Sql Parameter--------

            ParamList.Add(new SqlParameter("@CustomerId", frmCAD.CustomerId));
            ParamList.Add(new SqlParameter("@PrVill", frmCAD.PrVill));
            ParamList.Add(new SqlParameter("@PrPS", frmCAD.PrPS));
            ParamList.Add(new SqlParameter("@PrPIN", frmCAD.PrPIN));
            ParamList.Add(new SqlParameter("@prDist", frmCAD.prDist));
            ParamList.Add(new SqlParameter("@pmVill", frmCAD.pmVill));
            ParamList.Add(new SqlParameter("@pmPS", frmCAD.pmPS));
            ParamList.Add(new SqlParameter("@pmPIN", frmCAD.pmPIN));
            ParamList.Add(new SqlParameter("@pmDist", frmCAD.pmDist));
            ParamList.Add(new SqlParameter("@mNo", frmCAD.mNo));
            ParamList.Add(new SqlParameter("@lNo", frmCAD.lNo));
            ParamList.Add(new SqlParameter("@emailID", frmCAD.emailID));
            #endregion

            return query;
        }


        private string InsertQryOfCustomerBankDetails(CustomerBankDetail frmCBD, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  CustomerBankDetails(CustomerId, BankID, BranchName, BankIFC, MICRCode, AccountNo, BranchCode) " +
            "VALUES(@CustomerId, @BankID, @BranchName, @BankIFC, @MICRCode, @AccountNo, @BranchCode)";

            #region ------------Sql Parameter--------
            ParamList.Add(new SqlParameter("@CustomerId", frmCBD.CustomerId));
            ParamList.Add(new SqlParameter("@BankID", frmCBD.BankID));
            ParamList.Add(new SqlParameter("@BranchName", frmCBD.BranchName));
            ParamList.Add(new SqlParameter("@BankIFC", frmCBD.BankIFC));
            ParamList.Add(new SqlParameter("@MICRCode", frmCBD.MICRCode));
            ParamList.Add(new SqlParameter("@AccountNo", frmCBD.AccountNo));
            ParamList.Add(new SqlParameter("@BranchCode", frmCBD.BranchCode));
            #endregion

            return query;
        }

        /// <summary>
        /// Insert Customer Details With Address and bank details 
        ///
        /// </summary>
        /// <param name="frmCD"></param>
        /// <param name="frmCAD"></param>
        /// <param name="frmCBD"></param>
        /// <param name="frmlstLedger">Customer Ledger(like Parent and loan ledger)</param>
        /// <param name="frmlstLedger"></param>
        /// <returns></returns>
        public bool InsertCustomerDetails(CustomerDetail frmCD, CustomerAddressDetail frmCAD, CustomerBankDetail frmCBD, List<Ledger> frmlstLedger)
        {
            #region ---------Variable Section----------
            //Query
            List<string> lst = new List<string>();
            //Parent
            List<List<SqlParameter>> sqlparam = new List<List<SqlParameter>>();
            LedgerDA frmLedgerDA = new LedgerDA();
            #endregion

            //==Logic==
            #region --------------Ledger---------------
            foreach (Ledger frmLedger in frmlstLedger)
            {
                List<SqlParameter> sqlLedger = new List<SqlParameter>();
                string queryLedger = frmLedgerDA.InsertQryOfLedgers(frmLedger, out sqlLedger);

                //Add Details
                sqlparam.Add(sqlLedger);
                lst.Add(queryLedger);
            }
            #endregion

            #region ----------Customer Detail----------
            List<SqlParameter> sqlCD = new List<SqlParameter>();
            string queryCD = InsertQryOfCustomerDetails(frmCD, out sqlCD);

            //Add Details
            sqlparam.Add(sqlCD);
            lst.Add(queryCD);
            #endregion

            #region -------Customer Address Detail-----
            List<SqlParameter> sqlCAD = new List<SqlParameter>();
            string queryCAD = InsertQryOfCustomerAddressDetails(frmCAD, out sqlCAD);

            //Add Details
            sqlparam.Add(sqlCAD);
            lst.Add(queryCAD);
            #endregion

            #region ---------Customer Bank Detail------
            List<SqlParameter> sqlCBD = new List<SqlParameter>();
            string queryCBD = InsertQryOfCustomerBankDetails(frmCBD, out sqlCBD);

            //Add Details
            sqlparam.Add(sqlCBD);
            lst.Add(queryCBD);
            #endregion

            //Execution
            if (SqlHelper.GetInstance().ExecuteTransection(lst, sqlparam))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region ------------------Update Section---------------
        private string UpdateQryOfCustomerDetails(CustomerDetail frmCD, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();
            //Query
            string query = "update  CustomerDetails set Customername=@Customername, PanNo=@PanNo, AadhaarNo=@AadhaarNo, DOB=@DOB " +
                "where CustomerId=@CustomerId";

            #region ------------Sql Parameter--------

            ParamList.Add(new SqlParameter("@CustomerId", frmCD.CustomerId));
            ParamList.Add(new SqlParameter("@Customername", frmCD.Customername));
            ParamList.Add(new SqlParameter("@PanNo", frmCD.PanNo));
            ParamList.Add(new SqlParameter("@AadhaarNo", frmCD.AadhaarNo));
            ParamList.Add(new SqlParameter("@DOB", frmCD.DOB));
            #endregion

            return query;
        }

        private string UpdateQryOfCustomerAddressDetails(CustomerAddressDetail frmCAD, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();
            //Query
            string query = "Update   CustomerAddressDetails set PrVill=@PrVill, PrPS=@PrPS, PrPIN=@PrPIN, prDist=@prDist,  \r\n" +
                "pmVill=@pmVill, pmPS=@pmPS, pmPIN=@pmPIN, pmDist=@pmDist, mNo=@mNo, lNo=@lNo, emailID=@emailID  \r\n" +
                 "where CustomerId=@CustomerId";

            #region ------------Sql Parameter--------

            ParamList.Add(new SqlParameter("@CustomerId", frmCAD.CustomerId));
            ParamList.Add(new SqlParameter("@PrVill", frmCAD.PrVill));
            ParamList.Add(new SqlParameter("@PrPS", frmCAD.PrPS));
            ParamList.Add(new SqlParameter("@PrPIN", frmCAD.PrPIN));
            ParamList.Add(new SqlParameter("@prDist", frmCAD.prDist));
            ParamList.Add(new SqlParameter("@pmVill", frmCAD.pmVill));
            ParamList.Add(new SqlParameter("@pmPS", frmCAD.pmPS));
            ParamList.Add(new SqlParameter("@pmPIN", frmCAD.pmPIN));
            ParamList.Add(new SqlParameter("@pmDist", frmCAD.pmDist));
            ParamList.Add(new SqlParameter("@mNo", frmCAD.mNo));
            ParamList.Add(new SqlParameter("@lNo", frmCAD.lNo));
            ParamList.Add(new SqlParameter("@emailID", frmCAD.emailID));
            #endregion

            return query;
        }

        private string UpdateQryOfCustomerBankDetails(CustomerBankDetail frmCBD, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();
            //Query
            string query = "Update   CustomerBankDetails set BankID=@BankID, BranchName=@BranchName, BankIFC=@BankIFC, MICRCode=@MICRCode, AccountNo=@AccountNo, BranchCode=@BranchCode \r\n" +
                 "where CustomerId=@CustomerId";
            #region ------------Sql Parameter--------
            ParamList.Add(new SqlParameter("@CustomerId", frmCBD.CustomerId));
            ParamList.Add(new SqlParameter("@BankID", frmCBD.BankID));
            ParamList.Add(new SqlParameter("@BranchName", frmCBD.BranchName));
            ParamList.Add(new SqlParameter("@BankIFC", frmCBD.BankIFC));
            ParamList.Add(new SqlParameter("@MICRCode", frmCBD.MICRCode));
            ParamList.Add(new SqlParameter("@AccountNo", frmCBD.AccountNo));
            ParamList.Add(new SqlParameter("@BranchCode", frmCBD.BranchCode));
            #endregion

            return query;
        }

        /// <summary>
        /// update Customer Details With Address and bank details 
        /// </summary>
        /// <param name="frmCD"></param>
        /// <param name="frmCAD"></param>
        /// <param name="frmCBD"></param>
        /// <param name="frmlstLedger">only LedgerID,LedgerName are Acceptable</param>
        /// <returns></returns>
        public bool UpdateCustomerDetails(CustomerDetail frmCD, CustomerAddressDetail frmCAD, CustomerBankDetail frmCBD, List<Ledger> frmlstLedger)
        {
            #region --------Variable Section----------
            //Query
            List<string> lst = new List<string>();
            //Parent
            List<List<SqlParameter>> sqlparam = new List<List<SqlParameter>>();
            LedgerDA frmLedgerDA = new LedgerDA();
            #endregion

            //==Logic==
            #region --------------Ledger--------------
            foreach (Ledger frmLedger in frmlstLedger)
            {
                List<SqlParameter> sqlLedger = new List<SqlParameter>();
                string queryLedger = frmLedgerDA.UpdateQryOfLedgersName(frmLedger.LedgerId, frmLedger.LedgerName, frmLedger.TemplateName, out sqlLedger);

                //Add Details
                sqlparam.Add(sqlLedger);
                lst.Add(queryLedger);
            }

            #endregion

            #region ----------Customer Detail---------
            List<SqlParameter> sqlCD = new List<SqlParameter>();
            string queryCD = UpdateQryOfCustomerDetails(frmCD, out sqlCD);

            //Add Details
            sqlparam.Add(sqlCD);
            lst.Add(queryCD);
            #endregion

            #region -------Customer Address Detail----
            List<SqlParameter> sqlCAD = new List<SqlParameter>();
            string queryCAD = UpdateQryOfCustomerAddressDetails(frmCAD, out sqlCAD);

            //Add Details
            sqlparam.Add(sqlCAD);
            lst.Add(queryCAD);
            #endregion

            #region -------Customer Bank Detail-------
            List<SqlParameter> sqlCBD = new List<SqlParameter>();
            string queryCBD = UpdateQryOfCustomerBankDetails(frmCBD, out sqlCBD);

            //Add Details
            sqlparam.Add(sqlCBD);
            lst.Add(queryCBD);
            #endregion


            //Execution
            if (SqlHelper.GetInstance().ExecuteTransection(lst, sqlparam))
            {
                return true;
            }
            return false;
        }
        #endregion


        /// <summary>
        /// Get Customer Details With Address and Bank Details
        /// </summary>
        /// <returns></returns>
        public List<CustomerList> GetCustomerList()
        {
            List<CustomerList> lstCustomerList = new List<CustomerList>();

            //Query
            string query = "SELECT  * from CustomerList ";

            //Execution
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lstCustomerList.Add(new CustomerList
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
                        Code = Convert.ToString((item["Code"])),
                        LedgerName = Convert.ToString((item["LedgerName"]))
                    });
                }
            }
            return lstCustomerList;
        }

        /// <summary>
        /// Get Customer Details With Address and Bank Details Use By [Id]
        /// </summary>
        /// <returns></returns>
        public CustomerList GetCustomerList(object CustomerId)
        {
            CustomerList lstCustomerList = new CustomerList();

            //Query
            string query = "SELECT  * from CustomerList where CustomerId=@CustomerId";
            //Source
            SqlHelper.MParameterList.Add(new SqlParameter("@CustomerId", CustomerId));

            //Execution
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lstCustomerList = new CustomerList
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
                        Code = Convert.ToString((item["Code"])),
                        LedgerName = Convert.ToString((item["LedgerName"]))
                    };
                }
            }
            return lstCustomerList;
        }
       
        /// <summary>
        /// Use CustomerList Table
        /// </summary>
        /// <param name="_CustomerName"></param>
        /// <param name="_CustomerPhNo"></param>
        /// <param name="_OtherQuery">Like : id=1</param>
        /// <returns></returns>
        public bool IsAlreadyExist(object _CustomerName, object _CustomerPhNo, string _OtherQuery)
        {
            //Query
            string sQry = (_OtherQuery.ISNullOrWhiteSpace() ? string.Empty : " and " + _OtherQuery);
            string query = "SELECT  * from CustomerList " +
            "where mNo=@mNo and Customername=@Customername " + sQry;

            //Execution
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            SqlHelper.MParameterList.Add(new SqlParameter("@Customername", _CustomerName));
            SqlHelper.MParameterList.Add(new SqlParameter("@mNo", _CustomerPhNo));

            if (dt.IsValidDataTable())
            {
                return true;
            }
            return false;
        }
    }
}
