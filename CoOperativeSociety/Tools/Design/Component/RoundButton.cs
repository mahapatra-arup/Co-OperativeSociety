using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

class RoundButton :Button
{
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        GraphicsPath grPath = new GraphicsPath();
        grPath.AddEllipse(0, 10, ClientSize.Width, ClientSize.Height);
        this.Region = new System.Drawing.Region(grPath);
        base.OnPaint(e);
    }
}
