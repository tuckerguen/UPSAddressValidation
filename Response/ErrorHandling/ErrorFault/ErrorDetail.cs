using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UPSValidation.Response.ErrorHandling.ErrorFault
{
    class ErrorDetail
    {
        ///<summary> The error type </summary>
        public string Severity { get; set; }

        [JsonProperty("PrimaryErrorCode")]
        public PrimaryErrorCode PrimaryErrorCode { get; set; }
    }
}
