using System;

namespace World.DataStructures
{
    abstract class Location
    {
        protected int x, y;

        public Location() { }

        public int X { get { return x; } }
        public int Y { get { return y; } }
    }

    class Location2D: Location
    {
        public Location2D(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }
    }

    class Location3D: Location
    {
        int z; // height

        public Location3D(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int Z { get { return z; } }
    }

    class Location4D: Location
    {
        int z, t; // height, time

        public Location4D(int _x, int _y, int _z, int _t)
        {
            x = _x;
            y = _y;
            z = _z;
            t = _t;
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int Z { get { return z; } }
        public int T { get { return t; } }
    }
}
