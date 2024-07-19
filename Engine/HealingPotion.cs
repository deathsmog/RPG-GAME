using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    //HealingPotion Class created as public for program wide use
    //base class of Item 
    public class HealingPotion : Item
    {

        public int AmountToHeal { get; set; }
    }
}
