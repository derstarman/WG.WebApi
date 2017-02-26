using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.Common.Model
{
    public class ClanEmblems
    {
        /// <summary>
        /// List of links to 24x24 px emblems
        /// </summary>
        [JsonProperty("x24")]
        private Dictionary<string, string> EmblemsX24Values
        {
            get { return this.EmblemsX24.ToDictionary(x => x.Key.ReplaceEnvironments(), x => x.Value.ToString()); }
            set { this.EmblemsX24 = value.ToDictionary(x => x.Key.ReplaceEnvironments(), x => new Uri(x.Value)); }
        }

        /// <summary>
        /// List of links to 24x24 px emblems
        /// </summary>
        [JsonIgnore]
        public Dictionary<Environments, Uri> EmblemsX24 { get; set; }

        /// <summary>
        /// List of links to 32x32 px emblems
        /// </summary>
        [JsonProperty("x32")]
        private Dictionary<string, string> EmblemsX32Values
        {
            get { return this.EmblemsX32.ToDictionary(x => x.Key.ReplaceEnvironments(), x => x.Value.ToString()); }
            set { this.EmblemsX32 = value.ToDictionary(x => x.Key.ReplaceEnvironments(), x => new Uri(x.Value)); }
        }

        /// <summary>
        /// List of links to 32x32 px emblems
        /// </summary>
        [JsonIgnore]
        public Dictionary<Environments, Uri> EmblemsX32 { get; set; }

        /// <summary>
        /// List of links to 64x64 px emblems
        /// </summary>
        [JsonProperty("x64")]
        private Dictionary<string, string> EmblemsX64Values
        {
            get { return this.EmblemsX64.ToDictionary(x => x.Key.ReplaceEnvironments(), x => x.Value.ToString()); }
            set { this.EmblemsX64 = value.ToDictionary(x => x.Key.ReplaceEnvironments(), x => new Uri(x.Value)); }
        }

        /// <summary>
        /// List of links to 64x64 px emblems
        /// </summary>
        [JsonIgnore]
        public Dictionary<Environments, Uri> EmblemsX64 { get; set; }

        /// <summary>
        /// List of links to 195x195 px emblems
        /// </summary>
        [JsonProperty("x195")]
        private Dictionary<string, string> EmblemsX195Values
        {
            get { return this.EmblemsX195.ToDictionary(x => x.Key.ReplaceEnvironments(), x => x.Value.ToString()); }
            set { this.EmblemsX195 = value.ToDictionary(x => x.Key.ReplaceEnvironments(), x => new Uri(x.Value)); }
        }

        /// <summary>
        /// List of links to 195x195 px emblems
        /// </summary>
        [JsonIgnore]
        public Dictionary<Environments, Uri> EmblemsX195 { get; set; }

        /// <summary>
        /// List of links to 256x256 px emblems
        /// </summary>
        [JsonProperty("x256")]
        private Dictionary<string, string> EmblemsX256Values
        {
            get { return this.EmblemsX256.ToDictionary(x => x.Key.ReplaceEnvironments(), x => x.Value.ToString()); }
            set { this.EmblemsX256 = value.ToDictionary(x => x.Key.ReplaceEnvironments(), x => new Uri(x.Value)); }
        }

        /// <summary>
        /// List of links to 256x256 px emblems
        /// </summary>
        [JsonIgnore]
        public Dictionary<Environments, Uri> EmblemsX256 { get; set; }
    }
}