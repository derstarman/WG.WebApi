using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wargaming.WebAPI.Common.Model
{
    public class ClanPrivateInformation
    {
        /// <summary>
        /// Gold in clan treasury
        /// </summary>
        [JsonProperty("treasury")]
        public double ClanTreasury { get; set; }

        /// <summary>
        /// List of clan members with an active game session in World of Tanks.
        /// </summary>
        [JsonProperty("online_members")]
        public List<int> OnlineClanMembers { get; set; }
    }
}