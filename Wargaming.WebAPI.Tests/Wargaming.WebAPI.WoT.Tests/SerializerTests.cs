using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Wargaming.WebAPI.WoT.Responses;
using System.Linq;

namespace Wargaming.WebAPI.WoT.Tests
{
	[TestClass]
	public class SerializerTests
	{
		[TestMethod]
		public void DeserializeVehicleAchiements()
		{
			#region [Data]

			var data = @"{
	""status"": ""ok"",

	""meta"": {
				""count"": 1

	},
	""data"": {
				""500230645"": [
					{
				""achievements"": {
					""medalCarius"": 4,
							""aimer"": 1,
							""armorPiercer"": 10,
							""medalEkins"": 3,
							""medalKay"": 3,
							""duelist"": 4,
							""medalLeClerc"": 4,
							""supporter"": 8,
							""steelwall"": 1,
							""medalAbrams"": 4,
							""medalPoppel"": 4,
							""mainGun"": 2,
							""handOfDeath"": 3,
							""bonecrusher"": 17,
							""marksOnGun"": 1,
							""titleSniper"": 26,
							""markOfMastery"": 3,
							""arsonist"": 1,
							""charmed"": 1,
							""fighter"": 4,
							""medalLavrinenko"": 4,
							""impenetrable"": 3,
							""sturdy"": 2,
							""shootToKill"": 31,
							""medalKnispel"": 3

				},
				""series"": {
					""armorPiercer"": 7,
					""aimer"": 0,
					""titleSniper"": 7,
					""tacticalBreakthrough"": 0,
					""invincible"": 0,
					""victoryMarch"": 0,
					""deathTrack"": 0,
					""diehard"": 3,
					""WFC2014"": 0,
					""handOfDeath"": 0
				},
				""max_series"": {
					""armorPiercer"": 10,
					""aimer"": 1,
					""titleSniper"": 26,
					""tacticalBreakthrough"": 0,
					""invincible"": 1,
					""victoryMarch"": 0,
					""deathTrack"": 0,
					""diehard"": 5,
					""WFC2014"": 0,
					""handOfDeath"": 3
				},
				""account_id"": 500230645,
				""tank_id"": 3921
			},
			{
				""achievements"": {

					""medalCarius"": 3,
					""aimer"": 1,
					""armorPiercer"": 25,
					""medalEkins"": 4,
					""medalKay"": 3,
					""duelist"": 21,
					""medalLeClerc"": 3,
					""demolition"": 2,
					""supporter"": 7,
					""even"": 1,
					""medalBrothersInArms"": 8,
					""medalAbrams"": 3,
					""medalPoppel"": 3,
					""medalPascucci"": 2,
					""mainGun"": 10,
					""handOfDeath"": 3,
					""sniper"": 10,
					""warrior"": 4,
					""marksOnGun"": 2,
					""titleSniper"": 26,
					""medalCrucialContribution"": 1,
					""medalLehvaslaiho"": 2,
					""markOfMastery"": 4,
					""medalRadleyWalters"": 1,
					""arsonist"": 7,
					""charmed"": 3,
					""fighter"": 22,
					""medalLavrinenko"": 3,
					""soldierOfFortune"": 4,
					""bonecrusher"": 57,
					""shootToKill"": 134,
					""medalKnispel"": 3

				},
				""series"": {
					""armorPiercer"": 0,
					""aimer"": 0,
					""titleSniper"": 1,
					""tacticalBreakthrough"": 0,
					""invincible"": 0,
					""victoryMarch"": 0,
					""deathTrack"": 0,
					""diehard"": 0,
					""WFC2014"": 0,
					""handOfDeath"": 0
				},
				""max_series"": {
					""armorPiercer"": 25,
					""aimer"": 1,
					""titleSniper"": 26,
					""tacticalBreakthrough"": 0,
					""invincible"": 1,
					""victoryMarch"": 0,
					""deathTrack"": 0,
					""diehard"": 5,
					""WFC2014"": 0,
					""handOfDeath"": 3
				},
				""account_id"": 500230645,
				""tank_id"": 1105
			}
		]
	}
}";
			#endregion

			var result = JsonConvert.DeserializeObject<PlayerVehicleAchievementsResponse>(data);

			Assert.AreEqual(result.Result.Count, 1);
			Assert.AreEqual(result.Result.First().Value.Count, 2);
		}

