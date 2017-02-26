using System;

namespace Wargaming.WebAPI
{
	public static class ConverterExtensions
	{
		public static Func<DateTime> BaseDate = () => new DateTime(1970, 1, 1, 0, 0, 0, 0);
		
		public static double ToDouble(this DateTime dateTime)
		{
			return Convert.ToDouble(new TimeSpan(dateTime.Ticks - BaseDate().Ticks).TotalSeconds);
		}

		public static DateTime ToDateTime(this double seconds)
		{
			return BaseDate().AddSeconds(seconds);
		}

		public static double? ToDouble(this DateTime? dateTime)
		{
			return dateTime.HasValue ? Convert.ToDouble(new TimeSpan(dateTime.Value.Ticks - BaseDate().Ticks).TotalSeconds) : (double?)null;	
		}

		public static DateTime? ToDateTime(this double? seconds)
		{
			return seconds.HasValue ? BaseDate().AddSeconds(seconds.Value) : (DateTime?)null;
		}
	}
}