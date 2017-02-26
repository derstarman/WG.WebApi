using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargaming.WebAPI.Common.Model
{
    public class ClanMemberInformation : ClanMember
    {
        /// <summary>
        /// Short clan info
        /// </summary>
        [JsonProperty("clan")]
        public Clan Clan { get; set; }
    }
}
