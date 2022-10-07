using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Item ItemRequierdToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToGoUp { get; set; }
        public Location LocationToGoRight { get; set; }
        public Location LocationToGoDown { get; set; }
        public Location LocationToGoLeft { get; set; }
        public string PlanetImage { get; set; }

        // constructs values for locations
        public Location(int id, string name, string description, Item itemrequierdtoenter = null, Quest questavailablehere = null, Monster monsterlivinghere = null, string planetimage = "a1.png")
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequierdToEnter = itemrequierdtoenter;
            QuestAvailableHere = questavailablehere;
            MonsterLivingHere = monsterlivinghere;
            PlanetImage = planetimage;
        }
    }
}
