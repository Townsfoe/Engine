using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {        
        public Weapon(int ID, string Name, string NamePlural, int MinimumDamage, int MaximumDamage) : base(ID,Name,NamePlural)
        {
            this.MinimumDamage = MinimumDamage;
            this.MaximumDamage = MaximumDamage;
        }
        public int MinimumDamage
        {
            get;
            set;
        }

        public int MaximumDamage
        {
            get;
            set;
        }
    }
}
