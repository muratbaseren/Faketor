using System;

namespace Faketor
{
	public static class EnumFaker
	{
		public static EnumT SelectFrom<EnumT>()
		{
			Array values = Enum.GetValues(typeof(EnumT));
			return (EnumT)values.GetValue(NumberFaker.Number(values.Length));
		}
	}
}