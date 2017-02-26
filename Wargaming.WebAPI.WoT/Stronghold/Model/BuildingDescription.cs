using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.WoT.Model
{
	public class BuildingDescription
	{
		/// <summary>
		/// Image link
		/// </summary>
		[JsonProperty("image_url")]
		private string ImageValue
		{
			get { return this.Image != null ? this.Image.ToString() : null; }
			set { this.Image = string.IsNullOrEmpty(value) ? null : new Uri(value); }
		}

		/// <summary>
		/// Image link
		/// </summary>
		[JsonIgnore]
		public Uri Image { get; set; }

		/// <summary>
		/// Localized name
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// Localized full description
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// Localized short description
		/// </summary>
		[JsonProperty("short_description")]
		public string ShortDescription { get; set; }

		/// <summary>
		/// Unique type
		/// </summary>
		[JsonProperty("type")]
		public int Type { get; set; }

		/// <summary>
		/// Reserve information
		/// </summary>
		[JsonProperty("reserve")]
		public ClanReserveDescription Reserve { get; set; }
	}
}