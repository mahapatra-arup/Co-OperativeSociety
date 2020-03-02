using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection;

namespace BusinessEntities
{

    public static class AppsTools
    {
        public static string GetDBFormatDate(DateTime date)
        {
            try
            {
                string dateStr = String.Empty;
                dateStr = date.ToString("dd-MMM-yyyy");
                return dateStr;
            }
            catch (Exception)
            {

            }
            return null;

        }

        public static bool IsNimeric(string txt, char c)
        {
            if (c == '\b')
            {
                return true;
            }
            else if (char.IsWhiteSpace(c))
            {
                return false;
            }
            else
            {
                try
                {
                    double dbl = Double.Parse(txt);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

        }

        public static List<string> GetListFromDataTbale(DataTable dataTable)
        {

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                List<string> lst = new List<string>();
                foreach (DataRow dr in dataTable.Rows)
                {
                    string val = dr[0].ToString();
                    lst.Add(val);
                }
                return lst;
            }
            return null;
        }

        public static int GetIdByValue(Dictionary<int, string> dic, string value)
        {
            int key = 0;
            foreach (var entry in dic)
            {
                if (entry.Value.Equals(value))
                {
                    key = entry.Key;
                }

            }
            return key;

        }
    }

    public static class StringExtenssion
    {

        public static string GetDBFormatString(this string strVal)
        {
            if (!strVal.ISNullOrWhiteSpace())
            {
                strVal = strVal.Replace("'", "''");
                strVal = strVal.Replace("\"", "\"\"");
            }

            return strVal;
        }

        public static bool ISNullOrWhiteSpace(this string strVal)
        {

            if (strVal == null || string.IsNullOrEmpty(strVal.Trim()))
            {
                return true;
            }

            return false;
        }
    }

    public static class DataTableExtension
    {
        public static bool IsValidDataTable(this DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsValidList<T>(this List<T> lst)
        {
            if (lst != null && lst.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static bool ISValidObject(this object o)
        {
            if (o != null && o != DBNull.Value)
            {
                if (!o.ToString().ISNullOrWhiteSpace())
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ISValidIEnumerableList<T>(this IEnumerable<T> o)
        {
            if (o != null && o.Count() > 0)
            {
                if (!o.ToString().ISNullOrWhiteSpace())
                {
                    return true;
                }
            }

            return false;
        }

    }

    public static class DictionaryExtention
    {
        public static bool IsNullOrEmpty<T, U>(this IDictionary<T, U> Dictionary)
        {
            return (Dictionary == null || Dictionary.Count < 1);
        }
    }

    public static class DataViewExtention
    {
        public static bool IsValidDataView(this DataView dtView)
        {
            if (dtView != null && dtView.Count > 0)
            {
                return true;
            }
            return false;
        }
    }


    /// <summary>
    /// =-===Convert Method=====
    /// </summary>
    public static class ConvertExtension
    {
        public static object ConvertNullEmptyToZero(this string value)
        {
            object obj = value.ISNullOrWhiteSpace() ? "0" : value;
            return obj;
        }
        public static object ConvertDBNullTONull(this object value)
        {
            object obj = value.ISValidObject() ? value : null;
            return obj;
        }

        public static object ConvertNullToDBNull(this object value)
        {
            object obj = value.ISValidObject() ? value : DBNull.Value;
            return obj;
        }
        public static string ConvertObjectToString(this object value)
        {
            string obj = string.Empty;
            if (value.ISValidObject())
            {
                obj = value.ToString();
            }
            return obj;
        }
        public static double ConvertObjectToDouble(this object value)
        {
            double obj = 0;
            double.TryParse(value.ConvertObjectToString(), out obj);
            return obj;
        }

        public static Guid? ConvertObjectToGuid(this object value)
        {
            Guid? obj = null;
            try
            {
                obj = Guid.Parse(value.ConvertObjectToString());
            }
            catch (Exception)
            {
                obj = null;
            }
            return obj;
        }

        public static Guid ConvertToGuid(this object value)
        {
            Guid obj = new Guid();
            try
            {
                obj = Guid.Parse(value.ConvertObjectToString());
            }
            catch (Exception e)
            {
                throw e;
            }
            return obj;
        }
        public static int ConvertObjectToInt(this object value)
        {
            int obj = 0;
            int.TryParse(value.ConvertObjectToString(), out obj);
            return obj;
        }
        public static long ConvertObjectToLong(this object value)
        {
            long obj = 0;
            long.TryParse(value.ConvertObjectToString(), out obj);
            return obj;
        }
        /// <summary>
        ///  object is null then  datetime is MinValue
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime ConvertObjectToDateTime(this object value)
        {
            DateTime obj = DateTime.MinValue;
            DateTime.TryParse(value.ConvertObjectToString(), out obj);
            return obj;
        }
        /// <summary>
        /// Convert Object To DateTime
        /// return DateTime/null
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DateTime? ConvertObjectToDateTimeWithNull(this object value)
        {
            DateTime? obj = null;
            try
            {
                obj = DateTime.Parse(value.ConvertObjectToString());
            }
            catch (Exception)
            {
                obj = null;
            }
            return obj;
        }
        /// <summary>
        ///  object is null then  bool is false
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ConvertObjectToBool(this object value)
        {
            bool obj = false;
            bool.TryParse(value.ConvertObjectToString(), out obj);
            return obj;
        }

        /// <summary>
        /// Convert To Datatable From List 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public static void ToDataTable<T>(this DataTable dataTable, List<T> items)
        {
             dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Defining type of data column gives proper data table 
                var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name, type);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
        }
    }

    public static class EnumExtension
    {
        public static string GetEnumName<T>(this T enumval)
        {
            string strAttribute = string.Empty;
            if (enumval.IsEnumValue())
            {
                strAttribute = Enum.GetName(typeof(T), enumval);
            }
            else
            {
                throw new InvalidCastException("The specified object is not an enum.");
            }
            return strAttribute;
        }
        /// <summary>
        /// Get Enum Display Name
        /// like [Display(Name="Get This")]
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue
                .GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                .GetName();
        }
        /// <summary>
        /// Value Is Enum Type Or Not
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static bool IsEnumValue<T>(this T enumValue)
        {
            if (typeof(T).BaseType != typeof(Enum))
            {
                return false;
                // throw new InvalidCastException("The specified object is not an enum.");
            }
            return true;
        }

    }
}
