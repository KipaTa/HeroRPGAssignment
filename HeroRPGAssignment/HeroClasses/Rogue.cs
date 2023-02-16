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
    public class Rogue : Hero
    {

        // Creates herotype Rogue
        public Rogue(string name) : base()
        {
            this.Name = name;
            this.HeroAttributes = new HeroAttributes(2, 6, 1);
            this.Herotype = HeroType.Rogue;
            this.HeroWeapons = new WeaponType[2] { WeaponType.Dagger, WeaponType.Sword };
            this.HeroArmors = new ArmorType[2] { ArmorType.Leather, ArmorType.Mail };
            this.ArmorAttributes = new ArmorAttributes(0, 0, 0);
            this.TotalLevelAttributes = new TotalLevelAttributes(0, 0, 0);

            Console.WriteLine($"Hero: {Herotype} {name} created");

        }

        //Levels heros level by +1 and heroAttributes up by Rogue attributes (1,4,1)
        public override void LevelUp()
        {
            Level++;
            HeroAttributes.Strength = HeroAttributes.Strength + 1;
            HeroAttributes.Dexterity = HeroAttributes.Dexterity + 4;
            HeroAttributes.Intelligence = HeroAttributes.Intelligence + 1;

            Console.WriteLine("Level up!");

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

        // Calculates heros total Attributes (Yes, I know is not correctly calculated...)
        public override void TotalAttributes()
        {

            TotalLevelAttributes.Strength = HeroAttributes.Strength + ArmorAttributes.Strength;
            TotalLevelAttributes.Dexterity = HeroAttributes.Dexterity + ArmorAttributes.Dexterity;
            TotalLevelAttributes.Intelligence = HeroAttributes.Intelligence + ArmorAttributes.Intelligence;

        }

        // Calculates heros damage
        public override double Damage()
        {
            //For ROGUE
            TotalAttributes();

            double damage = Convert.ToDouble(WeaponDamage) * (1.0 + Convert.ToDouble(TotalLevelAttributes.Dexterity) / 100.0);
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
