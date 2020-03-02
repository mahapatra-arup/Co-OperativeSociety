using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace SocietyDataAccess.Society
{
    public class SocietyDetailsDA
    {
        /// <summary>
        /// Insert Socity details
        /// </summary>
        /// <param name="frmSD"></param>
        /// <returns></returns>
        public bool InsertSocietyDetails(SocietyDetail frmSD)
        {
            List<SqlParameter> ParamList = new List<SqlParameter>();

            //Query
            string query = "INSERT INTO  SocietyDetails(SocietyName, At, PO, Block, SubDivission, PS, DIST, PIN, ESTD, Category, Ph, Email, Website, Logo, GP, CentreCode, Area, DistrictCode, RegistrationNo, GSTNo, PanNo) " +
            "VALUES(@SocietyName, @At, @PO, @Block, @SubDivission, @PS, @DIST, @PIN, @ESTD, @Category, @Ph, @Email, @Website, @Logo, @GP, @CentreCode, @Area, @DistrictCode, @RegistrationNo, @GSTNo, @PanNo)";

            #region ------------Sql Parameter--------

            ParamList.Add(new SqlParameter("@SocietyName", frmSD.SocietyName));
            ParamList.Add(new SqlParameter("@At", frmSD.At));
            ParamList.Add(new SqlParameter("@PO", frmSD.PO));
            ParamList.Add(new SqlParameter("@Block", frmSD.Block));
            ParamList.Add(new SqlParameter("@SubDivission", frmSD.SubDivission));
            ParamList.Add(new SqlParameter("@PS", frmSD.PS));
            ParamList.Add(new SqlParameter("@DIST", frmSD.DIST));

            ParamList.Add(new SqlParameter("@PIN", frmSD.PIN));
            ParamList.Add(new SqlParameter("@ESTD", frmSD.ESTD));
            ParamList.Add(new SqlParameter("@Category", frmSD.Category));
            ParamList.Add(new SqlParameter("@Ph", frmSD.Ph));
            ParamList.Add(new SqlParameter("@Email", frmSD.Email));
            ParamList.Add(new SqlParameter("@Website", frmSD.Website));
            ParamList.Add(new SqlParameter("@Logo", frmSD.Logo));
            ParamList.Add(new SqlParameter("@GP", frmSD.GP));

            ParamList.Add(new SqlParameter("@CentreCode", frmSD.CentreCode));
            ParamList.Add(new SqlParameter("@Area", frmSD.Area));
            ParamList.Add(new SqlParameter("@DistrictCode", frmSD.DistrictCode));

            ParamList.Add(new SqlParameter("@RegistrationNo", frmSD.RegistrationNo));
            ParamList.Add(new SqlParameter("@GSTNo", frmSD.GSTNo));
            ParamList.Add(new SqlParameter("@PanNo", frmSD.PanNo));
            #endregion

            //Fill Sql Parameter
            SqlHelper.MParameterList = ParamList;

            //Execute
            if (SqlHelper.GetInstance().ExcuteQuery(query))
            {
                return true;
            }
            return false;

        }

        public bool UpdateSocietyDetails(SocietyDetail frmSD)
        {
            List<SqlParameter> ParamList = new List<SqlParameter>();

            //Query
            string query = "Update SocietyDetails set SocietyName=@SocietyName, At=@At, PO=@PO, Block=@Block, SubDivission=@SubDivission, "+
                "PS=@PS, DIST=@DIST, PIN=@PIN, ESTD=@ESTD, Category=@Category, Ph=@Ph, Email=@Email, Website=@Website, Logo=@Logo, GP=@GP, CentreCode=@CentreCode, Area=@Area,  "+
            "DistrictCode=@DistrictCode, RegistrationNo=@RegistrationNo, GSTNo=@GSTNo, PanNo=@PanNo";
            #region ------------Sql Parameter--------

            ParamList.Add(new SqlParameter("@SocietyName", frmSD.SocietyName));
            ParamList.Add(new SqlParameter("@At", frmSD.At));
            ParamList.Add(new SqlParameter("@PO", frmSD.PO));
            ParamList.Add(new SqlParameter("@Block", frmSD.Block));
            ParamList.Add(new SqlParameter("@SubDivission", frmSD.SubDivission));
            ParamList.Add(new SqlParameter("@PS", frmSD.PS));
            ParamList.Add(new SqlParameter("@DIST", frmSD.DIST));

            ParamList.Add(new SqlParameter("@PIN", frmSD.PIN));
            ParamList.Add(new SqlParameter("@ESTD", frmSD.ESTD));
            ParamList.Add(new SqlParameter("@Category", frmSD.Category));
            ParamList.Add(new SqlParameter("@Ph", frmSD.Ph));
            ParamList.Add(new SqlParameter("@Email", frmSD.Email));
            ParamList.Add(new SqlParameter("@Website", frmSD.Website));
            ParamList.Add(new SqlParameter("@Logo", frmSD.Logo));
            ParamList.Add(new SqlParameter("@GP", frmSD.GP));

            ParamList.Add(new SqlParameter("@CentreCode", frmSD.CentreCode));
            ParamList.Add(new SqlParameter("@Area", frmSD.Area));
            ParamList.Add(new SqlParameter("@DistrictCode", frmSD.DistrictCode));

            ParamList.Add(new SqlParameter("@RegistrationNo", frmSD.RegistrationNo));
            ParamList.Add(new SqlParameter("@GSTNo", frmSD.GSTNo));
            ParamList.Add(new SqlParameter("@PanNo", frmSD.PanNo));
            #endregion

            //Fill Sql Parameter
            SqlHelper.MParameterList = ParamList;

            //Execute
            if (SqlHelper.GetInstance().ExcuteQuery(query))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get Socity Details
        /// </summary>
        /// <returns></returns>
        public SocietyDetail GetSocietyDetails()
        {
            List<SqlParameter> ParamList = new List<SqlParameter>();
            SocietyDetail frmSocietyDetail = new SocietyDetail();

            //Query
            string query = "Select * from SocietyDetails";

            //Execute
            DataTable dt = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dt.IsValidDataTable())
            {

                frmSocietyDetail.SocietyName = Convert.ToString(dt.Rows[0]["SocietyName"]);
                frmSocietyDetail.At = Convert.ToString(dt.Rows[0]["At"]);
                frmSocietyDetail.PO = Convert.ToString(dt.Rows[0]["PO"]);
                     frmSocietyDetail.Block = Convert.ToString(dt.Rows[0]["Block"]);
                     frmSocietyDetail.SubDivission = Convert.ToString(dt.Rows[0]["SubDivission"]);
                frmSocietyDetail.PS = Convert.ToString(dt.Rows[0]["PS"]);
                frmSocietyDetail.DIST = Convert.ToString(dt.Rows[0]["DIST"]);
                    frmSocietyDetail.PIN = Convert.ToString(dt.Rows[0]["PIN"]);
                frmSocietyDetail.ESTD = Convert.ToString(dt.Rows[0]["ESTD"]);
                frmSocietyDetail.Category = Convert.ToString(dt.Rows[0]["Category"]);
                frmSocietyDetail.Ph = Convert.ToString(dt.Rows[0]["Ph"]);
                    frmSocietyDetail.Email = Convert.ToString(dt.Rows[0]["Email"]);
                frmSocietyDetail.Website = Convert.ToString(dt.Rows[0]["Website"]);

                frmSocietyDetail.GP = Convert.ToString(dt.Rows[0]["GP"]);
                frmSocietyDetail.CentreCode = Convert.ToString(dt.Rows[0]["CentreCode"]);
                frmSocietyDetail.Area = Convert.ToString(dt.Rows[0]["Area"]);
                frmSocietyDetail.DistrictCode = Convert.ToString(dt.Rows[0]["DistrictCode"]);
                frmSocietyDetail.RegistrationNo = Convert.ToString(dt.Rows[0]["RegistrationNo"]);
                frmSocietyDetail.GSTNo = Convert.ToString(dt.Rows[0]["GSTNo"]);
                frmSocietyDetail.PanNo = Convert.ToString(dt.Rows[0]["PanNo"]);
               
                //Image
              object log = dt.Rows[0]["Logo"];
                if (log.ISValidObject())
                {
                    frmSocietyDetail.Logo = (byte[])log;
                }
            }
            return frmSocietyDetail;
        }
    }
}
