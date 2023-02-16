using HeroRPGAssignment.Attributes;
using HeroRPGAssignment.Enums;
using HeroRPGAssignment.Exeptions;
using HeroRPGAssignment.HeroClasses;
using HeroRPGAssignment.ItemClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RPGHeroesTestingNew
{
    public class ItemTests
    {
        //WEAPON TESTS

        [Fact]
        public void CreateWeapon_CreateSwordAndCheckName_ShouldReturnValid()
        {
            //Arrange
            var NewWeapon = "Narsil";
            var expected = "Narsil";

            //Act
            Weapon weapon1 = new Weapon(NewWeapon, 1, HeroRPGAssignment.Enums.WeaponType.Sword, 7);

            //Assert
            Assert.Equal(expected, weapon1.ItemName);
        }

        [Fact]
        public void EquipWeapon_EquipWeaponWandToMageEquipmentSlotWeapon_ShouldReturnWandName()
        {
            //Arrange
            var NewHero = "Gandalf";
            var NewWand = "Elderwand";
            var expected = "Elderwand";

            //Act
            Mage heroObj = new(NewHero);
            Weapon weapon1 = new Weapon(NewWand, 1, HeroRPGAssignment.Enums.WeaponType.Wand, 7);
            heroObj.EquipWeapon(weapon1);

            //Assert
            Assert.Equal(expected, heroObj.Equipment[SlotType.Weapon].ItemName);
        }

        [Fact]
        public void EquipWeapon_EquipWeaponSwordToMageEquipmentSlotWeapon_ShouldThrowInvalidWeaponException()
        {
            //Arrange
            var NewHero = "Gandalf";
            var NewSword = "Narsil";

            //Act
            Mage heroObj = new(NewHero);
            Weapon weapon1 = new Weapon(NewSword, 1, HeroRPGAssignment.Enums.WeaponType.Sword, 7);


            //Assert
            Assert.Throws<InvalidWeaponExeption>(() => heroObj.EquipWeapon(weapon1));
        }

        [Fact]
        public void EquipWeapon_EquipWeaponLevelTwoWandToMageEquipmentSlotWeapon_ShouldThrowInvalidWeaponException()
        {
            //Arrange
            var NewHero = "Gandalf";
            var NewWand = "Elderwand";

            //Act
            Mage heroObj = new(NewHero);
            Weapon weapon1 = new Weapon(NewWand, 2, HeroRPGAssignment.Enums.WeaponType.Sword, 7);

            //Assert
            Assert.Throws<InvalidWeaponExeption>(() => heroObj.EquipWeapon(weapon1));
        }

        // ARMOR TESTS
        [Fact]
        public void CreateArmor_CreateBodyArmorAndCheckName_ShouldReturnValid()
        {
            //Arrange
            var NewArmor = "ChestPlate";
            var expected = "ChestPlate";

            //Act
            Armor armor1 = new Armor(NewArmor, 1, HeroRPGAssignment.Enums.ArmorType.Plate, HeroRPGAssignment.Enums.SlotType.Body, new HeroAttributes() { Strength = 2, Dexterity = 1, Intelligence = 1 });

            //Assert
            Assert.Equal(expected, armor1.ItemName);
        }

        [Fact]
        public void EquipArmor_EquipArmorHelmetToWarriorEquipmentSlotArmorHead_ShouldReturnArmorName()
        {
            //Arrange
            var NewHero = "Violet";
            var NewArmor = "Helmet";
            var expected = "Helmet";

            //Act
            Warrior heroObj = new(NewHero);
            Armor armor1 = new Armor(NewArmor, 1, HeroRPGAssignment.Enums.ArmorType.Plate, HeroRPGAssignment.Enums.SlotType.Head, new HeroAttributes() { Strength = 2, Dexterity = 1, Intelligence = 1 });
            heroObj.EquipArmor(armor1);

            //Assert
            Assert.Equal(expected, heroObj.Equipment[SlotType.Head].ItemName);
        }

        [Fact]
        public void EquipArmor_EquipArmorByMailToMageEquipmentSlotArmor_ShouldThrowInvalidArmorException()
        {
            //Arrange
            var NewHero = "Gandalf";
            var NewArmor = "Helmet"; ;

            //Act
            Mage heroObj = new(NewHero);
            Armor armor1 = new Armor(NewArmor, 2, HeroRPGAssignment.Enums.ArmorType.Mail, HeroRPGAssignment.Enums.SlotType.Head, new HeroAttributes() { Strength = 2, Dexterity = 1, Intelligence = 1 });

            //Assert
            Assert.Throws<InvalidArmorExeption>(() => heroObj.EquipArmor(armor1));
        }


        [Fact]
        public void EquipArmor_EquipArmorLevelTwoArmorToMageEquipmentSlotArmor_ShouldThrowInvalidArmorException()
        {
            //Arrange
            var NewHero = "Gandalf";
            var NewArmor = "Helmet"; ;

            //Act
            Mage heroObj = new(NewHero);
            Armor armor1 = new Armor(NewArmor, 2, HeroRPGAssignment.Enums.ArmorType.Cloth, HeroRPGAssignment.Enums.SlotType.Head, new HeroAttributes() { Strength = 2, Dexterity = 1, Intelligence = 1 });

            //Assert
            Assert.Throws<InvalidArmorExeption>(() => heroObj.EquipArmor(armor1));
        }


    }
}
