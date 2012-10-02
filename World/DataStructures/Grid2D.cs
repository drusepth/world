using System;
using System.Collections.Generic;

namespace World.DataStructures
{
    class Grid2D<T> : List<T> where T : new()
    {
        int width, length; // x, y

        public Grid2D(int x, int y) 
        {
            width = x;
            length = y;

            Initialize(x * y);
        }

        // Prepopulate the grid with T so any of them can be used immediately
        public void Initialize(int num_t)
        {
            for (int i = 0; i < num_t; i++)
            {
                this.Add(new T());
            }
        }

        // Returns the T that exists in the grid at a specific coordinate
        public T At(int x, int y)
        {
            return this[x * width + y];
        }

        public T At(Location2D location)
        {
            return At(location.X, location.Y);
        }
    }
}
