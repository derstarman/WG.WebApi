using Newtonsoft.Json;

namespace Wargaming.WebAPI.Common.Model
{
    public class HallOfFameEntry
    {
        /// <summary>
        /// Player account ID
        /// </summary>
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        /// <summary>
        /// Player user name
        /// </summary>
        [JsonProperty("nickname")]
        public string AccountName { get; set; }

        /// <summary>
        /// Battles
        /// </summary>
        [JsonProperty("gpl")]
        public HallOfFameValue GlobalPlayed { get; set; }

        /// <summary>
        /// Base defense points
        /// </summary>
        [JsonProperty("dpt")]
        public HallOfFameValue DefensePoints { get; set; }

        /// <summary>
        /// Battle efficiency
        /// </summary>
        [JsonProperty("fct")]
        public HallOfFameValue Efficiency { get; set; }

        /// <summary>
        /// Damage caused
        /// </summary>
        [JsonProperty("dmg")]
        public HallOfFameValue Damage { get; set; }

        /// <summary>
        /// Base capture points
        /// </summary>
        [JsonProperty("cpt")]
        public HallOfFameValue CapturePoints { get; set; }

        /// <summary>
        /// Enemies spotted
        /// </summary>
        [JsonProperty("spt")]
        public HallOfFameValue Spotted { get; set; }

        /// <summary>
        /// Enemies destroyed
        /// </summary>
        [JsonProperty("frg")]
        public HallOfFameValue Frags { get; set; }
    }
}