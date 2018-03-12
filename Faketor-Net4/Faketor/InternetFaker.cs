namespace Faketor
{
    public static class InternetFaker
	{
		public static string Domain()
		{
			string[] strArray = new string[] { "yahoo.com", "gmail.com", "privacy.net", "webmail.com", "msn.com", "hotmail.com", "example.com" };
			return ArrayFaker.SelectFrom<string>(strArray);
		}

		public static string Email()
		{
			if (NumberFaker.Number(5) != 2)
			{
				return string.Concat(NameFaker.FirstName().ToLower(), "@", InternetFaker.Domain());
			}
			return string.Concat(NameFaker.FirstName().ToLower(), StringFaker.Numeric(2), "@", InternetFaker.Domain());
		}

		public static string Url()
		{
			return string.Concat("http://www.", InternetFaker.Domain());
		}
	}
}