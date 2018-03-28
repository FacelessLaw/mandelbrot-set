using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Runtime.InteropServices;

namespace Mandelbrot
{

    public partial class Form1 : Form
    {
        public class DirectBitmap : IDisposable
    {
        public Bitmap Bitmap { get; private set; }
        public Int32[] Bits { get; private set; }
        public bool Disposed { get; private set; }
        public int Height { get; private set; }
        public int Width { get; private set; }

        protected GCHandle BitsHandle { get; private set; }

        public DirectBitmap(int width, int height)
        {
            Width = width;
            Height = height;
            Bits = new Int32[width * height];
            BitsHandle = GCHandle.Alloc(Bits, GCHandleType.Pinned);
            Bitmap = new Bitmap(width, height, width * 4, System.Drawing.Imaging.PixelFormat.Format32bppPArgb, BitsHandle.AddrOfPinnedObject());
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;
            Bitmap.Dispose();
            BitsHandle.Free();
        }

        public void SetPixel(int x, int y, Color col)
        {
            if ((x > 0 && y > 0) && (x < Width && y < Height))
                Bitmap.SetPixel(x, y, col);
        }

        public IntPtr GetHbitmap()
        {
            return Bitmap.GetHbitmap();
        }
    }

        public struct complex
        {
            public double R, Im;

            public complex(double r, double im)
            {
                R = r;
                Im = im;
            }

            public static complex operator + (complex a, complex b)
            {
                return new complex(a.R + b.R, a.Im + b.Im);
            }

            public static complex operator *(complex a, complex b)
            {
                return new complex(a.R * b.R - a.Im * b.Im, a.R * b.Im + b.R * a.Im);
            }

            public double Abs()
            {
                return this.R * this.R + this.Im * this.Im;
            }
        }

        #region Initialization;
        Bitmap bmp;

        Graphics g;

        System.Drawing.Rectangle myRect = new System.Drawing.Rectangle();
        Point firstclick = new Point();

        PointF LL, LH, RH;
        complex P0, P1;
        int MaxIter;

        double centreX, centreY;

        double cx, cy;
        #endregion

        void get_val()
        {
            centreX = double.Parse(InCntrReal.Text);
            centreY = double.Parse(InCntrIm.Text);

            cx = double.Parse(InCFreal.Text);
            cy = double.Parse(InCFim.Text);

            MaxIter = int.Parse(InIter.Text);
        }

        private void Build_Click(object sender, EventArgs e)
        {
            get_val();
            draw();
        }

        private void ExtBt_Click(object sender, EventArgs e)
        {
            Close();
        }

        void clr()
        {
            LL = new PointF(0, 0);
            LH = new PointF(0, pictureBox1.Height);
            RH = new PointF(pictureBox1.Width, pictureBox1.Height);

            P0 = new complex(-3, -2);
            P1 = new complex(2, 2);
        }

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            clr();
            draw();
        }

        complex get_complex(PointF pix)
        {
            return new complex(P0.R + (P1.R - P0.R) * pix.X / pictureBox1.Width, P0.Im + (P1.Im - P0.Im) * pix.Y / pictureBox1.Height);
        }

        int get_iter(complex c)
        {
            int iter = 0;

            complex z = new complex(centreX, centreY);

            while (iter != MaxIter)
            {
                if (z.Abs() > 2)
                    break;

                z = z * z * z * z + c;

                ++iter;
            }

            return iter;
        }

