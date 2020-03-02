using BusinessEntities;
using SocietyDataAccess.Society;

namespace SocietyBusinessAccess.Society
{
    public class SocietyDetailsBA
    {
        SocietyDetailsDA frmSocietyDetailsDA = new SocietyDetailsDA();
       
        /// <summary>
        /// Insert Socity details
        /// </summary>
        /// <param name="frmSD"></param>
        /// <returns></returns>
        public bool InsertSocietyDetails(SocietyDetail frmSD)
        {
            return frmSocietyDetailsDA.InsertSocietyDetails(frmSD);
        }
        /// <summary>
        /// Update Socity Details
        /// </summary>
        /// <param name="frmSD"></param>
        /// <returns></returns>
        public bool UpdateSocietyDetails(SocietyDetail frmSD)
        {
            return frmSocietyDetailsDA.UpdateSocietyDetails(frmSD);
        }
        /// <summary>
        /// Get Socity Details
        /// </summary>
        /// <returns></returns>
        public SocietyDetail GetSocietyDetails()
        {
            return frmSocietyDetailsDA.GetSocietyDetails();
        }
    }
}
