﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon : Item
    {

        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public Weapon(int id, string name, string nameplural, int price, int minimumdamage, int maximumdamage) :base(id, name , nameplural, price)
        {
            MinimumDamage = minimumdamage;
            MaximumDamage = maximumdamage;
        }
    }
}
