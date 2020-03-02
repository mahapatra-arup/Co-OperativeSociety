using BusinessEntities;
using SocietyDataAccess.Others;
using System.Collections.Generic;

namespace SocietyBusinessAccess.Others
{
 public  class BankDetailsBA
    {
        BankDetailsDA bankDetailsDA = new BankDetailsDA();
        public List<Bank> GetBanksName()
        {
            return bankDetailsDA.GetBanksName();
        }
    }
}
