using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.Common.Enums
{
    public enum TournamentType
    {
        RoundRobin,
        DoubleElimination,
        SingleElimination,
        SingleElimination_Korea,
    }

    public static class TournamentTypeExtensions
    {
        private static Dictionary<TournamentType, string> Replacements = new Dictionary<TournamentType, string>()
            {
                { TournamentType.RoundRobin, "RR" },
                { TournamentType.DoubleElimination, "DE" },
                { TournamentType.SingleElimination, "SE" },
                { TournamentType.SingleElimination_Korea, "SE_KR" },
            };

        public static string ReplaceTournamentType(this TournamentType type)
        {
            return Replacements[type];
        }

        public static TournamentType ReplaceTournamentType(this string searchTypeText)
        {
            if (Replacements.Values.Contains(searchTypeText))
            {
                return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
            }

            return TournamentType.RoundRobin;
        }
    }
}