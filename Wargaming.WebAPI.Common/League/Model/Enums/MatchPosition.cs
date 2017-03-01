using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.Common.Enums
{
    public enum MatchPosition
    {
        Left,
        Right,
    }

    public static class MatchPositionExtensions
    {
        private static Dictionary<MatchPosition, string> Replacements = new Dictionary<MatchPosition, string>()
            {
                { MatchPosition.Left, "left" },
                { MatchPosition.Right, "right" },
            };

        public static string ReplaceMatchPosition(this MatchPosition type)
        {
            return Replacements[type];
        }

        public static MatchPosition ReplaceMatchPosition(this string searchTypeText)
        {
            if (Replacements.Values.Contains(searchTypeText))
            {
                return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
            }

            return MatchPosition.Left;
        }
    }
}