using System;
using System.Collections.Generic;
using System.IO;

namespace RomanNumerals
{
    public static class RomanNumeralsConverter
    {
        private static Dictionary<int, char> _romanNumeralsLookup = new Dictionary<int, char>
        {
            {1, 'I'},
            {5, 'V'},
            {10, 'X'},
            {50, 'L'},
            {100, 'C'},
            {500, 'D'},
            {1000, 'M'},
        };

        public static string ToRoman(int number)
        {
            var digit = 1000;
            var result = "";
            while (digit != 0)
            {
                result += LookupRomanStringByDigit(number / digit, digit);
                number %= digit;
                digit /= 10;
            }

            return result;
        }

        private static string LookupRomanStringByDigit(int number, int digit)
        {
            var romanString = "";
            switch (number)
            {
                case 1:
                case 5:
                    romanString = LookupDirectly(number * digit);
                    break;
                case 2:
                    romanString = Lookup2WithDigit(digit);
                    break;
                case 3:
                    romanString = Lookup3WithDigit(digit);
                    break;
                case 4:
                    romanString = LookupDirectly(digit) + LookupDirectly(5 * digit);
                    break;
                case 6:
                    romanString = LookupDirectly(5 * digit) + LookupDirectly(digit);
                    break;
                case 7:
                    romanString = LookupDirectly(5 * digit) + Lookup2WithDigit(digit);
                    break;
                case 8:
                    romanString = LookupDirectly(5 * digit) + Lookup3WithDigit(digit);
                    break;
                case 9:
                    romanString = LookupDirectly(digit) + LookupDirectly(10 * digit);
                    break;
            }

            return romanString;
        }

        private static string LookupDirectly(int number)
        {
            return $"{_romanNumeralsLookup[number]}";
        }

        private static string Lookup3WithDigit(int digit)
        {
            return new string(_romanNumeralsLookup[digit], 3);
        }

        private static string Lookup2WithDigit(int digit)
        {
            return new string(_romanNumeralsLookup[digit], 2);
        }
    }
}