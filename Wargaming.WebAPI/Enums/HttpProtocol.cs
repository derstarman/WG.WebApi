using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.Enums
{
	public enum HttpProtocol
	{
		HTTP = 0,
		HTTPS = 1			
	}

	public static class HttpProtocolExtensions
	{
		private static Dictionary<HttpProtocol, string> Replacements = new Dictionary<HttpProtocol, string>()
			{
				{ HttpProtocol.HTTP, "http" },
				{ HttpProtocol.HTTPS, "https" },
			};

		public static string ReplaceHttpProtocol(this HttpProtocol type)
		{
			return Replacements[type];
		}

		public static HttpProtocol ReplaceHttpProtocol(this string searchTypeText)
		{
			if (Replacements.Values.Contains(searchTypeText))
			{
				return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
			}

			return HttpProtocol.HTTP;
		}
	}
}