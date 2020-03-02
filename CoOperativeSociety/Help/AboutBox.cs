using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoOperativeSociety.Help
{
    partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            //this.Text = String.Format("{0}", AssemblyDetails._gAssemblyTitle);
            this.labelProductName.Text = "Product :" + AssemblyDetails._gProductName;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyDetails._gVersion);
            this.labelCopyright.Text = AssemblyDetails._gCopyright;
            this.labelCompanyName.Text = AssemblyDetails._gCompanyName;
            this.textBoxDescription.Text = AssemblyDetails._gDescription;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
