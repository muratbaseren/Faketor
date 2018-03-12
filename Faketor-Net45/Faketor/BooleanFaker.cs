namespace Faketor
{
    public static class BooleanFaker
	{
		public static bool Boolean()
		{
			return NumberFaker.Number(2) == 1;
		}
	}
}