using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Wargaming.WebAPI.Enums;

namespace Wargaming.WebAPI.Common.Model
{
    public class ClanGlossary
    {
        /// <summary>
        /// Available clan positions
        /// </summary>
        [JsonProperty("clans_roles")]
        private Dictionary<string, string> ClanRolesValues
        {
            get { return this.ClanRoles.ToDictionary(x => x.Key.ReplaceRoles(), x => x.Value.ToString()); }
            set { this.ClanRoles = value.ToDictionary(x => x.Key.ReplaceRoles(), x => x.Value); }
        }

        /// <summary>
        /// Available clan positions
        /// </summary>
        [JsonIgnore]
        public Dictionary<Roles, string> ClanRoles { get; set; }
    }
}