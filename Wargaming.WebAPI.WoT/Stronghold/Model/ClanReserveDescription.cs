using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.WoT.Model
{
	public class ClanReserveDescription
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
		/// Localized description
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }
	}
}