        void draw()
        {
            complex P01 = get_complex(LL);
            complex P11 = get_complex(RH);

            P0 = P01;
            P1 = P11;

            myRect.Height = 0;
            myRect.Width = 0;

            prBar.Visible = true;
            prBar.Minimum = 0;
            prBar.Maximum = pictureBox1.Height * pictureBox1.Width;
            prBar.Value = 0;
            prBar.Step = 1;

            for (int i = 0; i < pictureBox1.Width; ++i)
            {
                for (int j = 0; j < pictureBox1.Height; ++j)
                {
                    complex c = get_complex(new PointF(i, pictureBox1.Height - j));
                    c.R *= cx;
                    c.Im *= cy;

                    int iter = get_iter(c);

                    Color col;

                    #region Color
                    if (iter < MaxIter * 0.16)
                        col = Color.FromArgb(255, 255, 255);
                    else
                        if (iter < MaxIter * 0.18)
                        col = Color.FromArgb(224, 255, 255);
                    else
                        if (iter < MaxIter * 0.2)
                        col = Color.FromArgb(179, 255, 229);
                    else
                        if (iter < MaxIter * 0.22)
                        col = Color.FromArgb(127, 255, 212);
                    else
                        if (iter < MaxIter * 0.24)
                        col = Color.FromArgb(97, 255, 194);
                    else
                        if (iter < MaxIter * 0.26)
                        col = Color.FromArgb(46, 255, 175);
                    else
                        if (iter < MaxIter * 0.28)
                        col = Color.FromArgb(0, 250, 154);
                    else
                        if (iter < MaxIter * 0.3)
                        col = Color.FromArgb(0, 255, 127);
                    else
                        if (iter < MaxIter * 0.32)
                        col = Color.FromArgb(0, 255, 0);
                    else
                        if (iter < MaxIter * 0.34)
                        col = Color.FromArgb(102, 255, 0);
                    else
                        if (iter < MaxIter * 0.36)
                        col = Color.FromArgb(124, 252, 0);
                    else
                        if (iter < MaxIter * 0.38)
                        col = Color.FromArgb(127, 255, 0);
                    else
                        if (iter < MaxIter * 0.4)
                        col = Color.FromArgb(167, 252, 0);
                    else
                        if (iter < MaxIter * 0.42)
                        col = Color.FromArgb(173, 255, 47);
                    else
                        if (iter < MaxIter * 0.44)
                        col = Color.FromArgb(191, 255, 0);
                    else
                        if (iter < MaxIter * 0.46)
                        col = Color.FromArgb(204, 255, 0);
                    else
                        if (iter < MaxIter * 0.48)
                        col = Color.FromArgb(206, 255, 29);
                    else
                        if (iter < MaxIter * 0.5)
                        col = Color.FromArgb(237, 255, 33);
                    else
                        col = Color.FromArgb(255, 255, 51);
                    #endregion
                    
                    bmp.SetPixel(i, j, col);

                    prBar.PerformStep();
                }
            }

            pictureBox1.Image = bmp;

            prBar.Value = 0;
        }

        public Form1()
        {
            InitializeComponent();

            #region Set_Text;
            InCntrReal.Text = "0";
            InCntrIm.Text = "0";

            InCFreal.Text = "1";
            InCFim.Text = "1";

            InIter.Text = "500";
            #endregion

            clr();

            int height = pictureBox1.Height;
            int width = pictureBox1.Width;

            bmp = new Bitmap(width, height);

            pictureBox1.BackgroundImage = bmp;

            g = pictureBox1.CreateGraphics();

            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.BlueViolet, 1), myRect);
        }

        private void PictureBox1_Select(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Red, 1), myRect); 
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            firstclick = new Point(e.X, e.Y);
            pictureBox1.Paint -= PictureBox1_Paint;
            pictureBox1.Paint += PictureBox1_Select;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                myRect.X = Math.Min(e.X, firstclick.X);
                myRect.Y = Math.Min(e.Y, firstclick.Y);
                myRect.Width = Math.Max(e.X, firstclick.X) - myRect.X;
                myRect.Height = Math.Max(e.Y, firstclick.Y) - myRect.Y;

                (sender as PictureBox).Refresh();
            }

            complex pcomp = get_complex(new Point(e.X, pictureBox1.Height - e.Y));

            OutCurrX.Text = pcomp.R.ToString();
            OutCurrY.Text = pcomp.Im.ToString();
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Paint -= PictureBox1_Select;
            pictureBox1.Paint += PictureBox1_Paint;

            LL = new PointF(myRect.X, pictureBox1.Height - (myRect.Height + myRect.Y));
            LH = new PointF(myRect.X, pictureBox1.Height - myRect.Y);
            RH = new PointF(myRect.X + myRect.Width, pictureBox1.Height - myRect.Y);

            pictureBox1.Invalidate();
        }
    }
}
