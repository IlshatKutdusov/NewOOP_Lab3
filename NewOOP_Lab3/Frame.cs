using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab3
{
    class Frame
    {
        private Rectangle frameMin, frameMax;

        public Frame()
        {
            Random randomint = new Random();
            this.frameMax = new Rectangle();
            this.frameMin = new Rectangle(this.frameMax.point.X, this.frameMax.point.Y, randomint.Next(1, frameMax.w - 1), randomint.Next(1, this.frameMax.h - 1));
        }

        public Frame(int x, int y, int wmin, int hmin, int wmax, int hmax, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            this.frameMax = new Rectangle(x, y, wmin, hmax, visibility, redcolor, greencolor, bluecolor);
            this.frameMin = new Rectangle(x, y, wmax, hmin, visibility, 255, 255, 255);

        }

        public void Show(PictureBox pictureBox1)
        {
            this.frameMax.Show(pictureBox1);
            this.frameMin.Show(pictureBox1);
        }

        public void MoveTo(int x, int y)
        {
            this.frameMax.MoveTo(x, y);
            this.frameMin.MoveTo(x, y);
        }

        public void Visibility()
        {
            frameMax.Visibility();
            frameMin.Visibility();
        }
    }
}
