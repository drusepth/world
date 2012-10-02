using System;
using System.Collections.Generic;
using World.DataStructures;

namespace World.Entities.Fruit
{
    class Fruit: Entity
    {
        public Fruit()
        {
            Initialize();
        }

        // Initialize all the default values for Fruit
        private void Initialize()
        {
            base.States = new List<String>()
            {
                "Fresh", "Ripe", "Normal", "Withering", "Rotten"
            };

            base.life_cycle = new Dictionary<int, string>()
            {
                { 0, States[0] },
                { 10, States[1] },
                { 15, States[2] },
                { 40, States[3] },
                { 50, States[4] }
            };
        }

        // What happens when an entity eats this fruit, to override per-fruit
        public virtual void Eat(Entity eater)
        {
            
        }

        // How the fruit ages per tick
        public override void Tick()
        {
            base.Tick();
        }
    }
}
