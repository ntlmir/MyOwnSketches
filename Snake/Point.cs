using System;

namespace Projeck_2
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point (int _x, int _y, char _sym) {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point (Point p) {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move (int offset, Diraction diraction) {
            if (diraction == Diraction.RIGHT) {
                x = x + offset;
            }
            else if (diraction == Diraction.LEFT) {
                x = x - offset;
            }
            else if (diraction == Diraction.UP) {
                y = y - offset;
            }
            else if (diraction == Diraction.DOWN) {
                y = y + offset;
            }
        }

        public void Draw () {
            Console.SetCursorPosition (x, y);
            Console.WriteLine (sym);
        }

        public void Clear () {
            sym = ' ';
            Draw ();
        }

        public bool IsHit (Point p) {
            return p.x == this.x && p.y == this.y;
        }
    }
}