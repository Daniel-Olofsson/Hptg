using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }

        // construct values for monsters
        public Monster(int id, string name, int maximumdamage, int rewardexperiencepoints, int rewardgold, int currenthitpoints, int maximumhitpoints) : base(currenthitpoints, maximumhitpoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumdamage;
            RewardExperiencePoints = rewardexperiencepoints;
            RewardGold = rewardgold;


            LootTable = new List<LootItem>();
        }
    }
}
