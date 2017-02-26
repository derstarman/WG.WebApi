using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.WoT.Enums
{
	public enum PersonalReserveState
	{
		Active,
		Inactive,
		Used
	}

	public static class PersonalReserveStateExtensions
	{
		private static Dictionary<PersonalReserveState, string> Replacements = new Dictionary<PersonalReserveState, string>()
			{
				{ PersonalReserveState.Active, "ACTIVE" },
				{ PersonalReserveState.Inactive, "INACTIVE" },
				{ PersonalReserveState.Used, "USED" }
			};

		public static string ReplacePersonalReserveState(this PersonalReserveState type)
		{
			return Replacements[type];
		}

		public static PersonalReserveState ReplacePersonalReserveState(this string searchTypeText)
		{
			if (Replacements.Values.Contains(searchTypeText))
			{
				return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
			}

			return PersonalReserveState.Inactive;
		}
	}
}