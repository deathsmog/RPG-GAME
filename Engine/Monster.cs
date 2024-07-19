using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //Monster Class created as public for program wide use
    public class Monster : LivingCreature
    {
        //The attributes set as public Integers for our class, their names, and the get;set to read and write the values.
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
    }
}
