using BusinessEntities;
using SocietyBusinessAccess.Society;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoOperativeSociety.Tools.ProjectTools
{
    public class DefultClass
    {
        public static  SocietyDetailsBA _cSocietyDetailBA = new SocietyDetailsBA();
        public DefultClass()
        {
            FillSocityDetails();
        }

        public static void FillSocityDetails()
        {
           SocietyDetail sd = _cSocietyDetailBA.GetSocietyDetails();
            if (sd.ISValidObject())
            {
                SocityUtils.SocietyName = sd.SocietyName;
                SocityUtils.At = sd.At;
                SocityUtils.PO = sd.PO;
                SocityUtils.Block = sd.Block;
                SocityUtils.SubDivission = sd.SubDivission;
                SocityUtils.PS = sd.PS;
                SocityUtils.DIST = sd.DIST;
                SocityUtils.PIN = sd.PIN;
                SocityUtils.ESTD = sd.ESTD;
                SocityUtils.Category = sd.Category;
                SocityUtils.Ph = sd.Ph;
                SocityUtils.Email = sd.Email;
                SocityUtils.Website = sd.Website;
                SocityUtils.Logo = sd.Logo;
                SocityUtils.GP = sd.GP;
                SocityUtils.CentreCode = sd.CentreCode;
                SocityUtils.Area = sd.Area;
                SocityUtils.DistrictCode = sd.DistrictCode;
                SocityUtils.RegistrationNo = sd.RegistrationNo;
                SocityUtils.GSTNo = sd.GSTNo;
                SocityUtils.PanNo = sd.PanNo;
            }
        }

      
    }
}
