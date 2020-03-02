using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoOperativeSociety
{
    public static  class FormUtils
    {
        
        public enum _Type { Show, Close, Hide, Minimize }
        public static bool FormHaveOpen(string frmName, _Type mode)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            Form frmnm = new Form();
            foreach (Form frm in fc)
            { if (frm.Name == frmName) { IsOpen = true; frmnm = frm; } }


            //Form is open then
            if (IsOpen)
            {
                switch (mode)
                {
                    case _Type.Show:
                        frmnm.Show();
                        frmnm.BringToFront();
                        frmnm.Activate();
                        frmnm.WindowState = FormWindowState.Maximized;
                        frmnm.Focus();
                        break;
                    case _Type.Close:
                        frmnm.Close();
                        break;
                    case _Type.Hide:
                        frmnm.Hide();
                        break;
                    case _Type.Minimize:
                        frmnm.WindowState = FormWindowState.Minimized;
                        break;
                    default:
                        break;
                }

            }




            return IsOpen;
        }

        public static bool FormHaveOpen(Form frmName)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == frmName.Name)
                {
                    IsOpen = true;
                    frm.Show();
                    frm.BringToFront();
                    frm.Activate();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Focus();
                }
            }
            return IsOpen;
        }

        public enum _ { First,last }
        public static void FormMinAndMax(this Panel pnlName)
        {
            foreach (Control frm in pnlName.Controls)
            {
                if (frm is Form)
                {

                    Form frmnm = new Form();
                    frmnm = (Form)frm;
                    
                    frmnm.WindowState = FormWindowState.Minimized;
                    frmnm.WindowState = FormWindowState.Maximized;
                }
            }
        }
    }
}
