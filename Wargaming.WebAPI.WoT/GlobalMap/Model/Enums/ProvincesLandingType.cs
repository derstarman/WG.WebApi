using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.WoT.Enums
{
	public enum ProvincesLandingType
	{
		Null,
		Auction,
		Tournament
	}

	public static class ProvincesLandingTypeExtensions
	{
		private static Dictionary<ProvincesLandingType, string> Replacements = new Dictionary<ProvincesLandingType, string>()
			{
				{ ProvincesLandingType.Null, "null" },
				{ ProvincesLandingType.Auction, "auction" },
				{ ProvincesLandingType.Tournament, "tournament" }
			};

		public static string ReplaceProvincesLandingType(this ProvincesLandingType type)
		{
			return Replacements[type];
		}

		public static ProvincesLandingType ReplaceProvincesLandingType(this string searchTypeText)
		{
			if (Replacements.Values.Contains(searchTypeText))
			{
				return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
			}

			return ProvincesLandingType.Null;
		}
	}
}