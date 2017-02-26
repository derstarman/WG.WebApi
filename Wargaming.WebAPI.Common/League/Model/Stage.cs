using Newtonsoft.Json;

namespace Wargaming.WebAPI.Common.Model
{
    public class Stage
    {
        /// <summary>
        /// Stage ID
        /// </summary>
        [JsonProperty("stage_id")]
        public int StageId { get; set; }

        /// <summary>
        /// Stage name
        /// </summary>
        [JsonProperty("name_i18n")]
        public string StageNameLocalized { get; set; }
    }
}