using System.Threading.Tasks;
using Wargaming.WebAPI.Common.Requests;
using Wargaming.WebAPI.Common.Responses;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.Common
{
    public static partial class ContractDefinitions
    {
        internal static ContractDefinition TagsDefinition = new ContractDefinition("wgn", "wgtv", "tags");

        public static Task<TagsResponse> Execute(this TagsRequest request, Servers server)
        {
            return request.Execute<TagsRequest, TagsResponse>(server, TagsDefinition);
        }
    }
}