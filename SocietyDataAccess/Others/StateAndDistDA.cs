using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;


namespace SocietyDataAccess.Others
{
    public class StateAndDistDA
    {
        public List<District> GetDistricts()
        {
            List<District> lstDistrict = new List<District>();
            string query = "Select * from Districts order by DistName";
            DataTable dtData = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dtData.IsValidDataTable())
            {
                foreach (DataRow item in dtData.Rows)
                {
                    int id = Convert.ToInt32(item["Id"]);
                    lstDistrict.Add(new District
                    {
                        Id = id,
                        DistName = item["DistName"].ToString(),
                        StateID = Convert.ToInt32(item["StateID"])
                    });
                }
            }
            return lstDistrict;
        }

        public List<State> GetState()
        {
            List<State> lstDistrict = new List<State>();
            string query = "Select * from State order by State";
            DataTable dtData = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dtData.IsValidDataTable())
            {
                foreach (DataRow item in dtData.Rows)
                {
                    int id = Convert.ToInt32(item["Id"]);
                    lstDistrict.Add(new State
                    {
                        ID = id,
                        State1 = Convert.ToString(item["State"])
                       
                    });
                }
            }
            return lstDistrict;
        }

        public List<District> GetDistricts(string StateID)
        {
            List<District> lstDistrict = new List<District>();
            string query = "Select * from Districts where StateID=@StateID";
            SqlHelper.SetParamiterWithValue("StateID", StateID);
            DataTable dtData = SqlHelper.GetInstance().ExcuteNonQuery(query);
            if (dtData.IsValidDataTable())
            {
                foreach (DataRow item in dtData.Rows)
                {
                    int id = Convert.ToInt32(item["Id"]);
                    lstDistrict.Add(new District
                    {
                        Id = id,
                        DistName = Convert.ToString(item["DistName"]),
                        StateID = Convert.ToInt32(item["StateID"])
                    });
                }
            }
            return lstDistrict;
        }
    }
}
