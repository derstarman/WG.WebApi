using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.WoT.Enums
{
	public enum ProvincesOrderType
	{
		ProvinceId,
		ProvinceIdDesc,
		DailyRevenue,
		DailyRevenueDesc,
		PrimeHour,
		PrimeHourDesc
	}

	public static class ProvincesOrderTypeExtensions
	{
		private static Dictionary<ProvincesOrderType, string> Replacements = new Dictionary<ProvincesOrderType, string>()
			{
				{ ProvincesOrderType.ProvinceId, "province_id" },
				{ ProvincesOrderType.ProvinceIdDesc, "-province_id" },
				{ ProvincesOrderType.DailyRevenue, "daily_revenue" },
				{ ProvincesOrderType.DailyRevenueDesc, "-daily_revenue" },
				{ ProvincesOrderType.PrimeHour, "prime_hour" },
				{ ProvincesOrderType.PrimeHourDesc, "-prime_hour" }
			};

		public static string ReplaceProvincesOrderType(this ProvincesOrderType type)
		{
			return Replacements[type];
		}

		public static ProvincesOrderType ReplaceProvincesOrderType(this string searchTypeText)
		{
			if (Replacements.Values.Contains(searchTypeText))
			{
				return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
			}

			return ProvincesOrderType.ProvinceId;
		}
	}
}