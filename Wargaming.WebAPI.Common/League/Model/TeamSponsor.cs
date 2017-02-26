using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.Common.Model
{
    public class TeamSponsor
    {
        /// <summary>
        /// Link to sponsor logo
        /// </summary>
        [JsonProperty("logo_url")]
        private string SponsorLogoValue
        {
            get { return this.SponsorLogo != null ? this.SponsorLogo.ToString() : null; }
            set { this.SponsorLogo = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Link to sponsor logo
        /// </summary>
        [JsonIgnore]
        public Uri SponsorLogo { get; set; }

        /// <summary>
        /// Sponsor name
        /// </summary>
        [JsonProperty("name")]
        public string SponsorName { get; set; }

        /// <summary>
        /// Link to sponsor website
        /// </summary>
        [JsonProperty("website_url")]
        private string SponsorWebSiteValue
        {
            get { return this.SponsorWebSite != null ? this.SponsorWebSite.ToString() : null; }
            set { this.SponsorWebSite = string.IsNullOrEmpty(value) ? null : new Uri(value); }
        }

        /// <summary>
        /// Link to sponsor website
        /// </summary>
        [JsonIgnore]
        public Uri SponsorWebSite { get; set; }
    }
}