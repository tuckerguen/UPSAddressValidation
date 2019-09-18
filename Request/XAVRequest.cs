using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UPSValidation.Request
{
    public class XAVRequest
    {
        /// <summary> Settings for the request /// </summary>
        public Request Request { get; set; }

        /// <summary> This address /// </summary>
        public AddressKeyFormat AddressKeyFormat { get; set; }

        /// <summary> Number of candidates to be returned by the api /// </summary>
        public string MaximumCandidateListSize { get; set; }

        public XAVRequest(int requestOption)
        {
            Request = new Request(requestOption);
        }

    }
}
