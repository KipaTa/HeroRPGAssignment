using HeroRPGAssignment.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroRPGAssignment.ItemClasses
{
    public class Weapon : Item
    {

        public WeaponType WeaponType { get; set; }
        public int Damage { get; set; }

        public new SlotType Slot { get; set; }


        public Weapon(string weaponName, int requiredLevel, WeaponType type, int damage) : base()
        {
            ItemName = weaponName;
            RequiredLevel = requiredLevel;
            Slot = SlotType.Weapon;
            WeaponType = type;
            this.Damage = damage;
            Console.WriteLine($"New weapon {ItemName} created");
        }
    }
}
