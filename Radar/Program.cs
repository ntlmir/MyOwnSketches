using System;

namespace Radar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Point centre = new Point (40,20,'+');
            centre.Draw ();

            Radar wow = new Radar (centre, 10);
            wow.Move ();
            

            Console.ReadLine ();        
        }
    }
}
