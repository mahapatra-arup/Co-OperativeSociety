using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BusinessEntities
{
    public partial class GradientPanel : System.Windows.Forms.Panel
    {

        // member variables
        System.Drawing.Color mStartColor;
        System.Drawing.Color mEndColor;
        System.Drawing.Color mMiddleColor;
        bool mTripleColorMode = false;
        LinearGradientMode mLinearGradientMode = LinearGradientMode.Horizontal;

        public GradientPanel()
        {
            InitializeComponent();
            PaintGradient();
        }

        #region ................Properties Create........................
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

        //Color Properties Add
        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            base.OnPaint(pe);
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
      
    }
}
