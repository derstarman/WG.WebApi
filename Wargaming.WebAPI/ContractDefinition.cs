using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.Extensions;

namespace Wargaming.WebAPI
{
	public class ContractDefinition
	{
		[JsonConstructor]
		private ContractDefinition()
		{ }

		public ContractDefinition(string api_name, string methodBlock, string methodName, HttpProtocol protocol = HttpProtocol.HTTP, HttpMethod method = HttpMethod.GET)
		{
			this.API_Name = api_name;
			this.MethodBlock = methodBlock;
			this.MethodName = methodName;
			this.Protocol = protocol;
			this.Method = method;
		}

		[JsonProperty]
		public string API_Name { get; private set; }

		[JsonProperty]
		public string MethodBlock { get; private set; }

		[JsonProperty]
		public string MethodName { get; private set; }

		[JsonProperty]
		[IgnoreGenerating]
		public HttpProtocol Protocol { get; private set; }

		[JsonProperty]
		[IgnoreGenerating]
		public HttpMethod Method { get; private set; }

		public virtual string GetURIPart()
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
					result.Add(val.ToString());
				}
			}

			return string.Join(@"/", result);
		}
	}
}