using BusinessEntities;
using BusinessEntities._enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace SocietyDataAccess.Ledgers
{
    public class LedgerDA
    {

        #region ==========================Ledger ========================================
        public string InsertQryOfLedgers(Ledger frmLedger, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  Ledgers( LedgerId, LedgerName, TemplateName, Category, SubAccount, ParentLedgerId, Type) " +
            "VALUES(@LedgerId, @LedgerName, @TemplateName, @Category, @SubAccount, @ParentLedgerId, @Type)";

            #region ------------Sql Parameter--------
            ParamList.Add(new SqlParameter("@LedgerId", frmLedger.LedgerId));
            ParamList.Add(new SqlParameter("@LedgerName", frmLedger.LedgerName));
            ParamList.Add(new SqlParameter("@TemplateName", frmLedger.TemplateName));
            ParamList.Add(new SqlParameter("@Category", frmLedger.Category));
            ParamList.Add(new SqlParameter("@SubAccount", SqlHelper.Convert_null_To_DBNull(frmLedger.SubAccount)));
            ParamList.Add(new SqlParameter("@ParentLedgerId", frmLedger.ParentLedgerId.ISValidObject() ? (object)frmLedger.ParentLedgerId : DBNull.Value));
            ParamList.Add(new SqlParameter("@Type", SqlHelper.Convert_null_To_DBNull(frmLedger.Type)));
            #endregion

            return query;
        }

        /// <summary>
        /// Update Ledger All Details
        /// </summary>
        /// <param name="frmLedger"></param>
        /// <param name="ParamList"></param>
        /// <returns></returns>
        public string UpdateQryOfLedgers(Ledger frmLedger, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "Update  Ledgers set  LedgerName=@LedgerName, TemplateName=@TemplateName, Category=@Category, SubAccount=@SubAccount, ParentLedgerId=@ParentLedgerId, Type=@Type  " +
            "where LedgerId=@LedgerId";

            #region ------------Sql Parameter--------
            ParamList.Add(new SqlParameter("@LedgerId", frmLedger.LedgerId));
            ParamList.Add(new SqlParameter("@LedgerName", frmLedger.LedgerName));
            ParamList.Add(new SqlParameter("@TemplateName", frmLedger.TemplateName));
            ParamList.Add(new SqlParameter("@Category", frmLedger.Category));
            ParamList.Add(new SqlParameter("@SubAccount", frmLedger.SubAccount));
            ParamList.Add(new SqlParameter("@ParentLedgerId", SqlHelper.Convert_null_To_DBNull(frmLedger.ParentLedgerId)));
            ParamList.Add(new SqlParameter("@Type", SqlHelper.Convert_null_To_DBNull(frmLedger.Type)));
            #endregion

            return query;
        }

        /// <summary>
        /// Only Update Ledger Name
        /// </summary>
        /// <param name="frmLedger"></param>
        /// <param name="ParamList"></param>
        /// <returns></returns>
        public string UpdateQryOfLedgersName(object ledgerid, object ledgerName, object TemplateName, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "Update  Ledgers set  LedgerName=@LedgerName,TemplateName=@TemplateName  " +
            "where LedgerId=@LedgerId";

            #region ------------Sql Parameter--------
            ParamList.Add(new SqlParameter("@LedgerId", ledgerid));
            ParamList.Add(new SqlParameter("@LedgerName", ledgerName));
            ParamList.Add(new SqlParameter("@TemplateName", TemplateName));
            #endregion

            return query;
        }

        /// <summary>
        /// ///---- Get Ledger By Attribute(Column) and list of Attribute Value----
        /// </summary>
        /// <param name="_ledgerattrb"></param>
        /// <param name="_AttValue"></param>
        /// <returns></returns>
        public List<Ledger> GetLedger<T>(LedgerEnum._LedgerAttributes _ledgerattrb, List<T> _lstAttributeValue)
        {
            //---get string from enum variable -----
            string strLedgerAttribute = _ledgerattrb.GetEnumName();
            string _AttValues = string.Empty;
            int c = 0;
            foreach (var item in _lstAttributeValue)
            {
                string _Att001 = item.IsEnumValue() ? item.GetEnumName() : item.ConvertObjectToString();
                _AttValues += c > 0 ? (",'" + _Att001 + "'") : ("'" + _Att001 + "'");
                c++;
            }

            //Object Type
            List<Ledger> ldger = new List<Ledger>();
            List<SqlParameter> ParamList = new List<SqlParameter>();

            //query
            string query = " select * from Ledgers where " + strLedgerAttribute + " in (" + _AttValues + ")";

            //Source 
            SqlHelper.MParameterList = ParamList;

            //Execute Query
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    ldger.Add(new Ledger
                    {
                        Id = Convert.ToInt32(item["Id"]),
                        LedgerId = Guid.Parse(item["LedgerId"].ToString()),
                        LedgerName = Convert.ToString(item["LedgerName"]),
                        TemplateName = Convert.ToString(item["TemplateName"]),
                        Category = Convert.ToString(item["Category"]),
                        SubAccount = Convert.ToString(item["SubAccount"]),
                        ParentLedgerId = item["ParentLedgerId"].ISValidObject() ? (Guid)(item["ParentLedgerId"]) : (Guid?)null,
                        Type = Convert.ToString(item["Type"]),
                    });
                }
            }
            return ldger;
        }

        /// <summary>
        /// ///---- Get Ledger By Attribute(Column) and Attribute Value----
        /// </summary>
        /// <param name="_ledgerattrb"></param>
        /// <param name="_AttValue"></param>
        /// <returns></returns>
        public List<Ledger> GetLedger<T>(LedgerEnum._LedgerAttributes _ledgerattrb, T _AttributeValue)
        {
            //---get string from enum variable -----
            string strLedgerAttribute = _ledgerattrb.GetEnumName();
            
            //---Enum Value Or Not--
            string _AttValue = _AttributeValue.IsEnumValue() ? _AttributeValue.GetEnumName() : _AttributeValue.ConvertObjectToString();

            //Object Type
            List<Ledger> ldger = new List<Ledger>();
            List<SqlParameter> ParamList = new List<SqlParameter>();

            //query
            string query = " select * from Ledgers where " + strLedgerAttribute + "= @Value";
            ParamList.Add(new SqlParameter("@Value", _AttValue));

            //Source 
            SqlHelper.MParameterList = ParamList;

            //Execute Query
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    ldger.Add(new Ledger
                    {
                        Id = Convert.ToInt32(item["Id"]),
                        LedgerId = Guid.Parse(item["LedgerId"].ToString()),
                        LedgerName = Convert.ToString(item["LedgerName"]),
                        TemplateName = Convert.ToString(item["TemplateName"]),
                        Category = Convert.ToString(item["Category"]),
                        SubAccount = Convert.ToString(item["SubAccount"]),
                        ParentLedgerId = item["ParentLedgerId"].ISValidObject() ? (Guid)(item["ParentLedgerId"]) : (Guid?)null,
                        Type = Convert.ToString(item["Type"]),
                    });
                }
            }
            return ldger;
        }

        /// <summary>
        /// ///---- Get Ledger 
        /// </summary>
        /// <param name="_ledgerattrb"></param>
        /// <param name="_AttributeValue"></param>
        /// <returns></returns>
        public List<Ledger> GetLedger()
        {
            //Object Type
            List<Ledger> ldger = new List<Ledger>();

            //query
            string query = " select * from Ledgers";

            //Execute Query
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    ldger.Add(new Ledger
                    {
                        Id = Convert.ToInt32(item["Id"]),
                        LedgerId = Guid.Parse(item["LedgerId"].ToString()),
                        LedgerName = item["LedgerName"].ConvertObjectToString(),
                        TemplateName = item["TemplateName"].ConvertObjectToString(),
                        Category = item["Category"].ConvertObjectToString(),
                        SubAccount = item["SubAccount"].ConvertObjectToString(),
                        ParentLedgerId = item["ParentLedgerId"].ISValidObject() ? (Guid)(item["ParentLedgerId"]) : (Guid?)null,
                        Type = Convert.ToString(item["Type"]),
                    });
                }
            }
            return ldger;
        }

        /// <summary>
        /// Get Customer Ledger  Use by customer id
        /// </summary>
        /// <param name="_customerLedgerId"></param>
        /// <returns></returns>
        public List<Ledger> GetLedgerofCustomer(string _customerLedgerId)
        {
            //Object Type
            List<Ledger> ldger = new List<Ledger>();

            string query = "DECLARE @customerId AS varchar(MAX)='''" + _customerLedgerId + "''' \r\n" +
            "DECLARE @query_Parent AS NVARCHAR(Max) = 'SELECT  Ledgers.* FROM         CustomerDetails \r\n" +
            "INNER JOIN Ledgers ON CustomerDetails.LedgerId = Ledgers.LedgerId where CustomerDetails.CustomerId = '+@customerId \r\n" +
            "  DECLARE @query_Child AS NVARCHAR(Max) = 'SELECT  childLedger.* FROM      (' + @query_Parent + ') as Ledgers \r\n" +
            "LEFT OUTER JOIN Ledgers as childLedger on childLedger.ParentLedgerId = Ledgers.LedgerId'                    \r\n" +
            "DECLARE @query AS NVARCHAR(Max) = @query_Parent + ' Union ' + @query_Child \r\n" +
            "EXEC(@query) \r\n";

            #region ------------Sql Parameter--------
            SqlHelper.MParameterList.Add(new SqlParameter("@Customer_Id", _customerLedgerId));
            #endregion

            //Execute Query
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    ldger.Add(new Ledger
                    {
                        Id = Convert.ToInt32(item["Id"]),
                        LedgerId = Guid.Parse(item["LedgerId"].ToString()),
                        LedgerName = item["LedgerName"].ConvertObjectToString(),
                        TemplateName = item["TemplateName"].ConvertObjectToString(),
                        Category = item["Category"].ConvertObjectToString(),
                        SubAccount = item["SubAccount"].ConvertObjectToString(),
                        ParentLedgerId = item["ParentLedgerId"].ISValidObject() ? (Guid)(item["ParentLedgerId"]) : (Guid?)null,
                        Type = Convert.ToString(item["Type"]),
                    });
                }
            }
            return ldger;
        }

        /// <summary>
        /// Insert Ledgers Wint Ledger bank Details Ans Ledger Status
        /// if any class null Then this table is not Insert
        /// </summary>
        /// <param name="frmLedger"></param>
        /// <param name="frmLedgerBD"></param>
        /// <param name="IsInsertBankDetails"></param>
        /// <returns></returns>
        public bool InsertLedgerWithBankAndStatus(List<Ledger> frmLedger, List<LedgerBankDetail> frmLedgerBD, List<LedgersStatu> frmledgersStatu)
        {
            #region -----------Variable Section----------
            //Query
            List<string> lst = new List<string>();
            //Parent
            List<List<SqlParameter>> sqlparam = new List<List<SqlParameter>>();
            #endregion

            //==Logic==
            #region ----------Ledger --------------------
            if (frmLedger.ISValidObject())
            {
                foreach (Ledger itemledg in frmLedger)
                {
                    List<SqlParameter> sqlLedger = new List<SqlParameter>();
                    string queryLedger = InsertQryOfLedgers(itemledg, out sqlLedger);

                    //Add Details
                    sqlparam.Add(sqlLedger);
                    lst.Add(queryLedger);
                }
            }
            #endregion

            #region ----------Lesger Status -------------
            if (frmledgersStatu.ISValidObject())
            {
                foreach (LedgersStatu itemledgstatus in frmledgersStatu)
                {
                    List<SqlParameter> sqlLesgerStatus = new List<SqlParameter>();
                    string queryLesgerStatus = InsertQryOfLedgersStatus(itemledgstatus, out sqlLesgerStatus);

                    //Add Details
                    sqlparam.Add(sqlLesgerStatus);
                    lst.Add(queryLesgerStatus);
                }
            }
            #endregion


            #region ---------- Ledger Bank Details -------
            if (frmLedgerBD.ISValidObject())
            {
                foreach (LedgerBankDetail itemBD in frmLedgerBD)
                {
                    List<SqlParameter> sqlLedgerBD = new List<SqlParameter>();
                    string queryLedgerBD = InsertQryOfLedgerBankDetails(itemBD, out sqlLedgerBD);

                    //Add Details
                    sqlparam.Add(sqlLedgerBD);
                    lst.Add(queryLedgerBD);
                }
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

        #region ========================Lesger Bank Details==============================
        public string InsertQryOfLedgerBankDetails(LedgerBankDetail frmLedgerBD, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  LedgerBankDetails( LedgerID, BankID, ACNo, IFSC, MICR, BranchName, BranchCode, Address, ACType) " +
            "VALUES(@LedgerID, @BankID, @ACNo, @IFSC, @MICR, @BranchName, @BranchCode, @Address, @ACType)";

            #region ------------Sql Parameter--------

            ParamList.Add(new SqlParameter("@LedgerID", frmLedgerBD.LedgerID));
            ParamList.Add(new SqlParameter("@BankID", frmLedgerBD.BankID));
            ParamList.Add(new SqlParameter("@ACNo", SqlHelper.Convert_null_To_DBNull(frmLedgerBD.ACNo)));
            ParamList.Add(new SqlParameter("@IFSC", SqlHelper.Convert_null_To_DBNull(frmLedgerBD.IFSC)));
            ParamList.Add(new SqlParameter("@MICR", SqlHelper.Convert_null_To_DBNull(frmLedgerBD.MICR)));
            ParamList.Add(new SqlParameter("@BranchName", SqlHelper.Convert_null_To_DBNull(frmLedgerBD.BranchName)));
            ParamList.Add(new SqlParameter("@BranchCode", SqlHelper.Convert_null_To_DBNull(frmLedgerBD.BranchCode)));

            ParamList.Add(new SqlParameter("@Address", SqlHelper.Convert_null_To_DBNull(frmLedgerBD.Address)));
            ParamList.Add(new SqlParameter("@ACType", SqlHelper.Convert_null_To_DBNull(frmLedgerBD.ACType)));

            #endregion

            return query;
        }


        public List<LedgerBankDetail> GetLedgerBankDetails()
        {
            List<LedgerBankDetail> lstLedgerBankDetails = new List<LedgerBankDetail>();

            //Query
            string query = "SELECT  * from LedgerBankDetails ";

            //Execution
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lstLedgerBankDetails.Add(new LedgerBankDetail
                    {
                        LedgerID = item["LedgerID"].ConvertToGuid(),
                        BankID = item["BankID"].ConvertObjectToInt(),
                        ACNo = item["ACNo"].ConvertObjectToString(),
                        IFSC = item["IFSC"].ConvertObjectToString(),
                        MICR = item["MICR"].ConvertObjectToString(),
                        BranchName = item["BranchName"].ConvertObjectToString(),
                        BranchCode = item["BranchCode"].ConvertObjectToString(),
                        Address = item["Address"].ConvertObjectToString(),
                        ACType = item["ACType"].ConvertObjectToString(),
                    });
                }
            }
            return lstLedgerBankDetails;
        }
        #endregion

        #region =============================Ledger Status===============================
        public string InsertQryOfLedgersStatus(LedgersStatu frmLedger, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  LedgersStatus(LedgerID, FinYearID, OpeningBalance, Date) " +
            "VALUES(@LedgerID, @FinYearID, @OpeningBalance, @Date)";

            #region ------------Sql Parameter--------
            ParamList.Add(new SqlParameter("@LedgerID", frmLedger.LedgerID));
            ParamList.Add(new SqlParameter("@FinYearID", frmLedger.FinYearID));
            ParamList.Add(new SqlParameter("@OpeningBalance", frmLedger.OpeningBalance));
            ParamList.Add(new SqlParameter("@Date", frmLedger.Date));
            #endregion

            return query;
        }

        #endregion
    }
}
