using System;
using System.Collections.Generic;

namespace World.DataStructures
{
    class Grid4D<T> : List<T> where T : new()
    {
        int width, length, height; // x, y, z

        public Grid4D(int x, int y, int z, int t)
        {
            Initialize(x, y, z, t);
        }

        // Prepopulate the grid with T so any of them can be used immediately
        public void Initialize(int x, int y, int z, int t)
        {
            for (int i = 0; i < x * y * z * t; i++)
            {
                this.Add(new T());
            }
        }

        // Returns the T that exists in the grid at a specific coordinate
        public T At(int x, int y, int z, int t)
        {
            return this[x * width * length * height + y * width * length + z * width + t];
        }

        public T At(Location4D location)
        {
            return At(location.X, location.Y, location.Z, location.T);
        }
    }
}
