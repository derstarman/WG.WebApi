﻿using System.Collections.Generic;
using Wargaming.WebAPI.Common.Model;
using Wargaming.WebAPI.Responses;

namespace Wargaming.WebAPI.Common.Responses
{
    public class ClanMessageBoardResponse : ResponseBase<Dictionary<string, List<ClanMessageBoardEntry>>>
    {
    }
}