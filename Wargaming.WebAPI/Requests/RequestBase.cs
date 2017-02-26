using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.Requests
{
	public abstract class RequestBase : CommonRequestBase
	{
		/// <summary>
		/// Access key generated upon application authentication. The key expires in two weeks.
		/// </summary>
		/// <remarks>
		/// Used for:
		///
		///   - Methods that require authentication.
		///   - Public methods that transfer the extended information to the authenticated user.
		/// </remarks>
		[JsonProperty("access_token")]
		public string AccessToken { get; set; }

		/// <summary>
		/// The list of response fields. The fields are separated by commas. The nested fields are separated by dots.
		/// To specify the fields that should be excluded from the response, "-" sign before the field name is used.
		/// If the parameter is not specified, all response fields are returned.
		/// </summary>
		/// <remarks>
		/// Optional parameter.
		/// Used for all methods that do not support authentication.
		/// </remarks>
		[JsonProperty("fields")]
		private string RequestedFieldsValue
		{
			get { return string.Join(",", this.RequestedFields); }
			set { this.RequestedFields = value.Split(',').ToList(); }
		}

		/// <summary>
		/// The list of response fields. The nested fields are separated by dots.
		/// To specify the fields that should be excluded from the response, "-" sign before the field name is used.
		/// If the parameter is not specified, all response fields are returned.
		/// </summary>
		/// <remarks>
		/// Optional parameter.
		/// Used for all methods that do not support authentication.
		/// </remarks>
		[JsonIgnore]
		public List<string> RequestedFields { get; set; } = new List<string>();

		/// <summary>
		/// Localization language. Valid values:
		///
		/// "en" — English(by default)
		/// "ru" — Русский
		/// "pl" — Polski
		/// "de" — Deutsch
		/// "fr" — Français
		/// "es" — Español
		/// "zh-cn" — 简体中文
		/// "tr" — Türkçe
		/// "cs" — Čeština
		/// "th" — ไทย
		/// "vi" — Tiếng Việt
		/// "ko" — 한국어
		///
		/// </summary>
		[JsonProperty("language")]
		private string LanguageValue
		{
			get { return this.Language.ReplaceLanguages(); }
			set { this.Language = value.ReplaceLanguages(); }
		}

		/// <summary>
		/// Localization language. Valid values:
		///
		/// "en" — English(by default)
		/// "ru" — Русский
		/// "pl" — Polski
		/// "de" — Deutsch
		/// "fr" — Français
		/// "es" — Español
		/// "zh-cn" — 简体中文
		/// "tr" — Türkçe
		/// "cs" — Čeština
		/// "th" — ไทย
		/// "vi" — Tiếng Việt
		/// "ko" — 한국어
		///
		/// </summary>
		[JsonIgnore]
		public Languages Language { get; set; }
	}
}