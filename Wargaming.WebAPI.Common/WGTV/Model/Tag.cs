using Newtonsoft.Json;

namespace Wargaming.WebAPI.Common.Model
{
    public abstract class TagBase
    {
        /// <summary>
        /// Localized name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Sort order
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }
    }

    public class CategoryTag : TagBase
    {
        /// <summary>
        /// Content category ID
        /// </summary>
        [JsonProperty("category_id")]
        public int Id { get; set; }
    }

    public class ProgramTag : TagBase
    {
        /// <summary>
        /// Program ID
        /// </summary>
        [JsonProperty("program_id")]
        public int Id { get; set; }
    }

    public class ProjectTag : TagBase
    {
        /// <summary>
        /// Game project ID
        /// </summary>
        [JsonProperty("project_id")]
        public int Id { get; set; }
    }
}