using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Data;

namespace CoOperativeSociety
{
    public static class sysTools
    {
        /// <summary>
        /// Add Column of DataTable
        /// </summary>
        /// <param name="dgvcol"></param>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static DataTable AddDataTableColumns(this List<GetSetKeyAndValue<string, Type>> lst)
        {
            //Use proces :- List<GetSetKeyAndValue<string, Type>> lst = new List<GetSetKeyAndValue<string, Type>>();
            //lst.Add(new GetSetKeyAndValue<string, Type>() { Key = "CustomerId", Value = typeof(string) });

            DataTable _Dt = new DataTable();
            if (lst.IsValidList())
            {
                foreach (var item in lst)
                {
                    _Dt.Columns.Add(item.Key, item.Value);
                }
            }
            return _Dt;
        }
        /// <summary>
        /// Add Column of DataTable
        /// ||Create Defult [String] Column
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static void AddDataTableColumns(this DataTable _Dt, List<string> lst)
        {
            if (lst.IsValidList())
            {
                foreach (var item in lst)
                {
                    _Dt.Columns.Add(item, typeof(string));
                }
            }
        }

    }
}
