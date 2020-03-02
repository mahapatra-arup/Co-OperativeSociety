using BusinessEntities;
using BusinessEntities._enum;
using SocietyDataAccess.Transections;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SocietyBusinessAccess.Transections
{
    public class TransectionBA
    {
        TransectionDA transectionDA = new TransectionDA();

        #region ================TranSection=============================

        public bool InsertDataOfTransection(List<Transection> lstOfTransection)
        {
            return transectionDA.InsertDataOfTransection(lstOfTransection);
        }

        /// <summary>
        /// Get transection details
        /// </summary>
        /// <returns></returns>
        public List<Transection> GetTransections()
        {
            return transectionDA.GetTransections();
        }


        #region ==========================Bool============================
        /// <summary>
        /// Transection_Ref_No Is Exist Then True
        /// </summary>
        /// <param name="_Transection_Ref_No"></param>
        /// <returns></returns>
        public bool IsExistTransection_Ref_No(string _Transection_Ref_No)
        {
            //Get
            var lstTran = GetTransections();
            //Query
            var trn001 = (from Transection in lstTran
                          where Transection.Transection_Ref_No == _Transection_Ref_No
                          select Transection);
            if (trn001.ISValidIEnumerableList())
            {
                return true;
            }
            return false;
        }

        #endregion

        #region ===========================Generate ======================
        /// <summary>
        /// Generate Max Expence No Of Transection 
        /// </summary>
        /// <returns></returns>
        public int GenerateExpenseNoOfTransection()
        {
            int no = 0;

            //Get
            var lstTran = GetTransections();

            if (!lstTran.ISValidObject())
            {
                return (1);
            }

            //Query
            var trn001 = (from Transection in lstTran
                          where Transection.TransectionType == (TransectionEnum._TransectionTypeValues.Expense.GetEnumName())
                          select Transection.No);

            if (trn001.ISValidIEnumerableList())
            {
                no = trn001.Select(s => s.ConvertObjectToInt()).Max();
            }
            return (no + 1);
        }

        /// <summary>
        /// Generate Max Income No Of Transection 
        /// </summary>
        /// <returns></returns>
        public int GenerateIncomeNoOfTransection()
        {
            int no = 0;

            //Get
            var lstTran = GetTransections();

            if (!lstTran.ISValidObject())
            {
                return (1);
            }

            //Query
            var trn001 = (from Transection in lstTran
                          where Transection.TransectionType == (TransectionEnum._TransectionTypeValues.Income.GetEnumName())
                          select Transection.No);

            if (trn001.ISValidIEnumerableList())
            {
                no = trn001.Select(s => s.ConvertObjectToInt()).Max();
            }
            return (no + 1);
        }

        /// <summary>
        /// Generate Transection reference No
        /// </summary>
        /// <returns></returns>
        public string GenerateTransectionsRefNo()
        {
            string refString ="TRN";
            int maxRefno = 0;

            //Get
            var lstTran = GetTransections();

            if (!lstTran.ISValidObject())
            {
                return (refString + 1);
            }

            var trn001 = (from Transection in lstTran
                          select Transection.Transection_Ref_No).ToList();
            if (trn001.IsValidList())
            {
                maxRefno = trn001.Select(str => str.Replace(refString, "").ConvertObjectToInt()).Max();
            }
            maxRefno = maxRefno + 1;
            return (refString + maxRefno);
        }
        #endregion
        #endregion

        #region =========Transection View================================
        /// <summary>
        /// Get View Of Transection View
        /// </summary>
        /// <returns></returns>
        public List<TransectionView> GetTransectionsView()
        {
            return transectionDA.GetTransectionsView();
        }

        /// <summary>
        /// Get View Of Transection View
        /// [_OthersWhareCauseQuery] allow [string.Empty]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_TransectionAttributes"></param>
        /// <param name="_AttributeValue"></param>
        /// <param name="_OthersWhareCauseQuery"></param>
        /// <returns></returns>

        public List<TransectionView> GetTransectionsView<T>(TransectionEnum._TransectionAttributes _TransectionAttributes, T _AttributeValue, string _OthersWhareCauseQuery)
        {
            return transectionDA.GetTransectionsView(_TransectionAttributes, _AttributeValue, _OthersWhareCauseQuery);
        }
       /// <summary>
       /// Get Transection Of TransectionView
       /// </summary>
       /// <typeparam name="T"></typeparam>
       /// <param name="_TransectionAttributes"></param>
       /// <param name="_AttributeValue"></param>
       /// <param name="_dateFrom"></param>
       /// <param name="_dateTo"></param>
       /// <param name="_OthersWhareCauseQuery"></param>
       /// <returns></returns>
        public List<TransectionView> GetTransectionsView<T>(TransectionEnum._TransectionAttributes _TransectionAttributes, T _AttributeValue,DateTime _dateFrom ,DateTime _dateTo, string _OthersWhareCauseQuery)
        {
            //Get
            List<TransectionView> lst = GetTransectionsView(_TransectionAttributes, _AttributeValue, _OthersWhareCauseQuery);
          
            //Query
            var trn001 = from TransectionView in lst
                         where (TransectionView.Date.Date>=_dateFrom.Date && TransectionView.Date.Date <= _dateTo.Date)
                         select TransectionView;

            return trn001.ToList();
        }
       
        #endregion
    }
}
