using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ant_Algorithm_lab3
{
    class City
    {
        public int x { get; set; }
        public int y { get; set; }

        public double distance(City to)
        {
            int xd = Math.Abs(x - to.x);
            int yd = Math.Abs(y - to.y);

            return Math.Sqrt(xd * xd + yd * yd);
        }
    }
}
