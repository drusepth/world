using System;
using System.Collections.Generic;

namespace World.DataStructures
{
    class Grid3D<T>: List<T> where T : new()
    {
        int width, length, height; // x, y, z

        public Grid3D(int x, int y, int z) 
        {
            Initialize(x, y, z);
        }

        // Prepopulate the grid with T so any of them can be used immediately
        public void Initialize(int x, int y, int z)
        {
            for (int i = 0; i < x * y * z; i++)
            {
                this.Add(new T());
            }
        }

        // Returns the T that exists in the grid at a specific coordinate
        public T At(int x, int y, int z)
        {
            return this[x * width * length + y * width + z];
        }

        public T At(Location3D location)
        {
            return At(location.X, location.Y, location.Z);
        }
    }
}
