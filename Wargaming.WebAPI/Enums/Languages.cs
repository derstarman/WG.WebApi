using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.Enums
{
    public enum Languages
    {
        EN = 0,
        RU = 1,
        PL = 2,
        DE = 3,
        FR = 4,
        ES = 5,
        ZH_CN = 6,
        TR = 7,
        CS = 8,
        TH = 9,
        VI = 10,
        KO = 11,
    }

    public static class LanguagesExtensions
    {
        private static Dictionary<Languages, string> Replacements = new Dictionary<Languages, string>()
            {
                { Languages.EN, "en" },
                { Languages.RU, "ru" },
                { Languages.PL, "pl" },
                { Languages.DE, "de" },
                { Languages.FR, "fr" },
                { Languages.ES, "es" },
                { Languages.ZH_CN, "zh-cn" },
                { Languages.TR, "tr" },
                { Languages.CS, "cs" },
                { Languages.TH, "th" },
                { Languages.VI, "vi" },
                { Languages.KO, "ko" },
            };

        public static string ReplaceLanguages(this Languages type)
        {
            return Replacements[type];
        }

        public static Languages ReplaceLanguages(this string langauge)
        {
            if (Replacements.Values.Contains(langauge))
            {
                return Replacements.First(r => r.Value.Equals(langauge, StringComparison.CurrentCulture)).Key;
            }

            return Languages.EN;
        }
    }
}