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

        //constructor for HealingPotion with amountToHeal as a paramater as well as id,name,namePlural as paramaters 
        //id,name and namePlural paramaters are also defined in the base() section to pass the values to the base class
        public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
