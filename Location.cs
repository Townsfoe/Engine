using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public Location(int ID, string Name, string Description, Item ItemRequiredToEnter = null, Quest QuestAvailableHere = null,
            Monster MonsterLivingHere = null)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.ItemRequiredToEnter = ItemRequiredToEnter;
            this.QuestAvailableHere = QuestAvailableHere;
            this.MonsterLivingHere = MonsterLivingHere;
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

        public string Description
        {
            get;
            set;
        }

        public Item ItemRequiredToEnter
        {
            get;
            set;
        }

        public Quest QuestAvailableHere
        {
            get;
            set;
        }

        public Monster MonsterLivingHere
        {
            get;
            set;
        }

        public Location LocationToNorth
        {
            get;
            set;
        }

        public Location LocationToSouth
        {
            get;
            set;
        }

        public Location LocationToEast
        {
            get;
            set;
        }

        public Location LocationToWest
        {
            get;
            set;
        }
        


    }
}
