using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Spell : Item

    {
        
        public string Description { get; set; }
        public string SpellType { get; set; }
        public int ManaCost { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        

        public Spell(int id, string name, string nameplural, int price, string description, string spellType, int manaCost, int minDamage, int maxDamage) : base(id, name, nameplural, price)
        {

            Description = description;
            SpellType = spellType;
            ManaCost = manaCost;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
    }
    
}
