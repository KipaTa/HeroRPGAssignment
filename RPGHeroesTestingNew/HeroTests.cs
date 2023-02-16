using HeroRPGAssignment.Attributes;
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
    public class HeroTests
    {
        // MAGE TESTS

        [Fact]
        public void MageCreate_CreateMageAndCheckName_ShouldReturnValid()
        {
            //Arrange
            var NewHero = "Gandalf";
            var expected = "Gandalf";

            //Act
            Mage heroObj = new(NewHero);

            //Assert
            Assert.Equal(expected, heroObj.Name);
        }

        [Fact]
        public void MageCreate_CreateMageAndCheckHeroAttributesSum_ShouldReturnTen()
        {
            //Arrange
            var NewHero = "Gandalf";
            var expectedSumOfAttributes = 10;

            //Act
            Mage heroObj = new(NewHero);
            var sumOfMageHeroAttributes = heroObj.HeroAttributes.Strength + heroObj.HeroAttributes.Dexterity + heroObj.HeroAttributes.Intelligence;

            //Assert
            Assert.Equal(expectedSumOfAttributes, sumOfMageHeroAttributes);
        }


        [Fact]
        public void MageLevelUp_MageLevelUpLevelIncreasedByOne_ShouldReturnTwo()
        {
            //Arrange
            var NewHero = "Gandalf";
            var expected = 2;

            //Act
            Mage heroObj = new(NewHero);
            heroObj.LevelUp();

            //Assert
            Assert.Equal(expected, heroObj.Level);
        }

        // RANGER TESTS

        [Fact]
        public void RangerCreate_CreateRangerAndCheckName_ShouldReturnValid()
        {
            //Arrange
            var NewHero = "Ren";
            var expected = "Ren";

            //Act
            Ranger heroObj = new(NewHero);

            //Assert
            Assert.Equal(expected, heroObj.Name);
        }

        [Fact]
        public void RangerCreate_CreateRangerAndCheckHeroAttributesSum_ShouldReturnNine()
        {
            //Arrange
            var NewHero = "Ren";
            var expectedSumOfAttributes = 9;

            //Act
            Ranger heroObj = new(NewHero);
            var sumOfMageHeroAttributes = heroObj.HeroAttributes.Strength + heroObj.HeroAttributes.Dexterity + heroObj.HeroAttributes.Intelligence;

            //Assert
            Assert.Equal(expectedSumOfAttributes, sumOfMageHeroAttributes);
        }


        [Fact]
        public void RangerLevelUp_RangerLevelUpLevelIncreasedByOne_ShouldReturnTwo()
        {
            //Arrange
            var NewHero = "Ren";
            var expected = 2;

            //Act
            Ranger heroObj = new(NewHero);
            heroObj.LevelUp();

            //Assert
            Assert.Equal(expected, heroObj.Level);
        }

        // ROGUE TESTS

        [Fact]
        public void RogueCreate_CreateRogueAndCheckName_ShouldReturnValid()
        {
            //Arrange
            var NewHero = "Robin";
            var expected = "Robin";

            //Act
            Rogue heroObj = new(NewHero);

            //Assert
            Assert.Equal(expected, heroObj.Name);
        }

        [Fact]
        public void RogueCreate_CreateRogueAndCheckHeroAttributesSum_ShouldReturnNine()
        {
            //Arrange
            var NewHero = "Robin";
            var expectedSumOfAttributes = 9;

            //Act
            Rogue heroObj = new(NewHero);
            var sumOfMageHeroAttributes = heroObj.HeroAttributes.Strength + heroObj.HeroAttributes.Dexterity + heroObj.HeroAttributes.Intelligence;

            //Assert
            Assert.Equal(expectedSumOfAttributes, sumOfMageHeroAttributes);
        }


        [Fact]
        public void RogueLevelUp_RogueLevelUpLevelIncreasedByOne_ShouldReturnTwo()
        {
            //Arrange
            var NewHero = "Robin";
            var expected = 2;

            //Act
            Rogue heroObj = new(NewHero);
            heroObj.LevelUp();

            //Assert
            Assert.Equal(expected, heroObj.Level);
        }

        // WARRIOR TESTS

        [Fact]
        public void WarriorCreate_CreateWarriorAndCheckName_ShouldReturnValid()
        {
            //Arrange
            var NewHero = "Violet";
            var expected = "Violet";

            //Act
            Warrior heroObj = new(NewHero);

            //Assert
            Assert.Equal(expected, heroObj.Name);
        }

        [Fact]
        public void WarriorCreate_CreateWarriorAndCheckHeroAttributesSum_ShouldReturnEight()
        {
            //Arrange
            var NewHero = "Violet";
            var expectedSumOfAttributes = 8;

            //Act
            Warrior heroObj = new(NewHero);
            var sumOfMageHeroAttributes = heroObj.HeroAttributes.Strength + heroObj.HeroAttributes.Dexterity + heroObj.HeroAttributes.Intelligence;

            //Assert
            Assert.Equal(expectedSumOfAttributes, sumOfMageHeroAttributes);
        }


        [Fact]
        public void WarriorLevelUp_WarriorLevelUpLevelIncreasedByOne_ShouldReturnTwo()
        {
            //Arrange
            var NewHero = "Violet";
            var expected = 2;

            //Act
            Warrior heroObj = new(NewHero);
            heroObj.LevelUp();

            //Assert
            Assert.Equal(expected, heroObj.Level);
        }

        // STATS TESTS

        [Fact]

        public void MageTotalAttributes_MageLevelOneNoEquipmentTotalAttributes_ShouldBeOneOneEight()
        {
            //Arrange
            var NewHero = "Gandalf";
            string expected = "1,1,8";

            //Act
            Mage heroObj = new(NewHero);
            string mageBasicStats = heroObj.HeroAttributes.Strength + "," + heroObj.HeroAttributes.Dexterity + "," + heroObj.HeroAttributes.Intelligence;

            //Assert
            Assert.Equal(expected, mageBasicStats);
        }

        [Fact]
        public void MageTotalAttributes_MageLevelOneOneEquipmentTotalAttributes_ShouldBeThreeTwoNine()
        {
            //Arrange
            var NewHero = "Gandalf";
            string expected = "3,2,9";

            //Act
            Mage heroObj = new(NewHero);
            Armor armor1 = new Armor("Jacket", 1, HeroRPGAssignment.Enums.ArmorType.Cloth, HeroRPGAssignment.Enums.SlotType.Body, new HeroAttributes() { Strength = 2, Dexterity = 1, Intelligence = 1 });
            heroObj.EquipArmor(armor1);
            heroObj.TotalAttributes();
            string mageStatsWithArmor = heroObj.TotalLevelAttributes.Strength + "," + heroObj.TotalLevelAttributes.Dexterity + "," + heroObj.TotalLevelAttributes.Intelligence;

            //Assert
            Assert.Equal(expected, mageStatsWithArmor);
        }

        [Fact]
        public void MageTotalAttributes_MageLevelOneTwoEquipmentTotalAttributes_ShouldBeSevenFiveTen()
        {
            //Arrange
            var NewHero = "Gandalf";
            string expected = "7,5,10";

            //Act
            Mage heroObj = new(NewHero);
            Armor armor1 = new Armor("Jacket", 1, HeroRPGAssignment.Enums.ArmorType.Cloth, HeroRPGAssignment.Enums.SlotType.Body, new HeroAttributes() { Strength = 2, Dexterity = 1, Intelligence = 1 });
            Armor armor2 = new Armor("Boots", 1, HeroRPGAssignment.Enums.ArmorType.Cloth, HeroRPGAssignment.Enums.SlotType.Legs, new HeroAttributes() { Strength = 4, Dexterity = 3, Intelligence = 1 });
            heroObj.EquipArmor(armor1);
            heroObj.EquipArmor(armor2);
            heroObj.TotalAttributes();
            string mageStatsWithArmor = heroObj.TotalLevelAttributes.Strength + "," + heroObj.TotalLevelAttributes.Dexterity + "," + heroObj.TotalLevelAttributes.Intelligence;

            //Assert
            Assert.Equal(expected, mageStatsWithArmor);
        }





        [Fact]
        public void DisplayHeroStats_DisplayHeroStatsOfMageLevelTwoWithWaeaponAndArmor_ShouldUseStringBuilderToDisplayStats()
        {
            //Arrange
            var NewHero = "Gandalf";
            var NewArmor = "Helmet";
            var NewWeapon = "Elderwand";

            //Act
            Mage heroObj = new(NewHero);
            heroObj.LevelUp();
            Armor armor1 = new Armor(NewArmor, 2, HeroRPGAssignment.Enums.ArmorType.Cloth, HeroRPGAssignment.Enums.SlotType.Head, new HeroAttributes() { Strength = 2, Dexterity = 1, Intelligence = 1 });
            Weapon weapon1 = new Weapon(NewWeapon, 1, HeroRPGAssignment.Enums.WeaponType.Wand, 7);
            heroObj.EquipArmor(armor1);
            heroObj.EquipWeapon(weapon1);

            heroObj.TotalAttributes();
            StringBuilder displayHero = new StringBuilder();
            displayHero.AppendLine($"********************");
            displayHero.AppendLine($"HERO DETAILS:");
            displayHero.AppendLine($"Name: {heroObj.Name}");
            displayHero.AppendLine($"Type: {heroObj.Herotype} ");
            displayHero.AppendLine($"Level: {heroObj.Level} ");
            displayHero.AppendLine($"Total Strength: {heroObj.TotalLevelAttributes.Strength} ");
            displayHero.AppendLine($"Total Dexterity: {heroObj.TotalLevelAttributes.Dexterity} ");
            displayHero.AppendLine($"Total Intelligence: {heroObj.TotalLevelAttributes.Intelligence} ");
            displayHero.AppendLine($"Damage: {heroObj.Damage()} ");
            displayHero.AppendLine($"********************");

            String expected = displayHero + "\r\n";

            StringWriter stringdisplay = new StringWriter();

            Console.SetOut(stringdisplay);
            heroObj.Display();
            String output = stringdisplay.ToString();

            //Assert
            Assert.Equal(expected, output);
        }

    }
}
