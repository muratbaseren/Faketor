using System;

namespace Faketor
{
	public static class DateTimeFaker
	{
		public static DateTime BirthDay(int minAge, int maxAge)
		{
			return DateTimeFaker.DateTimeBetweenYears(maxAge, minAge);
		}

		public static DateTime BirthDay(int minAge)
		{
			return DateTimeFaker.DateTimeBetweenYears(100, minAge);
		}

		public static DateTime BirthDay()
		{
			return DateTimeFaker.BirthDay(18);
		}

		public static DateTime DateTime(DateTime from, DateTime to)
		{
			TimeSpan timeSpan = to - from;
			DateTime dateTime = from.AddDays((double)NumberFaker.Number(1, (int)timeSpan.TotalDays - 1));
			return dateTime.AddSeconds((double)NumberFaker.Number(1, 86400));
		}

		public static DateTime DateTime()
		{
			return DateTimeFaker.DateTimeBetweenDays(5);
		}

		public static DateTime DateTimeBetweenDays(double fromDays, double toDays)
		{
			DateTime now = System.DateTime.Now;
			DateTime dateTime = now.AddDays(-1 * fromDays);
			DateTime now1 = System.DateTime.Now;
			return DateTimeFaker.DateTime(dateTime, now1.AddDays(toDays));
		}

		public static DateTime DateTimeBetweenDays(double days)
		{
			DateTime now = System.DateTime.Now;
			DateTime dateTime = now.AddDays(-1 * days);
			DateTime now1 = System.DateTime.Now;
			return DateTimeFaker.DateTime(dateTime, now1.AddDays(days));
		}

		public static DateTime DateTimeBetweenMonths(int fromMonths, int toMonths)
		{
			DateTime now = System.DateTime.Now;
			DateTime dateTime = now.AddMonths(-1 * fromMonths);
			DateTime now1 = System.DateTime.Now;
			return DateTimeFaker.DateTime(dateTime, now1.AddMonths(toMonths));
		}

		public static DateTime DateTimeBetweenMonths(int months)
		{
			DateTime now = System.DateTime.Now;
			DateTime dateTime = now.AddMonths(-1 * months);
			DateTime now1 = System.DateTime.Now;
			return DateTimeFaker.DateTime(dateTime, now1.AddMonths(months));
		}

		public static DateTime DateTimeBetweenYears(int fromYears, int toYears)
		{
			DateTime now = System.DateTime.Now;
			DateTime dateTime = now.AddYears(-1 * fromYears);
			DateTime now1 = System.DateTime.Now;
			return DateTimeFaker.DateTime(dateTime, now1.AddYears(toYears));
		}

		public static DateTime DateTimeBetweenYears(int years)
		{
			DateTime now = System.DateTime.Now;
			DateTime dateTime = now.AddYears(-1 * years);
			DateTime now1 = System.DateTime.Now;
			return DateTimeFaker.DateTime(dateTime, now1.AddDays((double)years));
		}
	}
}