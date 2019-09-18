using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;

namespace UPSValidation.Request
{
    public class ServiceAccessToken
    {
        /// <summary> UPS assigned API access number </summary>
        [JsonProperty("AccessLicenseNumber")]
        public string LicenseNumber = ConfigurationManager.AppSettings["AccessLicenseNumber"];
    }
}
