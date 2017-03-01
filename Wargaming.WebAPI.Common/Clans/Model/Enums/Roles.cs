using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.Common.Enums
{
    public enum Roles
    {
        JuniorOfficer,
        PersonnelOfficer,
        Quartermaster,
        ExecutiveOfficer,
        Recruit,
        Private,
        Commander,
        Reservist,
        CombatOfficer,
        IntelligenceOfficer,
        RecruitmentOfficer
    }

    public static class RolesExtensions
    {
        private static Dictionary<Roles, string> Replacements = new Dictionary<Roles, string>()
            {
                { Roles.JuniorOfficer, "junior_officer" },
                { Roles.PersonnelOfficer, "personnel_officer" },
                { Roles.Quartermaster, "quartermaster" },
                { Roles.ExecutiveOfficer, "executive_officer" },
                { Roles.Recruit, "recruit" },
                { Roles.Private, "private" },
                { Roles.Commander, "commander" },
                { Roles.Reservist, "reservist" },
                { Roles.CombatOfficer, "combat_officer" },
                { Roles.IntelligenceOfficer, "intelligence_officer" },
                { Roles.RecruitmentOfficer, "recruitment_officer"  },
            };

        public static string ReplaceRoles(this Roles type)
        {
            return Replacements[type];
        }

        public static Roles ReplaceRoles(this string rolesText)
        {
            if (Replacements.Values.Contains(rolesText))
            {
                return Replacements.First(r => r.Value.Equals(rolesText, StringComparison.CurrentCulture)).Key;
            }

            return Roles.Reservist;
        }
    }
}