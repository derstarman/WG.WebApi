using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.Common.Enums
{
    public enum StatisticsOrderType
    {
        BattleEfficiency,
        BattleEfficiencyDesc,
        DamageCaused,
        DamageCausedDesc,
        EnemiesDestroyed,
        EnemiesDestroyedDesc,
        EnemiesSpotted,
        EnemiesSpottedDesc,
        BaseCapturePoints,
        BaseCapturePointsDesc,
        BaseDefensePoints,
        BaseDefensePointsDesc,
        NumberOfBattles,
        NumberOfBattlesDesc
    }

    public static class StatisticsOrderTypeExtensions
    {
        private static Dictionary<StatisticsOrderType, string> Replacements = new Dictionary<StatisticsOrderType, string>()
            {
                { StatisticsOrderType.BattleEfficiency, "fct" },
                { StatisticsOrderType.BattleEfficiencyDesc, "-fct" },
                { StatisticsOrderType.DamageCaused, "dmg" },
                { StatisticsOrderType.DamageCausedDesc, "-dmg" },
                { StatisticsOrderType.EnemiesDestroyed, "frg" },
                { StatisticsOrderType.EnemiesDestroyedDesc, "-frg" },
                { StatisticsOrderType.EnemiesSpotted, "spt" },
                { StatisticsOrderType.EnemiesSpottedDesc, "-spt" },
                { StatisticsOrderType.BaseCapturePoints, "cpt" },
                { StatisticsOrderType.BaseCapturePointsDesc, "-cpt" },
                { StatisticsOrderType.BaseDefensePoints, "dpt" },
                { StatisticsOrderType.BaseDefensePointsDesc, "-dpt" },
                { StatisticsOrderType.NumberOfBattles, "gpl" },
                { StatisticsOrderType.NumberOfBattlesDesc, "-gpl" },
            };

        public static string ReplaceTeamStatisticsOrderType(this StatisticsOrderType type)
        {
            return Replacements[type];
        }

        public static StatisticsOrderType ReplaceTeamStatisticsOrderType(this string searchTypeText)
        {
            if (Replacements.Values.Contains(searchTypeText))
            {
                return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
            }

            return StatisticsOrderType.BattleEfficiency;
        }
    }
}