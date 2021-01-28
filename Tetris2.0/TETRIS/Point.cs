using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TETRIS
{
    class Point
    {
        int x;
        int y;

        public Point (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("\u00A4");
        }

        public void PointLight()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            Console.ResetColor();
        }

        public void FullPointLight()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            Console.ResetColor();
        }
    }
}
