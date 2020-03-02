using System;
using System.Drawing;
using System.Windows.Forms;

namespace BusinessEntities
{
    public partial class PleaseWait : Form
    {
        public enum Mode
        {
            Continue,
            Block,
            Wait
        }
       Mode _Type;
        public PleaseWait(Mode _type)
        {
            InitializeComponent();
            _Type = _type;
            switch (_Type)
            {
                case Mode.Continue:
                    ProgressB . Visible = false;
                    pbWait.Visible = false;
                    break;
                case Mode.Block:
                    pb.Visible = false;
                    pbWait.Visible = false;
                    ProgressScreen(100, this.Size, panel2.Location);
                    break;
                case Mode.Wait:
                    pbWait.Visible = true;
                    pb.Visible = false;
                    ProgressB.Visible = false;
                    pbLoading.Visible = false;
                    break;
            }
        }

        int maxValue;
        public void ProgressScreen(int progressvalue, Size s, Point p)
        {
            progressBer.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            maxValue = progressvalue;
            progressBer.Maximum = progressvalue;
            ////////////////New
            ProgressB.Maximum = progressvalue;
            //////
            tmProgress.Enabled = true;
        }

        private void tmProgress_Tick(object sender, EventArgs e)
        {
            progressBer.Increment(1);
            ////////New
            ProgressB.Increment(1);
            ////////////
            if (progressBer.Value > maxValue)
            {
                tmProgress.Stop();
            }
        }
    }
}
