using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TETRIS
{
    class Massif
    {
        public Point[,] mas = new Point[20, 10];

        public void CreateMassif()
        {
            int x = 4;
            int y = 3;
            Point[,] create_mas = new Point[20, 10];
            for (int a=0; a<20; a++)
            {
                for (int b=0; b<10; b++)
                {
                    create_mas[a, b] = new Point(x, y);
                    x++;
                }
                y++;
                x = 4;
            }
            mas = create_mas;
        }

        public void FillCell (int a, int b)
        {
            mas[a, b].FullPointLight();
        }

        public void ElementLight (int a, int b)
        {
            mas[a, b].PointLight();
        }

        public void MassifLight()
        {
            for (int a=0; a<20; a++)
            {
                for (int b=0; b<10; b++)
                {
                    ElementLight(a, b);
                    //Thread.Sleep(30);
                }
            }
        }
    }
}
