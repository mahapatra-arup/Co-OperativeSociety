using System;
using System.Windows.Forms;

namespace BusinessEntities
{
    class MultipleSlidingPAnel
    {
        Panel span;
        Button button;
        bool horizontal;
        bool hidden;
        string hText;
        string sText;
        int size;
        Timer t;

        public MultipleSlidingPAnel(ref Panel p,int PanelHeight,int PanelWidth,ref Button b,bool Horizontal, string hideText,string showtext,bool pnlhidden)
        {
            this.span = p;
            this.button = b;
            this.horizontal = Horizontal;
            hidden = pnlhidden;
            this.hText = hideText;
            this.sText = showtext;
            //***********Run time Start 0**************
            if (horizontal) { p.Height = 0;}//Height
            else { p.Width = 0; size = 0; }//Width
            //***********Panel Height**************
            if (horizontal)  size = PanelHeight;
            else size = PanelWidth;
            //me
            b.Click += new EventHandler(button_clicked);

            t = new Timer();
            t.Interval = 1;
            t.Tick += new EventHandler(t_tick); 
        }
        void ChangeSize(int val)
        {
            if (horizontal)
            {
                span.Height += val;

                if(span.Height >= size || span.Height <= 0)
                {
                    t.Stop();
                    hidden = !hidden;
                }
            }
            else
            {
                span.Width += val;

                if(span.Width >= size || span.Width <= 0)
                {
                    t.Stop();
                    hidden = !hidden;
                }

            }
        }
        private void t_tick(object sender, EventArgs e)
        {
            if (hidden) ChangeSize(+20);
            else ChangeSize(-20);
        }

        private void button_clicked(object sender, EventArgs e)
        {
            if (!hidden) button.Text = sText;
            else button.Text = hText;

            t.Start();
        }
    }
}
