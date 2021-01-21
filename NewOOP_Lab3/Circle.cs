using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab3
{
    class Circle
    {
        public PointClass point = new PointClass();
        public int r { get; set; }
        public int redcolor { get; private set; }
        public int greencolor { get; private set; }
        public int bluecolor { get; private set; }
        public bool visibility;

        public Circle()
        {
            Random randomint = new Random();
            point = new PointClass();
            this.r = randomint.Next(3, 150);
            this.visibility = true;
            this.redcolor = randomint.Next(0, 256);
            this.greencolor = randomint.Next(0, 256);
            this.bluecolor = randomint.Next(0, 256);
        }

        public Circle(int x, int y, int r)
        {
            point = new PointClass(x, y);
            this.r = r;
            this.visibility = true;
            this.redcolor = 255;
            this.greencolor = 255;
            this.bluecolor = 255;
        }

        public Circle(int x, int y, int r, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            point = new PointClass(x, y);
            this.r = r;
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
                    gr.FillEllipse(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), point.X - r, point.Y - r, 2 * r, 2 * r);
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        gr.DrawEllipse(new Pen(Color.White), point.X - r, point.Y - r, 2 * r, 2 * r);
                    }
                    else
                    {
                        gr.DrawEllipse(new Pen(Color.Black), point.X - r, point.Y - r, 2 * r, 2 * r);
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
