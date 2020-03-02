using BusinessEntities;
using CoOperativeSociety.Tools;
using CoOperativeSociety.Tools.ProjectTools;
using SocietyBusinessAccess.Society;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CoOperativeSociety.Society
{
    public partial class SocityDetailsEntry : Form
    {
        SocietyDetailsBA frrmSocietyDetailsBA = new SocietyDetailsBA();
        public SocityDetailsEntry()
        {
            InitializeComponent();

            //Fill
            cmbDist.AddDist();
            FillDetails();
        }

        #region -------------Method--------------
        /// <summary>
        /// Get Values of Form Control
        /// </summary>
        private SocietyDetail FormValues()
        {
            SocietyDetail frmSD = new SocietyDetail();


            frmSD.SocietyName = txtSchoolName.Text.ToUpper();
            frmSD.At = txtAT.Text;
            frmSD.PO = txtPO.Text;
            frmSD.PS = txtPS.Text;
            frmSD.GP = txtGP.Text;
            frmSD.PIN = txtPin.Text;
            frmSD.Block = txtBlock.Text;
            frmSD.SubDivission = txtSubDivission.Text;
            frmSD.ESTD = txtESTD.Text;
            frmSD.Category = txtCategory.Text;
            frmSD.Ph = txtContectNo.Text;
            frmSD.Email = txtEmail.Text;
            frmSD.Website = txtWebsite.Text;
            frmSD.RegistrationNo = txtRegistrationNo.Text;
            frmSD.PanNo = txtPanNo.Text;
            frmSD.CentreCode = txtCentreCode.Text;
            frmSD.GSTNo = txtGSTNo.Text;
            frmSD.DistrictCode = txtDistCode.Text;
            frmSD.DIST = ((KeyValuePair<int, string>)cmbDist.SelectedItem).Value;
            frmSD.Area = cmbArea.Text;
            frmSD.Logo = Imager.imageToByteArray(pbLogo.BackgroundImage);
            return frmSD;
        }
        private void Save()
        {
            bool Issuccess = false;
            string socityname = frrmSocietyDetailsBA.GetSocietyDetails().SocietyName;
            if (socityname.ISNullOrWhiteSpace())
            {
                Issuccess = frrmSocietyDetailsBA.InsertSocietyDetails(FormValues());
            }
            else
            {
                Issuccess = frrmSocietyDetailsBA.UpdateSocietyDetails(FormValues());
            }
            if (Issuccess)
            {
                MessageBox.Show("Save Succesfull");
                //uPDATE sOCIETY dETAILS
                DefultClass.FillSocityDetails();
            }
        }
        private bool IsValid()
        {
            if (!string.IsNullOrEmpty(txtSchoolName.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(cmbDist.Text.Trim()))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Select valid Dist", "Dist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbDist.Select();
                }
            }
            else
            {
                MessageBox.Show("Entry Society Name.", "Society Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSchoolName.Select();
            }
            return false;
        }

        private void FillDetails()
        {
            SocietyDetail frmSD = new SocietyDetail();

            //Call Method
            frmSD = frrmSocietyDetailsBA.GetSocietyDetails();

            //Fill Details
            txtSchoolName.Text = frmSD.SocietyName;
            frmSD.At = txtAT.Text;
            txtPO.Text = frmSD.PO;
            txtPS.Text = frmSD.PS;
            txtGP.Text = frmSD.GP;
            txtPin.Text = frmSD.PIN;
            txtBlock.Text = frmSD.Block;
            txtSubDivission.Text = frmSD.SubDivission;
            txtESTD.Text = frmSD.ESTD;
            txtCategory.Text = frmSD.Category;
            txtContectNo.Text = frmSD.Ph;
            txtEmail.Text = frmSD.Email;
            txtWebsite.Text = frmSD.Website;
            txtRegistrationNo.Text = frmSD.RegistrationNo;
            txtPanNo.Text = frmSD.PanNo;
            txtCentreCode.Text = frmSD.CentreCode;
            txtGSTNo.Text = frmSD.GSTNo;
            txtDistCode.Text = frmSD.DistrictCode;
            cmbDist.Text = frmSD.DIST;
            cmbArea.Text = frmSD.Area;
            Image img = Imager.byteArrayToImage(frmSD.Logo);
            if (img != null)
            {
                pbLogo.BackgroundImage = img;
            }
        }
        #endregion

        #region --------------Event--------------
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (IsValid())
            {
                Save();
                FillDetails();
            }
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void btnAddPhoto_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbLogo.BackgroundImage = (Bitmap)Image.FromFile(ofd.FileName);
                }
                catch (Exception)
                {
                }
            }
        }
        #endregion
    }
}
