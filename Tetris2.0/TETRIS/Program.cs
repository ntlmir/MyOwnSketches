using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TETRIS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Frame();

            Massif MAS = new Massif();
            MAS.CreateMassif();
            MAS.MassifLight();

            //Figures f1 = new Figures();
            //f1.CreateFigure();

            Console.ReadLine();
        }

        static void Frame()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Horisontal(2);
            Vertical(3);
            Horisontal(23);
            Vertical(14);
            Console.ResetColor();
        }

        static void Horisontal (int y)
        {
            for (int x=3; x<15; x++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                //Thread.Sleep(50);
            }
        }

        static void Vertical (int x)
        {
            for (int y=3; y<24; y++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                //Thread.Sleep(50);
            }
        }
    }
}
