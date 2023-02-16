using HeroRPGAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroRPGAssignment.ItemClasses
{
    public class Item
    {
        public string? ItemName { get; set; }
        public int RequiredLevel { get; set; } = 1;
        public SlotType Slot { get; set; }
    }
}
