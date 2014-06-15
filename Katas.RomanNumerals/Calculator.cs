using System.Collections.Generic;
using System.Linq;

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
                {40, "XL"},
                {50,"L"},
                {90, "XC"},
                {100, "C"},
                {400, "CD"},
                {500, "D"},
                {900, "CM"},
                {1000, "M"},
            };

        public static string Convert(int number)
        {
            if (number == 0)
            {
                return "";
            }

            var closestNumeral = GetClosestNumeralWithoutGoingOver(number);
            return closestNumeral.Value + Convert(number - closestNumeral.Key);
        }

        private static KeyValuePair<int, string> GetClosestNumeralWithoutGoingOver(int number)
        {
            return Numerals.LastOrDefault(n => n.Key <= number);
        }
    }
}
