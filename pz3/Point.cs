using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz3
{
    public class Point
    {
        private int x { get; }
        private int y { get; }
        private string name { get; }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public string Name { get { return name; } }
    }
}
