using System;
using System.Collections.Generic;

namespace World.DataStructures
{
    public abstract class Entity
    {
        // Number of ticks this entity has survived
        protected int age;

        // List of all possible states this entity can be in
        protected List<String> States;

        // List of states automatically reached by age increases
        protected Dictionary<int, String> life_cycle;

        // Current state of this entity
        protected String state;

        // This entity's RNG
        protected Random RNG = new Random();

        public Entity()
        {
            age = 0;
        }

        // Overridable function to run on each game tick
        public virtual void Tick()
        {
            Grow();
        }

        public virtual void Grow()
        {
            age++;

            // Grow to the next stage in the entity's life cycle
            foreach (var potential_state in life_cycle)
            {
                if (age > potential_state.Key)
                {
                    state = potential_state.Value;
                }
            }
        }
    }
}
