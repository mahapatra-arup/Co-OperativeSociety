using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoOperativeSociety
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // Starts the application. 
        [STAThread]
        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
        static void Main()
        {

            // Add the event handler for handling UI thread exceptions to the event.
           // Application.ThreadException += new ThreadExceptionEventHandler(Form1_UIThreadException);

            // Set the unhandled exception mode to force all Windows Forms errors to go through
            // our handler.
           // Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
           // AppDomain.CurrentDomain.UnhandledException +=
             //   new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            //System
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeWindow());

        }


        // The thread we start up to demonstrate non-UI exception handling. 


        // Handle the UI exceptions by showing a dialog box, and asking the user whether
        // or not they wish to abort execution.
        private static void Form1_UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            DialogResult result = DialogResult.Cancel;
            try
            {
                result = ShowThreadExceptionDialog("Windows Forms Error ,Power By A.M.---- \r\n", t.Exception);
            }
            catch
            {
                try
                {
                    //Write Error
                    ApplicationLogs.WriteAppsErrorLog("Fatal Windows Forms Error ,Power By A.M.---- \r\n");

                    MessageBox.Show("Fatal Windows Forms Error ",
                        "Fatal Windows Forms Error ,Power By A.M.---- \r\n", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }

        // Handle the UI exceptions by showing a dialog box, and asking the user whether
        // or not they wish to abort execution.
        // NOTE: This exception cannot be kept from terminating the application - it can only 
        // log the event, and inform the user about it. 
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                string errorMsg = "An application error occurred. Please contact the adminstrator " +
                    "with the following information:\n\n  ,Power By A.M.---- \r\n";

                // Since we can't prevent the app from terminating, log this to the event log.
                if (!EventLog.SourceExists("ThreadException"))
                {
                    EventLog.CreateEventSource("ThreadException", "Application");
                }

                // Create an EventLog instance and assign its source.
                EventLog myLog = new EventLog();
                myLog.Source = "ThreadException";
                myLog.WriteEntry(errorMsg + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
            }
            catch (Exception exc)
            {
                try
                {
                    MessageBox.Show("Fatal Non-UI Error",
                        "Fatal Non-UI Error. Could not write the error to the event log. Reason: ,Power By A.M.---- \r\n"
                        + exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }

        // Creates the error message and displays it.
        private static DialogResult ShowThreadExceptionDialog(string title, Exception e)
        {
            string errorMsg = "An application error occurred. Please contact the adminstrator " +
                "with the following information:\n\n ,Power By A.M.---- \r\n";
            errorMsg = errorMsg + e.Message + "\n\nStack Trace:\n" + e.StackTrace;


            return MessageBox.Show(errorMsg, title, MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Stop);
        }
    }
}
