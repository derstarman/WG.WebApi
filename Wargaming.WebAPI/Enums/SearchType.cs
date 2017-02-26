using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.Enums
{
    public enum SearchType
    {
        StartsWith = 0,
        Exact = 1,
    }

    public static class SearchTypeExtensions
    {
        private static Dictionary<SearchType, string> Replacements = new Dictionary<SearchType, string>()
            {
                { SearchType.StartsWith, "startswith" },
                { SearchType.Exact, "exact" },
            };

        public static string ReplaceSearchType(this SearchType type)
        {
            return Replacements[type];
        }

        public static SearchType ReplaceSearchType(this string searchTypeText)
        {
            if (Replacements.Values.Contains(searchTypeText))
            {
                return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
            }

            return SearchType.StartsWith;
        }
    }
}