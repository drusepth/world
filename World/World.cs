using System;
using World.DataStructures;
using System.Windows.Forms;
using System.Collections.Generic;

namespace World
{
    class World
    {
        // World configurations
        int world_width  = 10; // x
        int world_length = 10; // y
        int world_height = 1;  // z

        // Instance variables
        Grid3D<Tile> tiles;
        List<Entity> entities;

        // Big Bang
        public World()
        {
            Reset();
        }

        // Add an entity to the world
        public void AddEntity(Entity entity, Location3D location)
        {
            // If the target tile will accept the entity,
            if (tiles.At(location).AddEntity(entity))
            {
                // Track the entity globally
                entities.Add(entity);
            }
        }

        // Destroy everything, reset to initial values
        private void Reset()
        {
            tiles = new Grid3D<Tile>(world_width, world_length, world_height);
            entities = new List<Entity>();
        }

        // Draw a visual representation of the World to a visualizer form
        public void Repaint(Form frm) 
        {

        }
    }
}
