using HeroRPGAssignment.Attributes;
using HeroRPGAssignment.Enums;
using HeroRPGAssignment.Exeptions;
using HeroRPGAssignment.ItemClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroRPGAssignment.HeroClasses
{
    public class Mage : Hero
    {

        // Creates herotype Mage
        public Mage(string name) : base()
        {
            this.Name = name;
            this.HeroAttributes = new HeroAttributes(1, 1, 8);
            this.Herotype = HeroType.Mage;
            this.HeroWeapons = new WeaponType[2] { WeaponType.Wand, WeaponType.Staff };
            this.HeroArmors = new ArmorType[1] { ArmorType.Cloth };
            this.ArmorAttributes = new ArmorAttributes(0, 0, 0);
            this.TotalLevelAttributes = new TotalLevelAttributes(0, 0, 0);

            Console.WriteLine($"Hero: {Herotype} {name} created");

        }

        //Levels heros level by +1 and heroAttributes up by Mage attributes (1,1,5)
        public override void LevelUp()
        {
            Level++;
            HeroAttributes.Strength = HeroAttributes.Strength + 1;
            HeroAttributes.Dexterity = HeroAttributes.Dexterity + 1;
            HeroAttributes.Intelligence = HeroAttributes.Intelligence + 5;

            Console.WriteLine($"Level up!");

        }

        // Equips weapon to Heros Equipment weapon slot
        public override void EquipWeapon(Weapon weapon)
        {
            if (!(weapon.RequiredLevel <= this.Level))
            {
                throw new InvalidWeaponExeption("Level is too low");
            }
            if (!HeroWeapons.Contains(weapon.WeaponType))
            {

                throw new InvalidWeaponExeption("Wrong type of weapon");
            }
            else
            {
                Equipment[SlotType.Weapon] = weapon;
                WeaponDamage = weapon.Damage;
                Console.WriteLine($"Weapon: {weapon.ItemName} added to {this.Name}");

            }
        }

        // Equips armor to Heros Equipment armor (body,head or legs) slot
        public override void EquipArmor(Armor armor)
        {
            if (!(armor.RequiredLevel <= this.Level))
            {
                throw new InvalidArmorExeption("Level is too low");
            }
            if (!HeroArmors.Contains(armor.ArmorType))
            {

                throw new InvalidArmorExeption("Wrong type of armor");
            }
            else
            {
                if (armor.Slot == SlotType.Body)
                {
                    Equipment[SlotType.Body] = armor;
                }
                else if (armor.Slot == SlotType.Legs)
                {
                    Equipment[SlotType.Legs] = armor;
                }
                else if (armor.Slot == SlotType.Head)
                {
                    Equipment[SlotType.Head] = armor;
                }

                ArmorAttributes.Strength += armor.ArmorAttributes.Strength;
                ArmorAttributes.Dexterity += armor.ArmorAttributes.Dexterity;
                ArmorAttributes.Intelligence += armor.ArmorAttributes.Intelligence;
                Console.WriteLine($"Armor: {armor.ItemName} added to {this.Name} {armor.Slot}");
            }

        }

        // Calculates heros total Attributes (Yes, I know is not correctly calculated if armor or weapon change...)
        public override void TotalAttributes()
        {

            TotalLevelAttributes.Strength = HeroAttributes.Strength + ArmorAttributes.Strength;
            TotalLevelAttributes.Dexterity = HeroAttributes.Dexterity + ArmorAttributes.Dexterity;
            TotalLevelAttributes.Intelligence = HeroAttributes.Intelligence + ArmorAttributes.Intelligence;

        }

        // Calculates heros damage
        public override double Damage()
        {
            //For MAGE
            TotalAttributes();

            double damage = Convert.ToDouble(WeaponDamage) * (1.0 + Convert.ToDouble(TotalLevelAttributes.Intelligence) / 100.0);
            damage = Math.Round(damage, 2);

            return damage;
        }


        // Displays Heros statistics
        public override void Display()
        {
            TotalAttributes();
            StringBuilder displayHero = new StringBuilder();
            displayHero.AppendLine($"********************");
            displayHero.AppendLine($"HERO DETAILS:");
            displayHero.AppendLine($"Name: {Name}");
            displayHero.AppendLine($"Type: {Herotype} ");
            displayHero.AppendLine($"Level: {Level} ");
            displayHero.AppendLine($"Total Strength: {TotalLevelAttributes.Strength} ");
            displayHero.AppendLine($"Total Dexterity: {TotalLevelAttributes.Dexterity} ");
            displayHero.AppendLine($"Total Intelligence: {TotalLevelAttributes.Intelligence} ");
            displayHero.AppendLine($"Damage: {Damage()} ");
            displayHero.AppendLine($"********************");


            Console.WriteLine(displayHero);
        }


    }
}
