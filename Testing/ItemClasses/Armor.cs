using HeroRPGAssignment.Attributes;
using HeroRPGAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroRPGAssignment.ItemClasses
{
    public class Armor : Item
    {
        public ArmorType ArmorType { get; set; }
        public HeroAttributes ArmorAttributes { get; set; }

        public int totalArmorAttribute { get; set; }



        public Armor(string armorName, int requiredLevel, ArmorType type, SlotType slot, HeroAttributes armorAttributes) : base()
        {
            ItemName = armorName;
            RequiredLevel = requiredLevel;
            ArmorType = type;
            Slot = slot;
            ArmorAttributes = armorAttributes;



            Console.WriteLine($"New armor {ItemName} created");
        }


    }
}
