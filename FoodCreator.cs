using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Projeck_2
{
    class FoodCreator
    {
        int mapWindht;
        int mapHeight;
        char sym;

        Random random = new Random ();

        public FoodCreator (int mapWindht, int mapHeight, char sym) {
            this.mapWindht = mapWindht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood () {
            int x = random.Next (3, mapWindht - 3);
            int y = random.Next (3, mapHeight - 3);
            return new Point (x, y, sym);   
        }
    }
}