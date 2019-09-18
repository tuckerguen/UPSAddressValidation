using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UPSValidation.Request
{
    /// <summary>
    /// Request Container
    /// </summary>
    public class UPSSecurity
    {
        /// <summary> Container used to store the username and password </summary>
        [JsonProperty("UsernameToken")]
        public UsernameToken Username = new UsernameToken();

        /// <summary> Container used to store the AccessLicenseNumber </summary>
        [JsonProperty("ServiceAccessToken")]
        public ServiceAccessToken AccessToken = new ServiceAccessToken();
    }
}
