using SocietyBusinessAccess.Setting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoOperativeSociety.Setting
{
    public partial class DecimalPointSetting : Form
    {
        DecimalPointBA decimalPointBA = new DecimalPointBA();
        public DecimalPointSetting()
        {
            InitializeComponent();
            FillDecimalPoint();
        }

        private void FillDecimalPoint()
        {
           nudDecimalPoint.Value= decimalPointBA.GetDecimalPointTool().DecimalPointNo;
        }
        private void nudDecimalPoint_ValueChanged(object sender, EventArgs e)
        {
            decimalPointBA.UpdateOfUpdateOfDecimalPointTools(new BusinessEntities.DecimalPointTool { DecimalPointNo = (int)nudDecimalPoint.Value });
        }
    }
}
