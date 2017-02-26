using Newtonsoft.Json;
using System;

namespace Wargaming.WebAPI.Common.Model
{
	public class ClanMessageBoardEntry
	{
		/// <summary>
		/// Message creation date
		/// </summary>
		[JsonProperty("created_at")]
		private double CreatedAtValue
		{
			get { return this.CreatedAt.ToDouble(); }
			set { this.CreatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Message creation date
		/// </summary>
		[JsonIgnore]
		public DateTime CreatedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Date when message was updated
		/// </summary>
		[JsonProperty("updated_at ")]
		private double UpdatedAtValue
		{
			get { return this.UpdatedAt.ToDouble(); }
			set { this.UpdatedAt = value.ToDateTime(); }
		}

		/// <summary>
		/// Date when message was updated
		/// </summary>
		[JsonIgnore]
		public DateTime UpdatedAt { get; set; } = ConverterExtensions.BaseDate();

		/// <summary>
		/// Message author ID
		/// </summary>
		[JsonProperty("author_id")]
		public int MessageCreatorAccountId { get; set; }

		/// <summary>
		/// ID of a player who has changed the message
		/// </summary>
		[JsonProperty("editor_id ")]
		public int MessageEditorAccountId { get; set; }

		/// <summary>
		/// Indicates if the message has been read
		/// </summary>
		[JsonProperty("is_read ")]
		public bool IsMessageRead { get; set; }

		/// <summary>
		/// Message text
		/// </summary>
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}
