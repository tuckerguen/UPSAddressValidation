using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UPSValidation.Response
{
    public class XAVResponse
    {
        /// <summary> Settings used for the request /// </summary>
        public Response Response { get; set; }

        /// <summary> List of candidate addresses returned by the api /// </summary>
        [JsonConverter(typeof(SingleValueArrayConverter<Candidate>))]
        public List<Candidate> Candidate { get; set; }

        /// <summary> Is an empty string ("") if the given address is valid /// </summary>
        public string ValidAddressIndicator { get; set; }

        /// <summary> Is an empty string ("") if the given address is ambiguous /// </summary>
        public string AmbiguousAddressIndicator { get; set; }

        /// <summary> Is an empty string ("") if the given address is invalid /// </summary>
        public string NoCandidatesIndicator { get; set; }
    }
}
