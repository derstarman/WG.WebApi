using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.Common.Enums
{
    public enum TeamSearchType
    {
        Name,
        Abbreviation,
    }

    public static class TeamSearchTypeExtensions
    {
        private static Dictionary<TeamSearchType, string> Replacements = new Dictionary<TeamSearchType, string>()
            {
                { TeamSearchType.Name, "name" },
                { TeamSearchType.Abbreviation, "abbreviation" },
            };

        public static string ReplaceTeamSearchType(this TeamSearchType type)
        {
            return Replacements[type];
        }

        public static TeamSearchType ReplaceTeamSearchType(this string searchTypeText)
        {
            if (Replacements.Values.Contains(searchTypeText))
            {
                return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
            }

            return TeamSearchType.Abbreviation;
        }
    }
}