using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.WoT.Model.Enums
{
	public enum ExcludeReason
	{
		None = 0,
		Inactivity = 1,
		NewbiesMeasure = 2,
		Limits = 3,
		Blocked = 4,
		Other = 5,
	}

	public static class ExcludeReasonExtensions
	{
		private static Dictionary<ExcludeReason, string> Replacements = new Dictionary<ExcludeReason, string>()
			{
				{ ExcludeReason.None, "NONE" },
				{ ExcludeReason.Inactivity, "inactivity" },
				{ ExcludeReason.NewbiesMeasure, "newbies_measure" },
				{ ExcludeReason.Limits, "limits" },
				{ ExcludeReason.Blocked, "blocked" },
				{ ExcludeReason.Other, "other" },
			};

		public static string ReplaceExcludeReason(this ExcludeReason type)
		{
			return Replacements[type];
		}

		public static ExcludeReason ReplaceExcludeReason(this string searchTypeText)
		{
			if (Replacements.Values.Contains(searchTypeText))
			{
				return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
			}

			return ExcludeReason.None;
		}
	}
}