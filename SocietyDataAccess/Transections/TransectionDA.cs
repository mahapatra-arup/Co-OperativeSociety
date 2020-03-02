using BusinessEntities;
using BusinessEntities._enum;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SocietyDataAccess.Transections
{
    public class TransectionDA
    {
        #region =================Transection Table===============================
        /// <summary>
        /// Insert Query Of Transection
        /// </summary>
        /// <param name="frmTran"></param>
        /// <param name="ParamList"></param>
        /// <returns></returns>
        public string InsertQryOfTransection(Transection frmTran, out List<SqlParameter> ParamList)
        {
            ParamList = new List<SqlParameter>();

            string query = "INSERT INTO  Transection(TransectionID, Date, No, TransectionType, LedgerIdFrom, LedgerIdTo, Amount_Dr, Amount_Cr, Mode, BankName, ChequeNo, ChequeDate, Narration,Status,Transection_Ref_No) " +
            "VALUES(@TransectionID, @Date, @No, @TransectionType, @LedgerIdFrom, @LedgerIdTo, @Amount_Dr, @Amount_Cr, @Mode, @BankName, @ChequeNo, @ChequeDate, @Narration,@Status,@Transection_Ref_No)";

            #region ------------Sql Parameter--------
            ParamList.Add(new SqlParameter("@TransectionID", frmTran.TransectionID));
            ParamList.Add(new SqlParameter("@Date", frmTran.Date));
            ParamList.Add(new SqlParameter("@No", frmTran.No.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@TransectionType", frmTran.TransectionType.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@LedgerIdFrom", frmTran.LedgerIdFrom));
            ParamList.Add(new SqlParameter("@LedgerIdTo", frmTran.LedgerIdTo));
            ParamList.Add(new SqlParameter("@Amount_Dr", frmTran.Amount_Dr.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@Amount_Cr", frmTran.Amount_Cr.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@Mode", frmTran.Mode.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@BankName", frmTran.BankName.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@ChequeNo", frmTran.ChequeNo.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@ChequeDate", frmTran.ChequeDate.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@Narration", frmTran.Narration.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@Status", frmTran.Status.ConvertNullToDBNull()));
            ParamList.Add(new SqlParameter("@Transection_Ref_No", frmTran.Transection_Ref_No.ConvertNullToDBNull()));

            #endregion

            return query;
        }

        /// <summary>
        /// Insert Data Of Transection
        /// </summary>
        /// <param name="frmTran"></param>
        /// <param name="ParamList"></param>
        /// <returns></returns>
        public bool InsertDataOfTransection(List<Transection> frmListTransection)
        {
            #region -----------Variable Section----------
            //Query
            List<string> lst = new List<string>();
            //Parent
            List<List<SqlParameter>> sqlparam = new List<List<SqlParameter>>();
            #endregion

            //Get Transection
            foreach (Transection EMI_Transection in frmListTransection)
            {
                List<SqlParameter> sqlEMI_Transection = new List<SqlParameter>();
                string queryEMI_Transection = InsertQryOfTransection(EMI_Transection, out sqlEMI_Transection);

                //Add Details
                sqlparam.Add(sqlEMI_Transection);
                lst.Add(queryEMI_Transection);
            }

            //Execution
            if (SqlHelper.GetInstance().ExecuteTransection(lst, sqlparam))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Delete Transection Query use By Transection_Ref_No
        /// </summary>
        /// <param name="Transection_Ref_No"></param>
        /// <param name="ParamList"></param>
        /// <returns></returns>
        public string DeleteTransections(string Transection_Ref_No, out List<SqlParameter> ParamList)
        {
            ParamList=new  List<SqlParameter>();
            //query
            string query = "DELETE FROM Transection where Transection_Ref_No=@Transection_Ref_No";
           
            //Sql Parameter Source
            ParamList.Add(new SqlParameter("@Transection_Ref_No", Transection_Ref_No));
            return query;
        }

        /// <summary>
        /// Get All Of transection
        /// </summary>
        /// <returns></returns>
        public List<Transection> GetTransections()
        {
            List<Transection> lst = new List<Transection>();

            //query
            string query = " select * from Transection";

            //Execute Query
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lst.Add(new Transection
                    {
                        id = item["id"].ConvertObjectToLong(),
                        TransectionID = item["TransectionID"].ConvertToGuid(),
                        Date = item["Date"].ConvertObjectToDateTime(),
                        No = item["No"].ConvertObjectToString(),
                        TransectionType = item["TransectionType"].ConvertObjectToString(),
                        LedgerIdFrom = item["LedgerIdFrom"].ConvertToGuid(),
                        LedgerIdTo = item["LedgerIdTo"].ConvertToGuid(),
                        Amount_Dr = item["Amount_Dr"].ConvertObjectToDouble(),
                        Amount_Cr = item["Amount_Cr"].ConvertObjectToDouble(),
                        Mode = item["Mode"].ConvertObjectToString(),
                        BankName = item["BankName"].ConvertObjectToString(),
                        ChequeNo = item["ChequeNo"].ConvertObjectToString(),
                        ChequeDate = item["ChequeDate"].ConvertObjectToDateTimeWithNull(),
                        Narration = item["Narration"].ConvertObjectToString(),
                        Status = item["Status"].ConvertObjectToString(),
                        Transection_Ref_No = item["Transection_Ref_No"].ConvertObjectToString()
                    });
                }
            }
            return lst;
        }
        #endregion


        #region ====================Transection Details View=====================

        /// <summary>
        /// Get View Of Transection View
        /// </summary>
        /// <returns></returns>
        public List<TransectionView> GetTransectionsView()
        {
            List<TransectionView> lst = new List<TransectionView>();

            //query
            string query = " select * from TransectionView ORDER BY id, Date, Transection_Ref_No";

            //Execute Query
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lst.Add(new TransectionView
                    {
                        id = item["id"].ConvertObjectToLong(),
                        TransectionID = item["TransectionID"].ConvertToGuid(),
                        Date = item["Date"].ConvertObjectToDateTime(),
                        No = item["No"].ConvertObjectToString(),
                        TransectionType = item["TransectionType"].ConvertObjectToString(),
                        LedgerIdFrom = item["LedgerIdFrom"].ConvertToGuid(),
                        LedgerIdTo = item["LedgerIdTo"].ConvertToGuid(),
                        Amount_Dr = item["Amount_Dr"].ConvertObjectToDouble(),
                        Amount_Cr = item["Amount_Cr"].ConvertObjectToDouble(),
                        Mode = item["Mode"].ConvertObjectToString(),
                        BankName = item["BankName"].ConvertObjectToString(),
                        ChequeNo = item["ChequeNo"].ConvertObjectToString(),
                        ChequeDate = item["ChequeDate"].ConvertObjectToDateTimeWithNull(),
                        Narration = item["Narration"].ConvertObjectToString(),
                        Status = item["Status"].ConvertObjectToString(),
                        Transection_Ref_No = item["Transection_Ref_No"].ConvertObjectToString(),

                        LedgerName_From = item["LedgerName_From"].ConvertObjectToString(),
                        LedgerName_To = item["LedgerName_To"].ConvertObjectToString(),
                    });
                }
            }
            return lst;
        }


        /// <summary>
        /// Get View Of Transection View
        /// [_OthersWhareCauseQuery] allow [string.Empty]
        /// EX : Amount_Dr>=0
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_TransectionAttributes"></param>
        /// <param name="_AttributeValue"></param>
        /// <param name="_OthersWhareCauseQuery"></param>
        /// <returns></returns>
        public List<TransectionView> GetTransectionsView<T>(TransectionEnum._TransectionAttributes _TransectionAttributes, T _AttributeValue,string _OthersWhareCauseQuery)
        {
            //---get string from enum variable -----
            string strAttribute = _TransectionAttributes.GetEnumName();
            //Enum or not Check
            string _AttValue = _AttributeValue.IsEnumValue() ? _AttributeValue.GetEnumName() : _AttributeValue.ConvertObjectToString();

            //Object Type
            List<SqlParameter> ParamList = new List<SqlParameter>();
            List<TransectionView> lst = new List<TransectionView>();

            //query
            _OthersWhareCauseQuery = _OthersWhareCauseQuery.ISNullOrWhiteSpace() ? string.Empty : " and " + _OthersWhareCauseQuery;
            string query = " select * from TransectionView \r\n" +
                            "where " + strAttribute + "= @Value  " + _OthersWhareCauseQuery+
                            " ORDER BY id, Date, Transection_Ref_No";

            //Parameter
            ParamList.Add(new SqlParameter("@Value", _AttValue));

            //Source 
            SqlHelper.MParameterList = ParamList;

            //Execute Query
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {
                foreach (DataRow item in dt.Rows)
                {
                    lst.Add(new TransectionView
                    {
                        id = item["id"].ConvertObjectToLong(),
                        TransectionID = item["TransectionID"].ConvertToGuid(),
                        Date = item["Date"].ConvertObjectToDateTime(),
                        No = item["No"].ConvertObjectToString(),
                        TransectionType = item["TransectionType"].ConvertObjectToString(),
                        LedgerIdFrom = item["LedgerIdFrom"].ConvertToGuid(),
                        LedgerIdTo = item["LedgerIdTo"].ConvertToGuid(),
                        Amount_Dr = item["Amount_Dr"].ConvertObjectToDouble(),
                        Amount_Cr = item["Amount_Cr"].ConvertObjectToDouble(),
                        Mode = item["Mode"].ConvertObjectToString(),
                        BankName = item["BankName"].ConvertObjectToString(),
                        ChequeNo = item["ChequeNo"].ConvertObjectToString(),
                        ChequeDate = item["ChequeDate"].ConvertObjectToDateTimeWithNull(),
                        Narration = item["Narration"].ConvertObjectToString(),
                        Status = item["Status"].ConvertObjectToString(),
                        Transection_Ref_No = item["Transection_Ref_No"].ConvertObjectToString(),

                        LedgerName_From = item["LedgerName_From"].ConvertObjectToString(),
                        LedgerName_To = item["LedgerName_To"].ConvertObjectToString(),
                    });
                }
            }
            return lst;
        }
       
        #endregion
    }
}
