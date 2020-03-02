using BusinessEntities;
using SocietyDataAccess.Others;
using System.Collections.Generic;


namespace SocietyBusinessAccess.Others
{
    public class StateAndDistBA
    {
        StateAndDistDA frmStateAndDistDA = new StateAndDistDA();
        /// <summary>
        /// Get District Details
        /// </summary>
        /// <returns></returns>
        public List<District> GetDistricts()
        {
            return frmStateAndDistDA.GetDistricts();
        }
        /// <summary>
        /// Get District Details use by StateId
        /// </summary>
        /// <param name="_StateId"></param>
        /// <returns></returns>
        public List<District> GetDistricts(string _StateId)
        {
            return frmStateAndDistDA.GetDistricts(_StateId);
        }
        /// <summary>
        /// Get State Details
        /// </summary>
        /// <returns></returns>
        public List<State> GetState()
        {
            return frmStateAndDistDA.GetState();
        }
    }
}
