using BusinessEntities;
using BusinessEntities._enum;
using SocietyDataAccess.Ledgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SocietyBusinessAccess.Ledgers
{
    public class SubAccountBA
    {
        SubAccountDA subAccountDA = new SubAccountDA();
        public List<LedgerSubAccount> GetSubAccount()
        {
            return subAccountDA.GetSubAccount();
        }

        
    }
}
