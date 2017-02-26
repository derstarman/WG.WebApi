using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.Common.Model
{
    public class SocialNetworks
    {
        /// <summary>
        /// Facebook link
        /// </summary>
        [JsonProperty("facebook")]
        private string FacebookValue
        {
            get { return this.Facebook != null ? this.Facebook.ToString() : null; }
            set { this.Facebook = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Facebook link
        /// </summary>
        [JsonIgnore]
        public Uri Facebook { get; set; }

        /// <summary>
        /// Twitch link
        /// </summary>
        [JsonProperty("twitch")]
        private string TwitchValue
        {
            get { return this.Twitch != null ? this.Twitch.ToString() : null; }
            set { this.Twitch = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Twitch link
        /// </summary>
        [JsonIgnore]
        public Uri Twitch { get; set; }

        /// <summary>
        /// Twitter link
        /// </summary>
        [JsonProperty("twitter")]
        private string TwitterValue
        {
            get { return this.Twitter != null ? this.Twitter.ToString() : null; }
            set { this.Twitter = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Twitter link
        /// </summary>
        [JsonIgnore]
        public Uri Twitter { get; set; }

        /// <summary>
        /// Vkontakte link
        /// </summary>
        [JsonProperty("vkontakte")]
        private string VkontakteValue
        {
            get { return this.Vkontakte != null ? this.Vkontakte.ToString() : null; }
            set { this.Vkontakte = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Vkontakte link
        /// </summary>
        [JsonIgnore]
        public Uri Vkontakte { get; set; }

        /// <summary>
        /// YouTube link
        /// </summary>
        [JsonProperty("youtube")]
        private string YouTubeValue
        {
            get { return this.YouTube != null ? this.YouTube.ToString() : null; }
            set { this.YouTube = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// YouTube link
        /// </summary>
        [JsonIgnore]
        public Uri YouTube { get; set; }
    }
}