using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab3
{
    class Rectangle
    {
        public PointClass point;
        public int w { get; private set; }
        public int h { get; private set; }
        public int redcolor { get; private set; }
        public int greencolor { get; private set; }
        public int bluecolor { get; private set; }
        public bool visibility;

        public Rectangle()
        {
            Random randomint = new Random();
            point = new PointClass();
            this.w = randomint.Next(3, 150);
            this.h = randomint.Next(3, 150);
            this.visibility = true;
            this.redcolor = randomint.Next(0, 256);
            this.greencolor = randomint.Next(0, 256);
            this.bluecolor = randomint.Next(0, 256);
        }

        public Rectangle(int x, int y, int w, int h)
        {
            point = new PointClass(x, y);
            this.w = w;
            this.h = h;
            this.visibility = true;
            this.redcolor = 255;
            this.greencolor = 255;
            this.bluecolor = 255;
        }

        public Rectangle(int x, int y, int w, int h, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            point = new PointClass(x, y);
            this.w = w;
            this.h = h;
            this.visibility = visibility;
            this.redcolor = redcolor;
            this.greencolor = greencolor;
            this.bluecolor = bluecolor;
        }

        public void Show(PictureBox pictureBox1)
        {
            if (visibility == true)
            {
                if (pictureBox1.Image == null)
                {
                    Bitmap newbmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    using (Graphics gr = Graphics.FromImage(newbmp))
                    {
                        gr.Clear(Color.White);
                    }
                    pictureBox1.Image = newbmp;
                }
                using (Graphics gr = Graphics.FromImage(pictureBox1.Image))
                {
                    gr.FillRectangle(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), point.X - w, point.Y - h, 2*w, 2*h);
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        gr.DrawRectangle(new Pen(Color.White), point.X - w, point.Y - h, 2*w, 2*h);
                    }
                    else
                    {
                        gr.DrawRectangle(new Pen(Color.Black), point.X - w, point.Y - h, 2*w, 2*h);
                    }
                }
                pictureBox1.Invalidate();
            }
        }

        public void MoveTo(int x, int y)
        {
            this.point.X += x;
            this.point.Y += y;
        }

        public void Visibility()
        {
            if (this.visibility == false)
            {
                this.visibility = true;
            }
            else
            {
                this.visibility = false;
            }

        }
    }
}
