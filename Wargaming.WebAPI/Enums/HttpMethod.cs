using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.Enums
{
	public enum HttpMethod
	{
		GET = 0,
		POST = 1
	}

	public static class HttpMethodExtensions
	{
		private static Dictionary<HttpMethod, string> Replacements = new Dictionary<HttpMethod, string>()
			{
				{ HttpMethod.GET, "GET" },
				{ HttpMethod.POST, "POST" },
			};

		public static string ReplaceHttpMethod(this HttpMethod type)
		{
			return Replacements[type];
		}

		public static HttpMethod ReplaceHttpMethod(this string searchTypeText)
		{
			if (Replacements.Values.Contains(searchTypeText))
			{
				return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
			}

			return HttpMethod.GET;
		}
	}
}