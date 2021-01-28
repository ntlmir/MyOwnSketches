using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeck_2
{
    class VerticalLine : Figure
    {
        public VerticalLine (int x, int yU, int yD, char sym) {
            pList = new List<Point> ();

            for (int y=yU; y<=yD; y++) {
                Point p = new Point (x, y, sym);
                pList.Add (p);
            }
        }
    }
}