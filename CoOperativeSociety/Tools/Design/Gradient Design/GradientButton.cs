
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
// This is my namespace of collections and contains the ColorCollection used in the multigradiant button

namespace BusinessEntities
{
    /// <summary>
    /// 	
    /// </summary>

    /*
     * MultiGraniantButton class
     */
    public class MultiGradiantButton : System.Windows.Forms.Button
    {
        // member variables
        System.Drawing.Color mStartColor;
        System.Drawing.Color mEndColor;
        System.Drawing.Color mMiddleColor;
        bool mTripleColorMode = false;

        LinearGradientMode mLinearGradientMode = LinearGradientMode.Horizontal;

        //mOUSE HOVER
        System.Drawing.Color mOVERStartColor;
        System.Drawing.Color mOVEREndColor;
        System.Drawing.Color mOVERMiddleColor;
        bool mOVERTripleColorMode = false;

        LinearGradientMode mOVERLinearGradientMode = LinearGradientMode.Horizontal;

        public MultiGradiantButton()
        {
            InitializeComponent();
            PaintGradient();
        }

        #region ................Properties Create........................
        //Color Properties Background
        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            base.OnPaint(pe);
        }
        #region .................Back color...................
        //Properties Create
        public bool PageTripleColorMode
        {
            get
            {
                return mTripleColorMode;
            }
            set
            {
                mTripleColorMode = value;
                PaintGradient();
            }
        }
        public LinearGradientMode PageLinearGradientMode
        {
            get
            {
                return mLinearGradientMode;
            }
            set
            {
                mLinearGradientMode = value;
                PaintGradient();
            }
        }


        public System.Drawing.Color PageStartColor
        {
            get
            {
                return mStartColor;
            }
            set
            {
                mStartColor = value;
                PaintGradient();
            }
        }
        public System.Drawing.Color PageEndColor
        {
            get
            {
                return mEndColor;
            }
            set
            {
                mEndColor = value;
                PaintGradient();
            }
        }
        public System.Drawing.Color PageMiddleColor
        {
            get
            {
                return mMiddleColor;
            }
            set
            {
                mMiddleColor = value;
                PaintGradient();
            }
        }
        #endregion



        /// <summary>
        /// Mouse over Back color
        /// </summary>
        /// 
        //Properties Create
        #region ................Mouse Over Back Color................
        public bool PageOverTripleColorMode
        {
            get
            {
                return mOVERTripleColorMode;
            }
            set
            {
                mOVERTripleColorMode = value;
            }
        }
        public LinearGradientMode PageOverLinearGradientMode
        {
            get
            {
                return mOVERLinearGradientMode;
            }
            set
            {
                mOVERLinearGradientMode = value;
            }
        }


        public System.Drawing.Color PageOverStartColor
        {
            get
            {
                return mOVERStartColor;
            }
            set
            {
                mOVERStartColor = value;
            }
        }
        public System.Drawing.Color PageOverEndColor
        {
            get
            {
                return mOVEREndColor;
            }
            set
            {
                mOVEREndColor = value;
            }
        }
        public System.Drawing.Color PageOverMiddleColor
        {
            get
            {
                return mOVERMiddleColor;
            }
            set
            {
                mOVERMiddleColor = value;
            }
        }
        #endregion

        #endregion


        private void PaintGradient()
        {
            //
            if (!PageTripleColorMode)
            {
                #region ................if Double True Then................. 
                Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
                LinearGradientBrush gradBrush = new LinearGradientBrush(rect, PageStartColor, PageEndColor, mLinearGradientMode);

                //Convert to image
                Bitmap bmp = new Bitmap(this.Width, this.Height);

                Graphics g = Graphics.FromImage(bmp);
                g.FillRectangle(gradBrush, new Rectangle(0, 0, this.Width, this.Height));
                this.BackgroundImage = bmp;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                #endregion
            }

            else
            {
                #region ............. if Triple Color Mode True ..............
                Color color1 = PageStartColor;
                Color color2 = PageMiddleColor;
                Color color3 = PageEndColor;

                Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, color1, color1, mLinearGradientMode);

                ColorBlend cblend = new ColorBlend(3);
                cblend.Colors = new Color[3]  { color1, color2,color3
};
                cblend.Positions = new float[3] { 0f, 0.5f, 1f };
                linearGradientBrush.InterpolationColors = cblend;

                Bitmap bmp = new Bitmap(this.Width, this.Height);

                Graphics g = Graphics.FromImage(bmp);
                g.FillRectangle(linearGradientBrush, new Rectangle(0, 0, this.Width, this.Height));
                this.BackgroundImage = bmp;
                #endregion

            }
        }

        private void PaintOverGradient()
        {

            if (!PageOverTripleColorMode)
            {
                #region ................if Double True Then................. 
                Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
                LinearGradientBrush gradBrush = new LinearGradientBrush(rect, PageOverStartColor, PageOverEndColor, mOVERLinearGradientMode);

                //Convert to image
                Bitmap bmp = new Bitmap(this.Width, this.Height);

                Graphics g = Graphics.FromImage(bmp);
                g.FillRectangle(gradBrush, new Rectangle(0, 0, this.Width, this.Height));
                //Mouse hover and down color set
                this.BackgroundImage = bmp;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                #endregion
            }

            else
            {
                #region ............. if Triple Color Mode True ..............
                Color color1 = PageOverStartColor;
                Color color2 = PageOverMiddleColor;
                Color color3 = PageOverEndColor;

                Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);
                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, color1, color1, mOVERLinearGradientMode);

                ColorBlend cblend = new ColorBlend(3);
                cblend.Colors = new Color[3]  { color1, color2,color3
};
                cblend.Positions = new float[3] { 0f, 0.5f, 1f };
                linearGradientBrush.InterpolationColors = cblend;

                Bitmap bmp = new Bitmap(this.Width, this.Height);

                Graphics g = Graphics.FromImage(bmp);
                g.FillRectangle(linearGradientBrush, new Rectangle(0, 0, this.Width, this.Height));
                this.BackgroundImage = bmp;
                #endregion

            }

        }

        //Current Background LoadImage
        Image img = null;
        Color clor = new Color();
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

            //Transparent null
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;

            //if (this.BackgroundImage != null)
            //{
            img = this.BackgroundImage;
            // }
            clor = Color.Transparent;

            this.MouseHover += MultiGradiantButton_MouseHover;
            this.MouseDown += MultiGradiantButton_MouseDown;

            //Mouse leave use like this
            //  this.MouseLeave += MultiGradiantButton_MouseLeave;
        }

        #region ...............Event....................

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.BackgroundImage = img;
            this.BackColor = clor;
        }

        private void MultiGradiantButton_MouseDown(object sender, MouseEventArgs e)
        {
            PaintOverGradient();
        }

        private void MultiGradiantButton_MouseHover(object sender, EventArgs e)
        {
            PaintOverGradient();
        }
        #endregion
    }
}
