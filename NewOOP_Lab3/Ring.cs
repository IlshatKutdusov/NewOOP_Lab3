using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab3
{
    class Ring
    {
        private Circle circleMin, circleMax;

        public Ring()
        {
            Random randomint = new Random();
            this.circleMax = new Circle();
            this.circleMin = new Circle(circleMax.point.X, circleMax.point.Y, randomint.Next(1, circleMax.r - 1));
        }

        public Ring(int x, int y, int rmin, int rmax, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            this.circleMax = new Circle(x, y, rmax, visibility, redcolor, greencolor, bluecolor);
            this.circleMin = new Circle(x, y, rmin, visibility, 255, 255, 255);
            
        }

        public void Show(PictureBox pictureBox1)
        {
            this.circleMax.Show(pictureBox1);
            this.circleMin.Show(pictureBox1);
        }

        public void MoveTo(int x, int y)
        {
            this.circleMax.MoveTo(x, y);
            this.circleMin.MoveTo(x, y);
        }

        public void Visibility()
        {
            this.circleMax.Visibility();
            this.circleMin.Visibility();
        }
    }
}
