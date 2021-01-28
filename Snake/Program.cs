using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Projeck_2
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.SetWindowSize (80,26);
            Console.SetBufferSize (80, 26);

            Walls walls = new Walls (80, 26);
            walls.Draw ();

            Point p = new Point (8, 10, 'o');
            Snake Pet = new Snake (p, 4, Diraction.RIGHT);
            Pet.Draw ();

            FoodCreator foodCreator = new FoodCreator (80, 26, '%');
            Point food = foodCreator.CreateFood ();
            food.Draw ();

            while (true) {
                if (walls.IsHit(Pet) || Pet.IsHitTail() ) {
                    break;
                }
                if (Pet.Eat (food)) {
                    food = foodCreator.CreateFood ();
                    food.Draw ();
                }
                else {
                    Pet.Move ();
                }
                Thread.Sleep (100);
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo key = Console.ReadKey ();
                    Pet.HandKey (key.Key);
                }
            }
            Console.SetCursorPosition (30, 12);
            Console.WriteLine ("The end!");            

            Console.ReadKey ();
        }

    }
}
