using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;
using Wargaming.WebAPI.Extensions;

namespace Wargaming.WebAPI.Requests
{
	public abstract class CommonRequestBase
	{
		/// <summary>
		/// Application identification key used to send requests to API.
		/// </summary>
		/// <remarks>
		/// Required parameter for all methods.
		/// </remarks>
		[JsonProperty("application_id")]
		[JsonRequired]
		public string ApplicationId { get; set; }

		/// <summary>
		/// Generates the paramaters based on the current request.
		/// </summary>
		public virtual string GetParams()
		{
			var result = new List<string>();
			var members = this.GetType().GetTypeInfo().GetMembers();
			foreach (var member in members)
			{
				var val = member.GetValue(this);
				var att = member.GetCustomAttribute<JsonPropertyAttribute>();
				var ign = member.GetCustomAttribute<IgnoreGeneratingAttribute>();
				if (val != null && att != null && ign == null)
				{
					result.Add(string.Format("{0}={1}", att.PropertyName, val.ToString()));
				}
			}

			return string.Join("&", result);
		}
	}
}