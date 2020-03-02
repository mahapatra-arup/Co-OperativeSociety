using BusinessEntities;
using SocietyDataAccess.Loans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SocietyBusinessAccess.Loans
{
    public class LoanTypeBA
    {
        LoantypesDA frmInsertLoanType = new LoantypesDA();

        #region ==============Loan Type===========
        public bool InsertLoanType(LoanType lty)
        {
            return frmInsertLoanType.InsertLoanType(lty);
        }
        /// <summary>
        /// Get Loan Types
        /// </summary>
        /// <returns></returns>
        public List<LoanType> GetLoanTypes()
        {
            return frmInsertLoanType.GetLoanTypes();
        }

        public bool IsLoanTypesExist(string typeName)
        {
            List<string> lts = GetLoanTypes().Select(p=>p.LoanTypeName).ToList();
           bool _IsLoanExistType = false;
            if (lts.IsValidList())
            {
                _IsLoanExistType = lts.AsEnumerable().Contains(typeName);
            }
            //MessageBox.Show(_IsLoanExistType.ToString());
            return _IsLoanExistType;
        }
        #endregion

        #region ================Loan Sub Type===============
        public bool InsertLoanSubType(LoanSubType lty)
        {
            return frmInsertLoanType.InsertLoanSubType(lty);
        }
        public List<LoanSubType> GetLoanSubTypes()
        {
            return frmInsertLoanType.GetLoanSubTypes();
        }

        /// <summary>
        /// Get LoanSubTypes Use Loan Type
        /// </summary>
        /// <param name="LoanTypeId"></param>
        /// <returns></returns>
        public List<LoanSubType> GetLoanSubTypes(int _LoanTypeId)
        {
            List<LoanSubType> lst = GetLoanSubTypes();
            IEnumerable<LoanSubType> lstType = null;
            if (lst.IsValidList())
            {
                lstType = from LoanSubType in lst
                          where LoanSubType.LoanTypeId ==_LoanTypeId
                          select LoanSubType;
            }
          return  lstType.ToList();
        }
        /// <summary>
        /// Get details of Loan Sub type Use by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LoanSubType GetLoanSubTypeDetailsById(int Id)
        {
            List<LoanSubType> lst = GetLoanSubTypes();
            IEnumerable<LoanSubType> lstType = null;
            if (lst.IsValidList())
            {
                lstType = from LoanSubType in lst
                          where LoanSubType.Id == Id
                          select LoanSubType;
            }
            return lstType.ToList().FirstOrDefault();
        }

        public bool IsLoanSubTypesExist(string _SubTypeName)
        {
            List<string> lts = GetLoanSubTypes().Select(p => p.SubTypeName).ToList();
            bool _IsLoanExistType = false;
            if (lts.IsValidList())
            {
                _IsLoanExistType = lts.AsEnumerable().Contains(_SubTypeName);
            }
            return _IsLoanExistType;
        }
        #endregion
    }
}
