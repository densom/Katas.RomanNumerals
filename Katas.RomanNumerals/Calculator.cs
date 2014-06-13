using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.RomanNumerals
{
    public static class Calculator
    {
        private static Dictionary<int, string> Numerals = new Dictionary<int, string>()
            {
                {1,"I"},
                {4, "IV"},
                {5,"V"},
                {9,"IX"},
                {10,"X"},
            };

        public static string Convert(int number)
        {
            var resultBuilder = new StringBuilder();
            var romanNumeral = "I";

            if (number.IsBetween(1, 3))
            {
                romanNumeral = "I";
                int repeatCharacter = number > 3 ? 3 : number;


                for (int i = 0; i < repeatCharacter; i++)
                {
                    resultBuilder.Append(romanNumeral);
                }
            }

            if (IsSingleRomanNumeralOrSpecialCase(number))
            {
                return Numerals[number];
            }

            return resultBuilder.ToString();
        }

        private static bool IsSingleRomanNumeralOrSpecialCase(int number)
        {
            return Numerals.ContainsKey(number);
        }
    }

    public static class IntegerExtensions
    {
        public static bool IsBetween(this int compareTo, int leftSide, int rightSide)
        {
            return (compareTo >= leftSide && compareTo <= rightSide);
        }
    }
}
