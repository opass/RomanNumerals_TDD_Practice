using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class RomanNumeralsConverterTest
    {
        [TestMethod]
        public void Number_1_Should_Output_Single_Character()
        {
            NumberToRomanNumeralShouldBe(1, "I");
        }

        [TestMethod]
        public void Number_5_Should_Output_Single_Character()
        {
            NumberToRomanNumeralShouldBe(5, "V");
        }

        [TestMethod]
        public void Number_10_Should_Output_Single_Character()
        {
            NumberToRomanNumeralShouldBe(10, "X");
        }

        [TestMethod]
        public void Number_50_Should_Output_Single_Character()
        {
            NumberToRomanNumeralShouldBe(50, "L");
        }

        [TestMethod]
        public void Number_100_Should_Output_Single_Character()
        {
            NumberToRomanNumeralShouldBe(100, "C");
        }

        [TestMethod]
        public void Number_500_Should_Output_Single_Character()
        {
            NumberToRomanNumeralShouldBe(500, "D");
        }

        [TestMethod]
        public void Number_1000_Should_Output_Single_Character()
        {
            NumberToRomanNumeralShouldBe(1000, "M");
        }

        [TestMethod]
        public void Number_2_Should_Repeat_Character_Twice()
        {
            NumberToRomanNumeralShouldBe(2, "II");
        }

        [TestMethod]
        public void Number_20_Should_Repeat_Character_Twice()
        {
            NumberToRomanNumeralShouldBe(20, "XX");
        }

        [TestMethod]
        public void Number_200_Should_Repeat_Character_Twice()
        {
            NumberToRomanNumeralShouldBe(200, "CC");
        }

        [TestMethod]
        public void Number_2000_Should_Repeat_Character_Twice()
        {
            NumberToRomanNumeralShouldBe(2000, "MM");
        }

        [TestMethod]
        public void Number_3_Should_Repeat_Character_Three_Times()
        {
            NumberToRomanNumeralShouldBe(3, "III");
        }

        [TestMethod]
        public void Number_30_Should_Repeat_Character_Three_Times()
        {
            NumberToRomanNumeralShouldBe(30, "XXX");
        }

        [TestMethod]
        public void Number_300_Should_Repeat_Character_Three_Times()
        {
            NumberToRomanNumeralShouldBe(300, "CCC");
        }

        [TestMethod]
        public void Number_3000_Should_Repeat_Character_Three_Times()
        {
            NumberToRomanNumeralShouldBe(3000, "MMM");
        }

        [TestMethod]
        public void Number_4_Should_Be_Represented_By_Subtraction()
        {
            NumberToRomanNumeralShouldBe(4, "IV");
        }

        [TestMethod]
        public void Number_40_Should_Be_Represented_By_Subtraction()
        {
            NumberToRomanNumeralShouldBe(40, "XL");
        }

        [TestMethod]
        public void Number_400_Should_Be_Represented_By_Subtraction()
        {
            NumberToRomanNumeralShouldBe(400, "CD");
        }

        [TestMethod]
        public void Number_9_Should_Be_Represented_By_Subtraction()
        {
            NumberToRomanNumeralShouldBe(9, "IX");
        }

        [TestMethod]
        public void Number_90_Should_Be_Represented_By_Subtraction()
        {
            NumberToRomanNumeralShouldBe(90, "XC");
        }

        [TestMethod]
        public void Number_900_Should_Be_Represented_By_Subtraction()
        {
            NumberToRomanNumeralShouldBe(900, "CM");
        }

        [TestMethod]
        public void Number_6_Should_Be_Represented_By_Addition()
        {
            NumberToRomanNumeralShouldBe(6, "VI");
        }

        [TestMethod]
        public void Number_60_Should_Be_Represented_By_Addition()
        {
            NumberToRomanNumeralShouldBe(60, "LX");
        }

        [TestMethod]
        public void Number_600_Should_Be_Represented_By_Addition()
        {
            NumberToRomanNumeralShouldBe(600, "DC");
        }

        [TestMethod]
        public void Number_7_Should_Be_Represented_By_Addition_Twice()
        {
            NumberToRomanNumeralShouldBe(7, "VII");
        }

        [TestMethod]
        public void Number_70_Should_Be_Represented_By_Addition_Twice()
        {
            NumberToRomanNumeralShouldBe(70, "LXX");
        }

        [TestMethod]
        public void Number_700_Should_Be_Represented_By_Addition_Twice()
        {
            NumberToRomanNumeralShouldBe(700, "DCC");
        }

        [TestMethod]
        public void Number_8_Should_Be_Represented_By_Addition_ThreeTimes()
        {
            NumberToRomanNumeralShouldBe(8, "VIII");
        }

        [TestMethod]
        public void Number_80_Should_Be_Represented_By_Addition_ThreeTimes()
        {
            NumberToRomanNumeralShouldBe(80, "LXXX");
        }

        [TestMethod]
        public void Number_800_Should_Be_Represented_By_Addition_ThreeTimes()
        {
            NumberToRomanNumeralShouldBe(800, "DCCC");
        }

        [TestMethod]
        public void Two_Digits_23()
        {
            NumberToRomanNumeralShouldBe(23, "XXIII");
        }

        [TestMethod]
        public void Two_Digits_78()
        {
            NumberToRomanNumeralShouldBe(78, "LXXVIII");
        }

        [TestMethod]
        public void Three_Digits_345()
        {
            NumberToRomanNumeralShouldBe(345, "CCCXLV");
        }

        [TestMethod]
        public void Three_Digits_892()
        {
            NumberToRomanNumeralShouldBe(892, "DCCCXCII");
        }

        [TestMethod]
        public void Four_Digits_1234()
        {
            NumberToRomanNumeralShouldBe(1234, "MCCXXXIV");
        }

        [TestMethod]
        public void Four_Digits_2999()
        {
            NumberToRomanNumeralShouldBe(2999, "MMCMXCIX");
        }
        [TestMethod]
        public void Four_Digits_With_Zero_2007()
        {
            NumberToRomanNumeralShouldBe(2007, "MMVII");
        }
        private static void NumberToRomanNumeralShouldBe(int number, string expected)
        {
            Assert.AreEqual(expected, RomanNumeralsConverter.ToRoman(number));
        }
    }
}