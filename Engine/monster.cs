using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //defines object "monster"
    public class monster : livingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int maximumDamage { get; set; }
        public int rewardXP { get; set; }
        public int rewardGold { get; set; }

    }
}
