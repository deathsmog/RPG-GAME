using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //Player Class created as public for program wide use
    public class Player : LivingCreature
    {
        //The attributes set as public Integers for our class, their names, and the get;set to read and write the values.
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

    }
}
