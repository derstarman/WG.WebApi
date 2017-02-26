using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.Enums
{
    public enum Environments
    {
        Portal,
        WOT,
        WOTB,
        WOTG,
        WOWP,
        WOWS,
    }

    public static class EnvironmentsExtensions
    {
        private static Dictionary<Environments, string> Replacements = new Dictionary<Environments, string>()
            {
                { Environments.Portal, "portal" },
                { Environments.WOTB, "wotb" },
                { Environments.WOT,  "wot" },
                { Environments.WOWS, "wows" },
                { Environments.WOTG, "wotg" },
                { Environments.WOWP, "wowp" },
            };

        public static string ReplaceEnvironments(this Environments type)
        {
            return Replacements[type];
        }

        public static Environments ReplaceEnvironments(this string environmentsText)
        {
            if (Replacements.Values.Contains(environmentsText))
            {
                return Replacements.First(r => r.Value.Equals(environmentsText, StringComparison.CurrentCulture)).Key;
            }

            return Environments.WOT;
        }
    }
}