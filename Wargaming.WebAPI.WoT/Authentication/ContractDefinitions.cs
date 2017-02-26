using System.Threading.Tasks;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.Requests;
using Wargaming.WebAPI.Responses;

namespace Wargaming.WebAPI
{
	public static partial class ContractDefinitions
	{
		internal static ContractDefinition LoginDefinition = new ContractDefinition("wot", " auth", "login", HttpProtocol.HTTPS);
		internal static ContractDefinition ProlongDefinition = new ContractDefinition("wot", " auth", "prolongate", HttpProtocol.HTTPS, HttpMethod.POST);
		internal static ContractDefinition LogoutDefinition = new ContractDefinition("wot", " auth", "logout", HttpProtocol.HTTPS, HttpMethod.POST);

		public static Task<LoginResponse> Execute(this LoginRequest request, Servers server)
		{
			return request.Execute<LoginRequest, LoginResponse>(server, LoginDefinition);
		}

		public static Task<ProlongResponse> Execute(this ProlongRequest request, Servers server)
		{
			return request.Execute<ProlongRequest, ProlongResponse>(server, ProlongDefinition);
		}

		public static Task<LogoutResponse> Execute(this LogoutRequest request, Servers server)
		{
			return request.Execute<LogoutRequest, LogoutResponse>(server, LogoutDefinition);
		}
	}
}