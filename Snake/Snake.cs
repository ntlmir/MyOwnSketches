using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Specialized;

namespace Projeck_2
{
    class Snake : Figure
    {
        public Diraction diraction;

        public Snake (Point tail, int length, Diraction _diraction) {
            diraction = _diraction;
            pList = new List<Point> ();

            for (int i=0; i<length; i++) {
                Point p = new Point (tail);
                p.Move (i, diraction);
                pList.Add (p);
            }
        }

        internal void Move () {
            Point tail = pList.First ();
            pList.Remove (tail);
            Point head = GetNextPoint ();
            pList.Add (head);

            tail.Clear ();
            head.Draw ();
        }

        public Point GetNextPoint () {
            Point head = pList.Last ();
            Point nextPoint = new Point (head);
            nextPoint.Move (1, diraction);
            return nextPoint;
        }

        public void HandKey (ConsoleKey key) {
            if (key == ConsoleKey.RightArrow) {
                        diraction = Diraction.RIGHT;
                    }
                    else if (key == ConsoleKey.LeftArrow) {
                        diraction = Diraction.LEFT;
                    }
                    else if (key == ConsoleKey.UpArrow) {
                        diraction = Diraction.UP;
                    }
                    else if (key == ConsoleKey.DownArrow) {
                        diraction = Diraction.DOWN;
                    }
        }

        internal bool Eat (Point food) {
            Point head = GetNextPoint ();
            if (head.IsHit (food)) {
                food.sym = head.sym;
                pList.Add (food);
                return true;
            }
            else {
                return false;
            }
        }

        internal bool IsHitTail () {
            var head = pList.Last ();
            for (int i=0; i<pList.Count - 2; i++) {
                if (head.IsHit(pList [i])) {
                    return true;
                }
            }
            return false;
        }
    }
}