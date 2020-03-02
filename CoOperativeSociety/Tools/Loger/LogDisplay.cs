using BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoOperativeSociety.Tools.Loger
{
    public partial class LogDisplay : Form
    {
        public LogDisplay()
        {
            InitializeComponent();
            FillRecord();
        }


        private void FillRecord()
        {
            string[] a = ApplicationLogs.ReadErrorLog();
            if (a.ISValidObject())
            {
                string logmesg = String.Join(Environment.NewLine, a);
                rtbErrorLog.Text = logmesg; 
            }
            else
            {
                rtbErrorLog.Text = "-No Error Found-";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbErrorLog.Clear();
        }

        private void btnUndu_Click(object sender, EventArgs e)
        {
            rtbErrorLog.Undo();
        }

        public void RTFindAndHighlightText(ref RichTextBox myRtb, string word, Color color)
        {

            if (word == string.Empty)
                return;

            int len = myRtb.TextLength;
            int index = 0;
            int lastIndex = myRtb.Text.LastIndexOf(word);

            while (index < lastIndex)
            {
                myRtb.Find(word, index, len, RichTextBoxFinds.None);
                myRtb.SelectionBackColor = color;
                index = myRtb.Text.IndexOf(word, index) + 1;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RTFindAndHighlightText(ref rtbErrorLog, txtSearch.Text, Color.Red);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            FillRecord();
        }
    }
}
