namespace RomanNumerals
{
    public static class RomanNumeralsConverter
    {
        private static readonly (int Value, string Numeral)[] _romanNumeralsLookup =
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        public static string ToRoman(int number)
        {
            var resultStr = "";
            foreach (var (value, numeral) in _romanNumeralsLookup)
            {
                while (value <= number && number != 0)
                {
                    resultStr += numeral;
                    number -= value;
                }
            }

            return resultStr;
        }
    }
}