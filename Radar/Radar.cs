using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Radar
{
    class Radar
    {
        Point centre;
        int length;
        public Radar (Point centre, int length) {
            this.centre = centre;
            this.length = length;
        }

        public void Move () {
            List<Point> roll = new List<Point> ();
            ConsoleKeyInfo input;
            do {
                input = Console.ReadKey ();
                for (double alfa=0; alfa<=360; alfa+=30) {

                    for (double i=0; i<=length; i+=2) {
                        double x1 = 2*i*Math.Cos(Radian(alfa));
                        x1 = Math.Truncate (x1);
                        int x = Convert.ToInt32 (x1+centre.x);
                        double y1 = i*Math.Sin(Radian(alfa));
                        y1 = Math.Truncate (y1);
                        int y = Convert.ToInt32 (y1+centre.y);
                        Point p = new Point (x, y, '+');
                        roll.Add (p);
                        p.Draw ();
                    }
                    Thread.Sleep(100);

                    for (int i=0; i<roll.Count(); i++) {
                        Point n = roll [i];
                        n.WipeOff ();
                    }

                    roll.Clear();
                }
            } while (input.Key != ConsoleKey.Escape); 
        }

        public double Radian (double alfa) {
            double betta = alfa*Math.PI/180;
            return betta;
        }
    }
}