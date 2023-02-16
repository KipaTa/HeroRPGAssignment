using HeroRPGAssignment.Attributes;
using HeroRPGAssignment.Enums;
using HeroRPGAssignment.ItemClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroRPGAssignment.HeroClasses
{
    public abstract class Hero
    {
        public string? Name { get; set; }
        public int Level { get; set; } = 1;
        public HeroType Herotype { get; set; }
        public HeroAttributes HeroAttributes { get; set; }

        public WeaponType[]? HeroWeapons;

        public ArmorType[]? HeroArmors;

        public Dictionary<Enums.SlotType, Item>? Equipment = new Dictionary<Enums.SlotType, Item>()
        {
            { SlotType.Weapon, null },
            { SlotType.Head, null },
            { SlotType.Body, null },
            { SlotType.Legs, null }
        };

        public ArmorAttributes ArmorAttributes { get; set; }

        public TotalLevelAttributes TotalLevelAttributes { get; set; }


        public int WeaponDamage = 1;


        public abstract void LevelUp();

        public abstract void EquipWeapon(Weapon weapon);

        public abstract void EquipArmor(Armor armor);

        public abstract void TotalAttributes();

        public abstract double Damage();



        public abstract void Display();



    }
}
