namespace Faketor
{
    public static class LocationFaker
	{
		public static string City()
		{
			string[] strArray = new string[] { "Midway", "Mount", "Pleasant", "Greenwood", "Franklin", "Oak", "Grove", "Centerville", "Salem", "Georgetown", "Fairview", "Riverside", "Rotorua", "Tauranga", "Whakatane", "Taupo", "Wanganui", "Nababeep", "Aggeneys", "Pofadder", "Polokwane", "Bela", "Bela", "Goukamma", "Karatara", "Tswane", "Prieska", "Upington", "Hoopstad", "Bultfontein", "Wesselsbron", "Bothaville", "Trompsburg", "Henneman", "Musina", "Ogies", "Kgatlahong", "Tembisa", "Tekoza", "Sebokeng", "Muntaung", "Umnkomaaz" };
			return ArrayFaker.SelectFrom<string>(strArray);
		}

		public static string Country()
		{
			string[] strArray = new string[] { "Afghanistan", "Albania", "Algeria", "American Samoa", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Aruba", "Australia", "Austria", "Azerbaijan", "Bahamas, The", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic", "Chad", "Channel Islands", "Chile", "China", "Colombia", "Comoros", "Congo, Dem. Rep.", "Congo, Rep.", "Costa Rica", "Côte d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt, Arab Rep.", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Faeroe Islands", "Fiji", "Finland", "France", "French Polynesia", "Gabon", "Gambia, The", "Georgia", "Germany", "Ghana", "Greece", "Greenland", "Grenada", "Guam", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hong Kong, China", "Hungary", "Iceland", "India", "Indonesia", "Iran, Islamic Rep.", "Iraq", "Ireland", "Isle of Man", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, Dem. Rep.", "Korea, Rep.", "Kuwait", "Kyrgyz Republic", "Lao PDR", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macao, China", "Macedonia, FYR", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mayotte", "Mexico", "Micronesia, Fed. Sts.", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nepal", "Netherlands", "Netherlands Antilles", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Romania", "Russian Federation", "Rwanda", "Samoa", "San Marino", "São Tomé and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovak Republic", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "St. Kitts and Nevis", "St. Lucia", "St. Vincent and the Grenadines", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Republic", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Venezuela, RB", "Vietnam", "Virgin Islands (U.S.)", "West Bank and Gaza", "Yemen, Rep.", "Zambia", "Zimbabwe" };
			return ArrayFaker.SelectFrom<string>(strArray);
		}

        public static string PostCode()
        {
            return StringFaker.Randomize("????? ##").ToUpper();
        }

        public static string Street()
		{
			int num = LocationFaker.StreetNumber();
			return string.Concat(num.ToString(), " ", LocationFaker.StreetName());
		}

		public static string StreetName()
		{
			string[] strArray = new string[] { "Highland", "Hill", "Park", "Woodland", "Sunset", "Virginia" };
			string str = ArrayFaker.SelectFrom<string>(strArray);
			if (!BooleanFaker.Boolean())
			{
				string[] strArray1 = new string[] { "Adams", "Franklin", "Jackson", "Jefferson", "Lincoln", "Madison", "Washington", "Wilson" };
				return string.Concat(ArrayFaker.SelectFrom<string>(strArray1), " ", str);
			}
			string[] strArray2 = new string[] { "Acacia", "Beech", "Birch", "Cedar", "Cherry", "Chestnut", "Elm", "Larch", "Laurel", "Linden", "Maple", "Oak", "Pine", "Rose", "Walnut", "Willow" };
			return string.Concat(ArrayFaker.SelectFrom<string>(strArray2), " ", str);
		}

		public static int StreetNumber()
		{
			return NumberFaker.Number(1, 50);
		}

		public static string ZipCode()
		{
			return StringFaker.Numeric(5);
		}
	}
}