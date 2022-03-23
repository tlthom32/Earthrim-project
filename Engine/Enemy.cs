using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //defines object "Enemy"
    public class Enemy : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardXP { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootTable { get; set; }


        public Enemy(int id, string name, int maximumDamage, int rewardXP, int rewardGold, int currentHitPoints, int maximumHitPoints) : base(currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardXP = rewardXP;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();

        }

    }
}
