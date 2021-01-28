using System;

namespace Radar
{
    class Point
    {
        public int x;
        public int y;
        public char s;

        public Point (int x, int y, char s) {
            this.x = x;
            this.y = y;
            this.s = s;
        }

        public void Draw () {
            Console.SetCursorPosition (x, y);
            Console.WriteLine (s);
        }

        public void WipeOff () {
            s = ' ';
            Draw ();
        }
    }
}