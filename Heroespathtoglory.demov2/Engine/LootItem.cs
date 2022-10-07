using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class LootItem
    {
        public Item Details { get; set; }
        public int DropPrecentage { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootItem(Item details, int dropprecentage, bool isdefaultitem)
        {
            Details = details;
            DropPrecentage = dropprecentage;
            IsDefaultItem = isdefaultitem;
        }
    }
}
