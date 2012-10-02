using System;
using World.Entities.Fruit;
using System.Collections.Generic;

namespace World.Entities.Plants
{
    class PearTree: Tree
    {
        List<Pear> pears;      // Current number of apples this tree holds
        int max_pears = 10;    // Maximum number of apples this tree can hold
        int spawn_rate = 10;   // 1 per spawn_rate ticks will spawn an apple

        public PearTree()
        {

        }

        public override void Tick()
        {
            base.Tick();

            // Spawn more apples at random
            if (isTree && pears.Count < max_pears && RNG.Next(spawn_rate) < 1)
            {
                pears.Add(new Pear());
            }
        }
    }
}