		[TestMethod]
		public void DeserializeVehicleStatistics()
		{
			#region [Data]

			var data = @"{
	""status"": ""ok"",

	""meta"": {
				""count"": 1

	},
	""data"": {
				""500230645"": [
					{
				""clan"": {
					""spotted"": 0,
							""hits"": 0,
							""battle_avg_xp"": 0,
							""draws"": 0,
							""max_xp"": 0,
							""wins"": 0,
							""losses"": 0,
							""capture_points"": 0,
							""battles"": 0,
							""damage_dealt"": 0,
							""hits_percents"": 0,
							""damage_received"": 0,
							""max_frags"": 0,
							""shots"": 0,
							""xp"": 0,
							""max_damage"": 0,
							""frags"": 0,
							""survived_battles"": 0,
							""dropped_capture_points"": 0

				},
				""stronghold_skirmish"": {
					""spotted"": 0,
					""max_xp"": 0,
					""direct_hits_received"": 0,
					""explosion_hits"": 0,
					""piercings_received"": 0,
					""piercings"": 0,
					""xp"": 0,
					""survived_battles"": 0,
					""dropped_capture_points"": 0,
					""hits_percents"": 0,
					""draws"": 0,
					""battles"": 0,
					""damage_received"": 0,
					""frags"": 0,
					""capture_points"": 0,
					""max_damage"": 0,
					""hits"": 0,
					""battle_avg_xp"": 0,
					""wins"": 0,
					""losses"": 0,
					""damage_dealt"": 0,
					""no_damage_direct_hits_received"": 0,
					""max_frags"": 0,
					""shots"": 0,
					""explosion_hits_received"": 0,
					""tanking_factor"": 0
				},
				""regular_team"": {
					""spotted"": 0,
					""hits"": 0,
					""battle_avg_xp"": 0,
					""draws"": 0,
					""max_xp"": 0,
					""wins"": 0,
					""losses"": 0,
					""capture_points"": 0,
					""battles"": 0,
					""damage_dealt"": 0,
					""hits_percents"": 0,
					""damage_received"": 0,
					""max_frags"": 0,
					""shots"": 0,
					""xp"": 0,
					""max_damage"": 0,
					""frags"": 0,
					""survived_battles"": 0,
					""dropped_capture_points"": 0
				},
				""account_id"": 500230645,
				""max_xp"": 1743,
				""company"": {
					""spotted"": 0,
					""hits"": 0,
					""battle_avg_xp"": 0,
					""draws"": 0,
					""wins"": 0,
					""losses"": 0,
					""capture_points"": 0,
					""battles"": 0,
					""damage_dealt"": 0,
					""hits_percents"": 0,
					""damage_received"": 0,
					""shots"": 0,
					""xp"": 0,
					""frags"": 0,
					""survived_battles"": 0,
					""dropped_capture_points"": 0
				},
				""random"": {
					""spotted"": 104,
					""hits"": 821,
					""battle_avg_xp"": 831,
					""draws"": 0,
					""max_xp"": 0,
					""wins"": 51,
					""losses"": 42,
					""capture_points"": 60,
					""battles"": 93,
					""damage_dealt"": 130167,
					""hits_percents"": 79,
					""damage_received"": 125056,
					""max_frags"": 0,
					""shots"": 1037,
					""xp"": 77307,
					""max_damage"": 0,
					""frags"": 87,
					""survived_battles"": 34,
					""dropped_capture_points"": 176
				},
				""all"": {
					""spotted"": 104,
					""avg_damage_blocked"": 639.73,
					""direct_hits_received"": 628,
					""explosion_hits"": 0,
					""piercings_received"": 377,
					""piercings"": 608,
					""xp"": 77307,
					""survived_battles"": 34,
					""dropped_capture_points"": 176,
					""hits_percents"": 79,
					""draws"": 0,
					""battles"": 93,
					""damage_received"": 125056,
					""frags"": 87,
					""capture_points"": 60,
					""hits"": 821,
					""battle_avg_xp"": 831,
					""wins"": 51,
					""losses"": 42,
					""damage_dealt"": 130167,
					""no_damage_direct_hits_received"": 251,
					""shots"": 1037,
					""explosion_hits_received"": 23,
					""tanking_factor"": 0.52
				},
				""stronghold_defense"": {
					""spotted"": 0,
					""max_xp"": 0,
					""direct_hits_received"": 0,
					""explosion_hits"": 0,
					""piercings_received"": 0,
					""piercings"": 0,
					""xp"": 0,
					""survived_battles"": 0,
					""dropped_capture_points"": 0,
					""hits_percents"": 0,
					""draws"": 0,
					""battles"": 0,
					""damage_received"": 0,
					""frags"": 0,
					""capture_points"": 0,
					""max_damage"": 0,
					""hits"": 0,
					""battle_avg_xp"": 0,
					""wins"": 0,
					""losses"": 0,
					""damage_dealt"": 0,
					""no_damage_direct_hits_received"": 0,
					""max_frags"": 0,
					""shots"": 0,
					""explosion_hits_received"": 0,
					""tanking_factor"": 0
				},
				""max_frags"": 5,
				""fallout"": {
					""spotted"": 0,
					""avg_damage_assisted_track"": 0,
					""max_xp"": 0,
					""avg_damage_blocked"": 0,
					""direct_hits_received"": 0,
					""explosion_hits"": 0,
					""piercings_received"": 0,
					""flag_capture_solo"": 0,
					""piercings"": 0,
					""xp"": 0,
					""survived_battles"": 0,
					""dropped_capture_points"": 0,
					""max_frags_with_avatar"": 0,
					""hits_percents"": 0,
					""draws"": 0,
					""death_count"": 0,
					""battles"": 0,
					""damage_received"": 0,
					""avg_damage_assisted"": 0,
					""frags"": 0,
					""avg_damage_assisted_radio"": 0,
					""capture_points"": 0,
					""max_win_points"": 0,
					""avatar_frags"": 0,
					""max_damage"": 0,
					""resource_absorbed"": 0,
					""hits"": 0,
					""battle_avg_xp"": 0,
					""wins"": 0,
					""losses"": 0,
					""damage_dealt"": 0,
					""avatar_damage_dealt"": 0,
					""win_points"": 0,
					""no_damage_direct_hits_received"": 0,
					""max_frags"": 0,
					""shots"": 0,
					""explosion_hits_received"": 0,
					""flag_capture"": 0,
					""tanking_factor"": 0,
					""max_damage_with_avatar"": 0
				},
				""team"": {
					""spotted"": 0,
					""hits"": 0,
					""battle_avg_xp"": 0,
					""draws"": 0,
					""max_xp"": 0,
					""wins"": 0,
					""losses"": 0,
					""capture_points"": 0,
					""battles"": 0,
					""damage_dealt"": 0,
					""hits_percents"": 0,
					""damage_received"": 0,
					""max_frags"": 0,
					""shots"": 0,
					""xp"": 0,
					""max_damage"": 0,
					""frags"": 0,
					""survived_battles"": 0,
					""dropped_capture_points"": 0
				},
				""globalmap"": {
					""spotted"": 0,
					""avg_damage_assisted_track"": 0,
					""avg_damage_blocked"": 0,
					""direct_hits_received"": 0,
					""explosion_hits"": 0,
					""piercings_received"": 0,
					""piercings"": 0,
					""xp"": 0,
					""survived_battles"": 0,
					""dropped_capture_points"": 0,
					""hits_percents"": 0,
					""draws"": 0,
					""battles"": 0,
					""damage_received"": 0,
					""avg_damage_assisted"": 0,
					""frags"": 0,
					""avg_damage_assisted_radio"": 0,
					""capture_points"": 0,
					""hits"": 0,
					""battle_avg_xp"": 0,
					""wins"": 0,
					""losses"": 0,
					""damage_dealt"": 0,
					""no_damage_direct_hits_received"": 0,
					""shots"": 0,
					""explosion_hits_received"": 0,
					""tanking_factor"": 0
				},
				""frags"": {
					""49"": 2,
					""513"": 1,
					""529"": 3,
					""1073"": 1,
					""1105"": 2,
					""1297"": 1,
					""1569"": 1,
					""2321"": 1,
					""2561"": 1,
					""2817"": 1,
					""2849"": 4,
					""2865"": 1,
					""3137"": 4,
					""3153"": 2,
					""3377"": 1,
					""3873"": 2,
					""4113"": 1,
					""4353"": 1,
					""4385"": 1,
					""5137"": 1,
					""5377"": 6,
					""5393"": 1,
					""5473"": 2,
					""5697"": 1,
					""5889"": 1,
					""6657"": 1,
					""7201"": 1,
					""7425"": 1,
					""7937"": 1,
					""7953"": 1,
					""8225"": 1,
					""8465"": 1,
					""8977"": 1,
					""9217"": 2,
					""9745"": 1,
					""10001"": 2,
					""10241"": 1,
					""11009"": 1,
					""11025"": 1,
					""11345"": 1,
					""11521"": 1,
					""11553"": 3,
					""11601"": 1,
					""11793"": 1,
					""13137"": 1,
					""13345"": 1,
					""13825"": 1,
					""14097"": 1,
					""14145"": 3,
					""14673"": 1,
					""15681"": 1,
					""18209"": 1,
					""18961"": 1,
					""54785"": 1,
					""55297"": 2,
					""55313"": 1,
					""55889"": 1,
					""56609"": 1,
					""63553"": 1,
					""64049"": 1,
					""64065"": 1,
					""64817"": 1
				},
				""mark_of_mastery"": 3,
				""in_garage"": true,
				""tank_id"": 3921
			}
		]
	}
}";

			#endregion

			var result = JsonConvert.DeserializeObject<PlayerVehicleStatisticsResponse>(data);

			Assert.AreEqual(result.Result.Count, 1);
			Assert.AreEqual(result.Result.First().Value.Count, 1);
		}
	}
}
