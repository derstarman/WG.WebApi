using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargaming.WebAPI.Common.Model
{
    public class LeaguePlayerStatistics
    {
        /// <summary>
        /// Battles fought
        /// </summary>
        [JsonProperty("gpl")]
        public int GlobalPlayed { get; set; }

        /// <summary>
        /// Base defense points
        /// </summary>
        [JsonProperty("dpt")]
        public int DefensePoints { get; set; }

        /// <summary>
        /// Enemies destroyed
        /// </summary>
        [JsonProperty("frg")]
        public int Frags { get; set; }

        /// <summary>
        /// Damage caused
        /// </summary>
        [JsonProperty("dmg")]
        public int Damage { get; set; }

        /// <summary>
        /// Victories/Battles ratio
        /// </summary>
        [JsonProperty("won_battles_percent")]
        public double WonPercentage { get; set; }

        /// <summary>
        /// Enemies spotted
        /// </summary>
        [JsonProperty("spt")]
        public int Spotted { get; set; }

        /// <summary>
        /// Average damage per battle
        /// </summary>
        [JsonProperty("avg_battle_damage")]
        public double AverageDamage { get; set; }

        /// <summary>
        /// Battle efficiency
        /// </summary>
        [JsonProperty("fct")]
        public double Efficiency { get; set; }

        /// <summary>
        /// Base capture points
        /// </summary>
        [JsonProperty("cpt")]
        public int CapturePoints { get; set; }
    }    
}
