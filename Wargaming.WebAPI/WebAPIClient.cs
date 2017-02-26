using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.Requests;
using Wargaming.WebAPI.Responses;

namespace Wargaming.WebAPI
{
	public static class WebAPIClient
	{
		public static async Task<TResponse> Execute<TRequest, TResponse>(this TRequest request, Servers server, ContractDefinition contract)
			where TRequest : CommonRequestBase
			where TResponse : ResponseBase
		{
			string result = string.Empty;	
			using (var client = new HttpClient())
			{
				if (contract.Method == Enums.HttpMethod.GET)
				{
					var uri = $"{contract.Protocol.ReplaceHttpProtocol()}://{Constants.Servers[server]}/{contract.GetURIPart()}/?{request.GetParams()}";
					result = await client.GetStringAsync(uri);					
				}
				else
				{
					var uri = $"{contract.Protocol.ReplaceHttpProtocol()}://{Constants.Servers[server]}/{contract.GetURIPart()}";
					var content = new StringContent(request.GetParams());
					var response = await client.PostAsync(uri, content);
					response.EnsureSuccessStatusCode();
					result = await response.Content.ReadAsStringAsync();					
				}
			}

			return JsonConvert.DeserializeObject<TResponse>(result);
		}
	}
}