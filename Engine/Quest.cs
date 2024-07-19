using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //Quest Class created as public for program wide use
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }

        //constructor code, public use, Quest is the name, id, name, description, rewardExperiencePoints, rewardGold parameters ready for values of the set datatype
        public Quest (int iD, string name, string description, int rewardExperiencePoints, int rewardGold)
        {
            ID = iD;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
        }
    }
}
