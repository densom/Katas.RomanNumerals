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
            if (IsSingleRomanNumeralOrSpecialCase(number))
            {
                return Numerals[number];
            }

            var firstPart = GetClosestNumeralWithoutGoingOver(number);
            return firstPart.Value + Convert(number - firstPart.Key);
        }

        private static KeyValuePair<int, string> GetClosestNumeralWithoutGoingOver(int number)
        {
            return Numerals.LastOrDefault(n => n.Key < number);
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
