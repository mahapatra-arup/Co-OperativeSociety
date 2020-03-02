using BusinessEntities;
using BusinessEntities._enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Data.SqlClient;
using System.ComponentModel;
using SocietyDataAccess.Ledgers;

namespace SocietyBusinessAccess.Ledgers
{
    public class LedgerBA
    {
        LedgerDA frmLedgerDA = new LedgerDA();

        #region ==================================Ledger================================
        /// <summary>
        /// ///---- Get Ledger By Attribute(Column) and Attribute Value----
        /// </summary>
        /// <param name="_ledgerattrb"></param>
        /// <param name="_AttributeValue"></param>
        /// <returns></returns>
        public List<Ledger> GetLedger<T>(LedgerEnum._LedgerAttributes _ledgerattrb, T _AttributeValue)
        {
            return frmLedgerDA.GetLedger(_ledgerattrb, _AttributeValue);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_ledgerattrb"></param>
        /// <param name="_lstAttributeValues"></param>
        /// <returns></returns>
        public List<Ledger> GetLedger<T>(LedgerEnum._LedgerAttributes _ledgerattrb, List<T> _lstAttributeValues)
        {
            return frmLedgerDA.GetLedger(_ledgerattrb, _lstAttributeValues);
        }

        /// <summary>
        /// ///---- Get Ledger----
        /// </summary>
        /// <param name="_ledgerattrb"></param>
        /// <param name="_AttributeValue"></param>
        /// <returns></returns>
        public List<Ledger> GetLedger()
        {
            return frmLedgerDA.GetLedger();
        }

        /// <summary>
        /// ///---- Get Ledger by Parent Ledger Id----
        /// </summary>
        /// <param name="_parentLedgerId"></param>
        /// <param name="_ledgerattrb"></param>
        /// <param name="_lstAttributeValues"></param>
        /// <returns></returns>
        public IEnumerable<Ledger> GetLedgersByParent(Guid _parentLedgerId,
            [Description("Column Name of Ledger table")]
            LedgerEnum._LedgerAttributes _ledgerattrb,
            [Description("Column value")]
            List<LedgerEnum._LedgerCategoryValues> _lstAttributeValues)
        {
            //Get All  Details
            List<Ledger> lstLedger = GetLedger(_ledgerattrb, _lstAttributeValues);
            IEnumerable<Ledger> _lstLedger001 = null;
            if (lstLedger.IsValidList())
            {
                //Find year Use Id and use <Linq> process
                _lstLedger001 = from Ledger in lstLedger
                                where Ledger.ParentLedgerId == _parentLedgerId
                                select Ledger;
            }
            return _lstLedger001;
        }

        /// <summary>
        /// Get Ledger Details Use By LedgerName
        /// </summary>
        /// <param name="_parentLedgerId"></param>
        /// <returns></returns>
        public Ledger GetLedger(LedgerEnum._FixedLedgerName enumledger_Name)
        {
            //Get Enum Description

            string _LedgerName = enumledger_Name.GetDisplayName();

            //Get All Year Details
            List<Ledger> lstLedger = frmLedgerDA.GetLedger();
            IEnumerable<Ledger> _lstLedger001 = null;

            if (lstLedger.IsValidList())
            {
                //Find year Use Id and use <Linq> process
                _lstLedger001 = from Ledger in lstLedger
                                where Ledger.LedgerName.ToLower() == _LedgerName.ToLower()
                                select Ledger;
            }

            return _lstLedger001.FirstOrDefault();
        }


        /// <summary>
        /// Get Ledger Of Customer
        /// </summary>
        /// <param name="_customerLedgerId"></param>
        /// <returns></returns>
        public List<Ledger> GetLedgerofCustomer(string _customerLedgerId)
        {
            return frmLedgerDA.GetLedgerofCustomer(_customerLedgerId);
        }

        /// <summary>
        /// Get Loan Ledger  and Saving A/C Ledger of Customer
        /// </summary>
        /// <param name="_customerLedgerId"></param>
        /// <param name="_LoanACLedgerId"></param>
        /// <param name="_SavingACLedgerId"></param>
        public void GetLedgerofCustomer(string _customerLedgerId, out string _LoanACLedgerId, out string _SavingACLedgerId)
        {
            //Out
            _LoanACLedgerId = null;
            _SavingACLedgerId = null;

            //Object type
            IEnumerable<Guid> _lstLoanAC = null;
            IEnumerable<Guid> _lstSavingAC = null;

            //Get
            List<Ledger> lstmain = frmLedgerDA.GetLedgerofCustomer(_customerLedgerId);

            //Logical process
            if (lstmain.ISValidObject())
            {
                //====Customer Loan Account LedgerId=======
                _lstLoanAC = from Ledger in lstmain
                             where Ledger.Category == LedgerEnum._LedgerCategoryValues.Customer_Loan_AC.GetEnumName()
                             select Ledger.LedgerId;
                //Fill
                _LoanACLedgerId = _lstLoanAC.FirstOrDefault().ConvertObjectToString();

                //=======Customer saving Account LedgerId=========
                _lstSavingAC = from Ledger in lstmain
                               where Ledger.Category == LedgerEnum._LedgerCategoryValues.Customer_Saving_AC.GetEnumName()
                               select Ledger.LedgerId;

                //Fill
                _SavingACLedgerId = _lstSavingAC.FirstOrDefault().ConvertObjectToString();

            }
        }

        /// <summary>
        /// Get Ledgers By Ledger Name
        /// </summary>
        /// <param name="_LedgerName"></param>
        /// <returns></returns>
        public Ledger GetLedgers(string _LedgerName)
        {
            //Get All Year Details
            List<Ledger> lstLedger = frmLedgerDA.GetLedger();
            IEnumerable<Ledger> _lstLedger001 = null;

            if (lstLedger.IsValidList())
            {
                //Find year Use Id and use <Linq> process
                _lstLedger001 = from Ledger in lstLedger
                                where Ledger.LedgerName.ToLower() == _LedgerName.ToLower()
                                select Ledger;
            }

            return _lstLedger001.FirstOrDefault();
        }

        #endregion

        #region ==================================Ledger Bank Details===================
        /// <summary>
        /// Insert Ledgers Wint Ledger bank Details Ans Ledger Status
        /// (if any class null Then this table are not Insert)
        /// </summary>
        /// <param name="frmLedger"></param>
        /// <param name="frmLedgerBD"></param>
        /// <param name="IsInsertBankDetails"></param>
        /// <returns></returns>
        public bool InsertLedgerWithBankAndStatus(List<Ledger> frmLedger, List<LedgerBankDetail> frmLedgerBD, List<LedgersStatu> frmledgersStatu)
        {
            return frmLedgerDA.InsertLedgerWithBankAndStatus(frmLedger, frmLedgerBD, frmledgersStatu);
        }

        public List<LedgerBankDetail> GetLedgerBankDetails()
        {
            return frmLedgerDA.GetLedgerBankDetails();
        }

        /// <summary>
        /// Get Ledger bankDetails Use By
        /// </summary>
        /// <param name="_bankId"></param>
        /// <returns></returns>
        public IEnumerable<LedgerBankDetail> GetLedgerBankDetails(int _bankId)
        {
            //Get All Year Details
            List<LedgerBankDetail> lstLedger = frmLedgerDA.GetLedgerBankDetails();
            IEnumerable<LedgerBankDetail> _lstLedger001 = null;
            if (lstLedger.IsValidList())
            {
                //Find year Use Id and use <Linq> process
                _lstLedger001 = from LedgerBankDetail in lstLedger
                                where LedgerBankDetail.BankID == _bankId
                                select LedgerBankDetail;
            }
            return _lstLedger001;
        }

        /// <summary>
        /// Get Socity Bank Sub Account Use By Category
        /// </summary>
        /// <param name="_CategoryValue"></param>
        /// <returns></returns>
        public string GetSocityBankSubACByCategory(string _CategoryValue)
        {
            string enm = string.Empty;
            if (_CategoryValue == LedgerEnum._LedgerCategoryValues.Society_Loan_AC.GetEnumName())
            {
                enm = LedgerEnum._LedgerSubAccount.Loans_Liability.GetDisplayName();
            }
            else
            {
                //Saving Or current
                enm = LedgerEnum._LedgerSubAccount.Current_Assets.GetDisplayName();
            }
            return enm;
        }


        /// <summary>
        /// Check Already Exist Bank use [BankId] And [Account Type]
        /// Like : Saving_Ac/Current_AC/Loan_Ac Bank isPresent In this bank id or not
        /// </summary>
        /// <param name="_bankid"></param>
        /// <returns></returns>
        public bool AlredyExistBankByCategry(int _bankid, LedgerEnum._LedgerCategoryValues _AccountType)
        {
            List<LedgerBankDetail> existbank = null;
            var bankledgers = GetLedgerBankDetails(_bankid);

            //var existbank;
            if (bankledgers.ISValidIEnumerableList())
            {
                //Query in Process
                existbank = bankledgers.
               Where(acType => acType.ACType== _AccountType.GetEnumName()).ToList();
            }

            if (existbank.IsValidList())
            {
                return true;
            }
            return false;
        }
        #endregion

        #region ==================================LesgerStatus==========================
       
        #endregion
    }
}
