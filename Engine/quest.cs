using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Defines object "quest"
    public class quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int rewardXP { get; set; }
        public int rewardGold { get; set; }

        public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardXP = rewardXP;
            RewardGold = rewardGold;
        }

    }
}
