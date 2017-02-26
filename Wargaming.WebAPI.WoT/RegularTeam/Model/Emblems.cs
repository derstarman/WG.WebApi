using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.WoT.Model
{
    public class Emblems
    {
        /// <summary>
        /// Link to 24x24 emblem
        /// </summary>
        [JsonProperty("x24")]
        private string X24Value
        {
            get { return this.X24 != null ? this.X24.ToString() : null; }
            set { this.X24 = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Link to 24x24 emblem
        /// </summary>
        [JsonIgnore]
        public Uri X24 { get; set; }

        /// <summary>
        /// Link to 32x32 emblem
        /// </summary>
        [JsonProperty("x32")]
        private string X32Value
        {
            get { return this.X32 != null ? this.X32.ToString() : null; }
            set { this.X32 = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Link to 32x32 emblem
        /// </summary>
        [JsonIgnore]
        public Uri X32 { get; set; }

        /// <summary>
        /// Link to 64x64 emblem
        /// </summary>
        [JsonProperty("x64")]
        private string X64Value
        {
            get { return this.X64 != null ? this.X64.ToString() : null; }
            set { this.X64 = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Link to 64x64 emblem
        /// </summary>
        [JsonIgnore]
        public Uri X64 { get; set; }

        /// <summary>
        /// Link to 195x195 emblem
        /// </summary>
        [JsonProperty("x195")]
        private string X195Value
        {
            get { return this.X195 != null ? this.X195.ToString() : null; }
            set { this.X195 = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Link to 195x195 emblem
        /// </summary>
        [JsonIgnore]
        public Uri X195 { get; set; }

        /// <summary>
        /// Link to 256x256 emblem
        /// </summary>
        [JsonProperty("x256")]
        private string X256Value
        {
            get { return this.X256 != null ? this.X256.ToString() : null; }
            set { this.X256 = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Link to 256x256 emblem
        /// </summary>
        [JsonIgnore]
        public Uri X256 { get; set; }
    }
}