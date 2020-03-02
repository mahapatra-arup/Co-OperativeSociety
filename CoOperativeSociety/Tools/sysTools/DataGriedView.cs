using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoOperativeSociety
{
    public static class DataGriedViewTool
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="columnname"></param>
        /// <returns></returns>
        public static bool DGVCheckBoxCheck(object sender, DataGridViewCellEventArgs e, string columnname)
        {
            var senderGrid = (DataGridView)sender;
            senderGrid.EndEdit();
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn &&
                e.RowIndex >= 0)
            {

                var cbxCell = (DataGridViewCheckBoxCell)senderGrid.Rows[e.RowIndex].Cells[columnname];
                if ((bool)cbxCell.Value)
                {
                    return (bool)cbxCell.Value;//true
                }
            }
            return false;//false
        }

        /// <summary>
        /// DataGridView Last Row Design (Like Total Row)
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        public static void DGVRowDesign(this DataGridView dgv, int _RowNo)
        {
            dgv.Rows[_RowNo].DefaultCellStyle.BackColor = Color.Black;
            dgv.Rows[_RowNo].DefaultCellStyle.ForeColor = Color.White;
            dgv.Rows[_RowNo].DefaultCellStyle.SelectionBackColor = Color.Black;
            dgv.Rows[_RowNo].DefaultCellStyle.SelectionForeColor = Color.White;

            //Font
            dgv.Rows[_RowNo].DefaultCellStyle.Font = new Font("Tahoma",10);
            dgv.Refresh();
        }

        #region ----------grid_LabelPaint-----------
        /// <summary>
        /// DataGridView Column Span Use Label Paint
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="oLabel"></param>
        /// <param name="_RowNo"></param>
        /// <param name="_ColumnIndexFrom"></param>
        /// <param name="_ColumnIndexTo"></param>
        public static void grid_LabelPaint(this DataGridView grid, ref Label oLabel, int _RowNo, int _ColumnIndexFrom, int _ColumnIndexTo)
        {
            //Remove old Control 
            if (grid.Controls.Find("LabelPaint001", true).Length != 0)
            {
                grid.Controls.RemoveByKey("LabelPaint001");
            }

            //Label Design
            oLabel.Name = "LabelPaint001";
            oLabel.AutoSize = false;
            oLabel.FlatStyle = FlatStyle.Flat;
         

            //Adding label control into DataGridView 
            grid.Controls.Add(oLabel);


            // It returns the retangular area that represents the Display area for a cell
            Rectangle oStartCellRectangle = grid.GetCellDisplayRectangle(_ColumnIndexFrom, _RowNo, true);

            int columnsWidth = GetColumnWidth(grid, _ColumnIndexFrom, _ColumnIndexTo);

            //Setting area for Label Control
            oLabel.Size = new Size(columnsWidth, oStartCellRectangle.Height - 1);

            // Setting Location
            oLabel.Location = new Point(oStartCellRectangle.X, oStartCellRectangle.Y);
            grid.Refresh();
        }
      
        #endregion
        /// <summary>
        /// Get Columns Width Of DataGridView
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="_ColumnIndexFrom"></param>
        /// <param name="_ColumnIndexTo"></param>
        /// <returns></returns>
        public static int GetColumnWidth(DataGridView grid,int _ColumnIndexFrom, int _ColumnIndexTo)
        {
            int width = 0;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                if (col.Visible==true)
                {
                    if (_ColumnIndexFrom <= col.Index && _ColumnIndexTo >= col.Index)
                    {
                        width += col.Width;
                    } 
                }
            }
            return width;
        }

        /// <summary>
        ///  Get Columns Height Of DataGridView
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        private static int GetHeight(DataGridView grid)
        {
            int height = grid.ColumnHeadersHeight;
            foreach (DataGridViewRow row in grid.Rows)
            {
                height += row.Height;
            }
            return height;
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         