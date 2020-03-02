using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoOperativeSociety.Tools.Design.User_Control
{
    public partial class DragingPanel : UserControl
    {
        public DragingPanel()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        #region .................. panel Draging.......................
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void Draging_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Draging_Panel.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Draging_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Draging_Panel.Location;
        }

        private void Draging_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

    }
}
