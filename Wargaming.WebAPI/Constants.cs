using System.Collections.Generic;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI
{
	public static class Constants
	{
		public static Dictionary<Environments, string> Environments = new Dictionary<Environments, string>()
			{
				{ Enums.Environments.WOTB,"World of Tanks Blitz" },
				{ Enums.Environments.WOT, "World of Tanks" },
				{ Enums.Environments.WOWS,"World of Warships" },
				{ Enums.Environments.WOTG,"World of Tanks Generals" },
				{ Enums.Environments.WOWP,"World of Warplanes" },
			};

		public static Dictionary<Servers, string> Servers = new Dictionary<Servers, string>()
			{
				{ Enums.Servers.RU, "api.worldoftanks.ru" },
				{ Enums.Servers.EU, "api.worldoftanks.eu" },
				{ Enums.Servers.NA, "api.worldoftanks.com" },
				{ Enums.Servers.KR, "api.worldoftanks.kr" },
				{ Enums.Servers.ASIA, "api.worldoftanks.asia" }
			};
	}
}