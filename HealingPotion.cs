using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        public HealingPotion(int ID, string Name, string NamePlural, int AmountToHeal) : base(ID,Name,NamePlural)
        {
            this.AmountToHeal = AmountToHeal;
        }        
        public int AmountToHeal
        {
            get;
            set;
        }
    }
}
