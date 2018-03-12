using System;

namespace Faketor
{
    public static class NumberFaker
    {
        private static Random _random;

        static NumberFaker()
        {
            NumberFaker._random = new Random();
        }

        public static int Number()
        {
            return NumberFaker._random.Next();
        }

        public static int Number(int maxValue)
        {
            return NumberFaker._random.Next(maxValue);
        }

        public static int Number(int minValue, int maxValue)
        {
            return NumberFaker._random.Next(minValue, maxValue);
        }
    }
}
