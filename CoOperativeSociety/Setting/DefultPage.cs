using CoOperativeSociety.Tools;
using CoOperativeSociety.Tools.ProjectTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoOperativeSociety.Help
{
    public partial class DefultPage : Form
    {
        public DefultPage()
        {
            InitializeComponent();
            
            lblName.Text = SocityUtils.SocietyName;
            Image img = Imager.byteArrayToImage(SocityUtils.Logo);
            if (img != null)
            {
                pbLogo.BackgroundImage = img;
            }
        }
    }
}
