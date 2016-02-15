using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item
    {
        public Item(int ID, string Name, string NamePlural)
        {
            this.ID = ID;
            this.Name = Name;
            this.NamePlural = NamePlural;
        }
            
        public int ID
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string NamePlural
        {
            get;
            set;
        }
    }
}
