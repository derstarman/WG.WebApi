using System.Threading.Tasks;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.WoT.Requests;
using Wargaming.WebAPI.WoT.Responses;

namespace Wargaming.WebAPI.WoT
{
	public static partial class ContractDefinitions
	{
		internal static ContractDefinition GlobalMapFrontsDefinition = new ContractDefinition("wot", "globalmap", "fronts");
		internal static ContractDefinition GlobalMapProvincesDefinition = new ContractDefinition("wot", "globalmap", "provinces");
	}
}