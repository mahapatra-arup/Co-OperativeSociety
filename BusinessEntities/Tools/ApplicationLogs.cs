using System;
using System.Windows.Forms;

namespace BusinessEntities
{
    public static class ApplicationLogs
    {
        private static int _ErrorCount;
        public static void WriteAppsErrorLog(string logline)
        {
            string strErrorText = "";
            string strFileName = "AppsLog.txt";
            string strPath = Application.StartupPath;
            try
            {
                if (_ErrorCount == 0)//first time work
                {
                    if (System.IO.File.Exists(strPath + "\\" + strFileName))
                    {
                        System.IO.File.Delete(strPath + "\\" + strFileName);
                    }
                }

                strErrorText = logline;
                System.IO.File.AppendAllText(strPath + "\\" + strFileName, strErrorText);
                _ErrorCount++;
            }
            catch (Exception)
            {

            }
        }

        public static string[] ReadErrorLog()
        {
            string strFileName = "AppsLog.txt";
            string strPath = Application.StartupPath + "\\" + strFileName;
            string[] lines = null;

            if (System.IO.File.Exists(strPath))
            {
                if (_ErrorCount <= 0)
                {
                    System.IO.File.Delete(strPath);
                    System.IO.File.AppendAllText(strPath, "No Error Found");
                }
                lines = System.IO.File.ReadAllLines(strPath);
            }

            return lines;
        }
    }
}
