using Newtonsoft.Json;

namespace Wargaming.WebAPI.Common.Model
{
    public class HallOfFameValue
    {
        /// <summary>
        /// Position
        /// </summary>
        [JsonProperty("rank")]
        public int Position { get; set; }

        /// <summary>
        /// Absolute value
        /// </summary>
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}