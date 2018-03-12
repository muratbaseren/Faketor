using System.Text;

namespace Faketor
{
    public static class StringFaker
	{
		public static string Alpha(int length)
		{
			return StringFaker.SelectFrom(length, "abcdefghijkmnopqrstuvwxyz");
		}

		public static string AlphaNumeric(int length)
		{
			return StringFaker.SelectFrom(length, "0123456789abcdefghijkmnopqrstuvwxyz");
		}

		public static string Numeric(int length)
		{
			return StringFaker.SelectFrom(length, "0123456789");
		}

        public static string Randomize(string pattern)
        {
            StringBuilder result = new StringBuilder();
            string str = pattern;

            foreach (char c in pattern.ToCharArray())
            {
                if (c.ToString() != "#")
                {
                    result.Append(StringFaker.Alpha(1));
                }
                result.Append(StringFaker.Numeric(1));
            }

            return result.ToString();
        }

        public static string SelectFrom(int numElements, string characters)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int length = characters.Length;
			while (numElements > 0)
			{
				stringBuilder.Append(characters[NumberFaker.Number(length)]);
				numElements--;
			}
			return stringBuilder.ToString();
		}
	}
}