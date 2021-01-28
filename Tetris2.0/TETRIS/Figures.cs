using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TETRIS
{
    class Figures : Massif
    {
        public int aCentre = 2;
        public int bCentre = 4;

        public void CreateFigure()
        {
            FillCell(aCentre, bCentre);
        }
    }
}
