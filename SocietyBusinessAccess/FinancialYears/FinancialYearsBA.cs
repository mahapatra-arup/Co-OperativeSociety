using BusinessEntities;
using SocietyDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocietyBusinessAccess.FinancialYears
{
    public class FinancialYearsBA
    {
        FinancialYearDA financialYearDA = new FinancialYearDA();

        /// <summary>
        /// Insert Financial Year
        /// </summary>
        /// <param name="fn"></param>
        /// <returns></returns>
        public bool InsertFinancialYear(FinancialYear fn)
        {
            return financialYearDA.InsertFinancialYear(fn);
        }
        /// <summary>
        /// Update Financial Year
        /// </summary>
        /// <param name="fn"></param>
        /// <returns></returns>
        public bool UpdateFinancialYear(FinancialYear fn)
        {
            return financialYearDA.UpdateFinancialYear(fn);
        }
        /// <summary>
        /// Update Financial Current Year
        /// </summary>
        /// <param name="FinancialYearName"></param>
        /// <param name="IsCurentyear"></param>
        /// <returns></returns>
        public bool UpdateFinancialCurrentYear(object FinancialYearName, bool IsCurentyear)
        {
            return financialYearDA.UpdateFinancialCurrentYear( FinancialYearName,  IsCurentyear);
        }
        /// <summary>
        /// Retrive Financial Year Details
        /// </summary>
        /// <returns></returns>
        public List<FinancialYear> GetFinancialYearDetails()
        {
            return financialYearDA.GetFinancialYearDetails();
        }

        public IEnumerable<FinancialYear> GetFinancialYearDetails(int id)
        {
            //Get All Year Details
            List<FinancialYear> lstFinancialYear = GetFinancialYearDetails();
            IEnumerable<FinancialYear> _lstYear = null;
            if (lstFinancialYear.IsValidList())
            {
                //Find year Use Id and use <Linq> process
                 _lstYear = from FinancialYear in lstFinancialYear
                                                      where FinancialYear.ID == id
                                                      select FinancialYear;
            }
            return _lstYear;
        }

        public IEnumerable<FinancialYear> GetFinancialYearDetails(string _finName)
        {
            //Get All Year Details
            List<FinancialYear> lstFinancialYear = GetFinancialYearDetails();

            IEnumerable<FinancialYear> _lstYear = null;
            if (lstFinancialYear.IsValidList())
            {
                //Find year Use Id and use <Linq> process
                _lstYear = from FinancialYear in lstFinancialYear
                           where FinancialYear.FinancialYearName == _finName
                           select FinancialYear; 
            }

            return _lstYear;
        }
    }
}
