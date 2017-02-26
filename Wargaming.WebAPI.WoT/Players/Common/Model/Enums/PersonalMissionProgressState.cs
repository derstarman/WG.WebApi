using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargaming.WebAPI.WoT.Enums
{
	public enum PersonalMissionProgressState
	{
		None = 0,
		Unlocked = 1,
		NeedGetMaimReward = 2,
		MainRewardGotten = 3,
		NeedGetAddReward = 4,
		NeedGetAllRewards = 5,
		AllRewardsGotten = 6
	}

	public static class PersonalMissionProgressStateExtensions
	{
		private static Dictionary<PersonalMissionProgressState, string> Replacements = new Dictionary<PersonalMissionProgressState, string>()
			{
				{ PersonalMissionProgressState.None, "NONE" },
				{ PersonalMissionProgressState.Unlocked, "UNLOCKED" },
				{ PersonalMissionProgressState.NeedGetMaimReward, "NEED_GET_MAIN_REWARD" },
				{ PersonalMissionProgressState.MainRewardGotten, "MAIN_REWARD_GOTTEN" },
				{ PersonalMissionProgressState.NeedGetAddReward, "NEED_GET_ADD_REWARD" },
				{ PersonalMissionProgressState.NeedGetAllRewards, "NEED_GET_ALL_REWARDS" },
				{ PersonalMissionProgressState.AllRewardsGotten, "ALL_REWARDS_GOTTEN" },
			};

		public static string ReplacePersonalMissionProgressState(this PersonalMissionProgressState type)
		{
			return Replacements[type];
		}

		public static PersonalMissionProgressState ReplacePersonalMissionProgressState(this string searchTypeText)
		{
			if (Replacements.Values.Contains(searchTypeText))
			{
				return Replacements.First(r => r.Value.Equals(searchTypeText, StringComparison.CurrentCulture)).Key;
			}

			return PersonalMissionProgressState.None;
		}
	}
}