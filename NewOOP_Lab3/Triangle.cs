using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab3
{
    class Triangle
    {
        private PointClass point1, point2, point3;
        private int redcolor { get; set; }
        private int greencolor { get; set; }
        private int bluecolor { get; set; }
        private bool visibility;

        public Triangle()
        {
            Random randomint = new Random();
            int x = randomint.Next(0, 1054);
            int y = randomint.Next(0, 685);
            int r = randomint.Next(0, 150);
            point1 = new PointClass();
            point2 = new PointClass();
            point3 = new PointClass();
            this.point1.X = randomint.Next(x - r, x + r);
            this.point1.Y = randomint.Next(y - r, y + r);
            this.point2.X = randomint.Next(x - r, x + r);
            this.point2.Y = randomint.Next(y - r, y + r);
            this.point3.X = randomint.Next(x - r, x + r);
            this.point3.Y = randomint.Next(y - r, y + r);
            this.visibility = true;
            this.redcolor = randomint.Next(0, 256);
            this.greencolor = randomint.Next(0, 256);
            this.bluecolor = randomint.Next(0, 256);
        }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            point1 = new PointClass(x1, y1);
            point2 = new PointClass(x2, y2);
            point3 = new PointClass(x3, y3);
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
                    gr.FillPolygon(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), new [] { new PointF(point1.X, point1.Y), new PointF(point2.X, point2.Y), new PointF(point3.X, point3.Y) });
                if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                {
                    gr.DrawPolygon(new Pen(Color.White), new[] { new PointF(point1.X, point1.Y), new PointF(point2.X, point2.Y), new PointF(point3.X, point3.Y) });
                }
                else
                {
                    gr.DrawPolygon(new Pen(Color.Black), new[] { new PointF(point1.X, point1.Y), new PointF(point2.X, point2.Y), new PointF(point3.X, point3.Y) });
                }
            }
            pictureBox1.Invalidate();
        }
    }

    public void MoveTo(int x, int y)
    {
        this.point1.X += x;
        this.point2.X += x;
        this.point3.X += x;
        this.point1.Y += y;
        this.point2.Y += y;
        this.point3.Y += y;
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
