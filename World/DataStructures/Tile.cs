using System;
using World.DataStructures;
using System.Collections.Generic;

namespace World.DataStructures
{
    class Tile
    {
        // Energy requirements for specialized tiles to use for standardized purposes
        protected enum Resistance {
            None = 0,
            Miniscule = 1,
            Minor = 10,
            Average = 20,
            Large = 30,
            Great = 50,
            Impossible = double.PositiveInfinity
        };

        Resistance movement_resistance = Resistance.Impossible; // Energy required to move through this space
        List<Entity> entities = new List<Entity>();             // All entities located at this tile

        public Tile()
        {
            entities = new List<Entity>();
        }

        // Try to add an entity to this tile. Returns true/false on success
        public bool AddEntity(Entity entity)
        {
            if (CanAddEntity(entity))
            {
                entities.Add(entity);
                return true;
            }

            return false;
        }

        public bool CanAddEntity(Entity entity)
        {
            return !entities.Contains(entity);
        }
    }
}
