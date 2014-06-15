namespace Katas.RomanNumerals
{
    public static class IntegerExtensions
    {
        public static bool IsBetween(this int compareTo, int leftSide, int rightSide)
        {
            return (compareTo >= leftSide && compareTo <= rightSide);
        }
    }
}