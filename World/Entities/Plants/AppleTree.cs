using System;
using World.Entities.Fruit;
using System.Collections.Generic;

namespace World.Entities
{
    class AppleTree: Tree
    {
        List<Apple> apples;     // Current number of apples this tree holds
        int max_apples = 10;    // Maximum number of apples this tree can hold
        int spawn_rate = 5;     // 1 per spawn_rate ticks will spawn an apple

        public AppleTree()
        {

        }

        public override void Tick()
        {
            base.Tick();

            // Spawn more apples at random
            if (isTree && apples.Count < max_apples && RNG.Next(spawn_rate) < 1)
            {
                apples.Add(new Apple());
            }
        }
    }
}
