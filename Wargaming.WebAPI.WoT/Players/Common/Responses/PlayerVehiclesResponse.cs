using System.Collections.Generic;
using Wargaming.WebAPI.Responses;
using Wargaming.WebAPI.WoT.Model;

namespace Wargaming.WebAPI.WoT.Responses
{
	public class PlayerVehiclesResponse : ResponseBase<Dictionary<string, List<PlayerVehicleEntry>>>
	{
	}
}