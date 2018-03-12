namespace Faketor
{
    public static class TextFaker
	{
		public static string Sentence()
		{
			return TextFaker.Sentences(1);
		}

		public static string Sentences(int numSentences)
		{
			string[] strArray = new string[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum" };
			return string.Join(". ", ArrayFaker.SelectFrom<string>(numSentences, strArray));
		}
	}
}