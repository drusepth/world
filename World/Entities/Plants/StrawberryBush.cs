using System;
using System.Collections.Generic;
using World.Entities.Fruit;

namespace World.Entities.Plants
{
    class StrawberryBush: Bush
    {
        List<Strawberry> berries;       // Current number of apples this tree holds
        int max_berries = 10;           // Maximum number of apples this tree can hold
        int spawn_rate = 2;             // 1 per spawn_rate ticks will spawn a berry

        public StrawberryBush()
        {

        }

        public override void Tick()
        {
            base.Tick();

            // Spawn more apples at random
            if (isBush && berries.Count < max_berries && RNG.Next(spawn_rate) < 1)
            {
                berries.Add(new Strawberry());
            }
        }
    }
}
