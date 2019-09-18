using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UPSValidation.Response.ErrorHandling.ErrorFault
{
    class Fault
    {
        /// <summary> Identifier of the Fault </summary>
        [JsonProperty("faultcode")]
        public string FaultCode { get; set; }

        /// <summary> Indicates the cause of the problem, a URI is typically returned </summary>
        [JsonProperty("faultactor")]
        public string FaultActor { get; set; }

        /// <summary> Explanation of the fault and a basic description of the error </summary>
        [JsonProperty("faultstring")]
        public string FaultString { get; set; }

        /// <summary> Contains the API-specific Error Code, Severity, and Description returned by the UPS system </summary>
        [JsonProperty("detail")]
        public detail detail { get; set; }
    }
}
