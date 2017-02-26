using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.Enums
{
    public enum EventStatus
    {
        Active,
        Complete,
    }

    public static class EventStatusExtensions
    {
        private static Dictionary<EventStatus, string> Replacements = new Dictionary<EventStatus, string>()
            {
                { EventStatus.Active, "active" },
                { EventStatus.Complete, "complete" },
            };

        public static string ReplaceEventStatus(this EventStatus type)
        {
            return Replacements[type];
        }

        public static EventStatus ReplaceEventStatus(this string searchTypeText)
        {
            if (Replacements.Values.Contains(searchTypeText))
            {
                return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
            }

            return EventStatus.Active;
        }
    }
}