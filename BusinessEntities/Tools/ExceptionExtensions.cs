using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessEntities
{
    public static class ExceptionExtensions
    {
        /// <summary>
        ///  Provides full stack trace for the exception that occurred.
        /// </summary>
        /// <param name="exception">Exception object.</param>
        /// <param name="environmentStackTrace">Environment stack trace, for pulling additional stack frames.</param>
        /// 
        public static string ToWriteLog(this Exception exception, string environmentStackTrace,string _OthersError)
        {
           
            //================Stack Trace=======================
            List<string> stackTraceLines = ExceptionExtensions.GetStackTraceLines(exception.StackTrace);
            string _StackTrace = String.Join(Environment.NewLine, stackTraceLines);

            //============environmentStackTraceLines=============
            List<string> environmentStackTraceLines = ExceptionExtensions.GetUserStackTraceLines(environmentStackTrace);
            string _environmentStackTrace = String.Join(Environment.NewLine, environmentStackTraceLines);



            //=============Log Design=============
            StringBuilder strLog = new StringBuilder();

            strLog.Append("==============================================  || "+ DateTime.Now.ToString() + " || ==========================================");
            strLog.Append(Environment.NewLine);
            strLog.Append(string.Format(" Message:-- {0}", exception.Message));
            strLog.Append(Environment.NewLine);

            strLog.Append("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
            strLog.Append(Environment.NewLine);
            strLog.Append(string.Format("Environment Stack Trace :-- {0}", _environmentStackTrace));
            strLog.Append(Environment.NewLine);

            strLog.Append("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
            strLog.Append(Environment.NewLine);
            strLog.Append(string.Format(" Stack Trace :-- {0}", _StackTrace));
            strLog.Append(Environment.NewLine);

            //====================Others Error============
            strLog.Append(_OthersError);
            strLog.Append(Environment.NewLine);
            strLog.Append(Environment.NewLine);

            strLog.Append("=========================================================|| End ||========================================================");
            strLog.Append(Environment.NewLine);
            strLog.Append(Environment.NewLine);


            //=====================Write log==============
            ApplicationLogs.WriteAppsErrorLog(strLog.ToString());

            //==Return Current Log-==
            return strLog.ToString();
        }

        /// <summary>
        ///  Gets a list of stack frame lines, as strings.
        /// </summary>
        /// <param name="stackTrace">Stack trace string.</param>
        private static List<string> GetStackTraceLines(string stackTrace)
        {
            return stackTrace.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }

        /// <summary>
        ///  Gets a list of stack frame lines, as strings, only including those for which line number is known.
        /// </summary>
        /// <param name="fullStackTrace">Full stack trace, including external code.</param>
        private static List<string> GetUserStackTraceLines(string fullStackTrace)
        {
            List<string> outputList = new List<string>();
            Regex regex = new Regex(@"([^\)]*\)) in (.*):line (\d)*$");

            List<string> stackTraceLines = ExceptionExtensions.GetStackTraceLines(fullStackTrace);
            foreach (string stackTraceLine in stackTraceLines)
            {
                if (!regex.IsMatch(stackTraceLine))
                {
                    continue;
                }

                outputList.Add(stackTraceLine);
            }

            return outputList;
        }
    }
}