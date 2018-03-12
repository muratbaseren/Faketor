namespace Faketor
{
    public static class PhoneFaker
	{
		public static string InternationalPhone()
		{
			return StringFaker.Randomize("+##-(0)####-####-####");
		}

		public static string Phone()
		{
			return StringFaker.Randomize("###-###-#####");
		}
	}
}