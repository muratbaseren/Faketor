namespace Faketor
{
    public static class NameFaker
	{
		public static string FemaleFirstName()
		{
			string[] strArray = new string[] { "Alison", "Ann", "Anna", "Anne", "Barbara", "Betty", "Beryl", "Carol", "Charlotte", "Cheryl", "Deborah", "Diana", "Donna", "Dorothy", "Elizabeth", "Eve", "Felicity", "Fiona", "Helen", "Helena", "Jennifer", "Jessica", "Judith", "Karen", "Kimberly", "Laura", "Linda", "Lisa", "Lucy", "Margaret", "Maria", "Mary", "Michelle", "Nancy", "Patricia", "Polly", "Robyn", "Ruth", "Sandra", "Sarah", "Sharon", "Susan", "Tabitha", "Ursula", "Victoria", "Wendy" };
			return ArrayFaker.SelectFrom<string>(strArray);
		}

		public static string FemaleName()
		{
			return string.Concat(NameFaker.FemaleFirstName(), " ", NameFaker.LastName());
		}

		public static string FirstName()
		{
			if (!BooleanFaker.Boolean())
			{
				return NameFaker.MaleFirstName();
			}
			return NameFaker.FemaleFirstName();
		}

		public static string LastName()
		{
			string[] strArray = new string[] { "Abel", "Anderson", "Andrews", "Anthony", "Baker", "Brown", "Burrows", "Clark", "Clarke", "Clarkson", "Davidson", "Davies", "Davis", "Dent", "Edwards", "Garcia", "Grant", "Hall", "Harris", "Harrison", "Jackson", "Jeffries", "Jefferson", "Johnson", "Jones", "Kirby", "Kirk", "Lake", "Lee", "Lewis", "Martin", "Martinez", "Major", "Miller", "Moore", "Oates", "Peters", "Peterson", "Robertson", "Robinson", "Rodriguez", "Smith", "Smythe", "Stevens", "Taylor", "Thatcher", "Thomas", "Thompson", "Walker", "Washington", "White", "Williams", "Wilson", "Yorke" };
			return ArrayFaker.SelectFrom<string>(strArray);
		}

		public static string MaleFirstName()
		{
			string[] strArray = new string[] { "Adam", "Anthony", "Arthur", "Brian", "Charles", "Christopher", "Daniel", "David", "Donald", "Edgar", "Edward", "Edwin", "George", "Harold", "Herbert", "Hugh", "James", "Jason", "John", "Joseph", "Kenneth", "Kevin", "Marcus", "Mark", "Matthew", "Michael", "Paul", "Philip", "Richard", "Robert", "Roger", "Ronald", "Simon", "Steven", "Terry", "Thomas", "William" };
			return ArrayFaker.SelectFrom<string>(strArray);
		}

		public static string MaleName()
		{
			return string.Concat(NameFaker.MaleFirstName(), " ", NameFaker.LastName());
		}

		public static string Name()
		{
			return string.Concat(NameFaker.FirstName(), " ", NameFaker.LastName());
		}
	}
}