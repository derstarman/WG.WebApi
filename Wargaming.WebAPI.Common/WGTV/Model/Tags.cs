using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargaming.WebAPI.Common.Model
{
    public class Tags
    {
        /// <summary>
        /// List of categories
        /// </summary>
        [JsonProperty("categories")]
        public List<CategoryTag> Categories { get; set; }

        /// <summary>
        /// List of programs
        /// </summary>
        [JsonProperty("programs")]
        public List<CategoryTag> Programs { get; set; }

        /// <summary>
        /// List of projects
        /// </summary>
        [JsonProperty("projects")]
        public List<CategoryTag> Projects { get; set; }
    }
}
