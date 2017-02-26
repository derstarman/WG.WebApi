using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.WoT.Enums
{
    public enum RegularTeamOrderType
    {
        TeamId,
        TeamIdDesc,
        Name,
        NameDesc,
        Tag,
        TagDesc,
        MemberCount,
        MemberCountDesc
    }

    public static class RegularTeamOrderTypeExtensions
    {
        private static Dictionary<RegularTeamOrderType, string> Replacements = new Dictionary<RegularTeamOrderType, string>()
            {
                { RegularTeamOrderType.TeamId, "team_id" },
                { RegularTeamOrderType.TeamIdDesc, "-team_id" },
                { RegularTeamOrderType.Name, "name" },
                { RegularTeamOrderType.NameDesc, "-name" },
                { RegularTeamOrderType.Tag, "tag" },
                { RegularTeamOrderType.TagDesc, "-tag" },
                { RegularTeamOrderType.MemberCount, "members_count" },
                { RegularTeamOrderType.MemberCountDesc, "-members_count" },
            };

        public static string ReplaceRegularTeamOrderType(this RegularTeamOrderType type)
        {
            return Replacements[type];
        }

        public static RegularTeamOrderType ReplaceRegularTeamOrderType(this string searchTypeText)
        {
            if (Replacements.Values.Contains(searchTypeText))
            {
                return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
            }

            return RegularTeamOrderType.Name;
        }
    }
}