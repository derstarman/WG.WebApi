using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.WoT.Model
{
	public class Restrictions
	{
		/// <summary>
		/// End time of chat ban
		/// </summary>
		[JsonProperty("chat_ban_time")]
		private double ChatBanTimeValue
		{
			get { return this.ChatBanTime.ToDouble(); }
			set { this.ChatBanTime = value.ToDateTime(); }
		}

		/// <summary>
		/// End time of chat ban
		/// </summary>
		[JsonIgnore]
		public DateTime ChatBanTime { get; set; } = ConverterExtensions.BaseDate();
	}
}