using System;
using System.Collections;
using World.DataStructures;
using System.Collections.Generic;

namespace World.Entities
{
    class Tree: Entity
    {
        public Tree()
        {
            
        }

        // Initialize all the default values for Trees
        private void Initialize()
        {
            base.States = new List<String>()
            {
                "Seed", "Sapling", "Springling", "Tree", "Withering", "Dead"
            };

            base.life_cycle = new Dictionary<int, string>()
            {
                { 0, States[0] },
                { 10, States[1] },
                { 20, States[2] },
                { 30, States[3] },
                { 70, States[4] },
                { 100, States[5] }
            };
        }

        public override void Tick()
        {
            base.Tick();
        }

        protected bool isSeed { get { return state == "Seed"; } }
        protected bool isSapling { get { return state == "Sapling"; } }
        protected bool isSpringling { get { return state == "Springling"; } }
        protected bool isTree { get { return state == "Tree"; } }
        protected bool isWithering { get { return state == "Withering"; } }
        protected bool isDead { get { return state == "Dead"; } }

    }
}
