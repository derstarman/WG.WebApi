using Newtonsoft.Json;

namespace Wargaming.WebAPI.Common.Model
{
    public class AccountInformation : Account
    {
        /// <summary>
        /// Player's private data
        /// </summary>
        [JsonProperty("private")]
        public AccountPrivateInformation PrivateData { get; set; }
    }
}