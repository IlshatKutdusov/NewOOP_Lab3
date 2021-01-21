using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOOP_Lab3
{
    class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointClass()
        {
            Random randomint = new Random();
            this.X = randomint.Next(0, 1054);
            this.Y = randomint.Next(0, 685);
        }

        public PointClass(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
