using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Projeck_2
{
    class Walls
    {
        List<Figure> wallList;

        public Walls (int mapWidht, int mapHight) {
            wallList = new List<Figure> ();

            HorizontalLine upLine = new HorizontalLine (2,mapWidht-2,1, '+');
            HorizontalLine downLine = new HorizontalLine (2,mapWidht-2,24, '+');
            VerticalLine leftLine = new VerticalLine (2,2,mapHight-2, '+');
            VerticalLine rightLine = new VerticalLine (78,2,mapHight-2, '+');

            wallList.Add (rightLine);
            wallList.Add (leftLine);
            wallList.Add (upLine);
            wallList.Add (downLine);
        }

        internal bool IsHit (Figure figure) {
            foreach (var wall in wallList) {
                if (wall.IsHit(figure)) {
                    return true;
                }
            }
            return false;
        }

        public void Draw () {
            foreach (var wall in wallList) {
                wall.Draw ();
            }
        }
    }
}