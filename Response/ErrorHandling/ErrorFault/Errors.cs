using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UPSValidation.Response.ErrorHandling.ErrorFault
{
    class Errors
    {
        public ErrorDetail ErrorDetail { get; set; }

        [JsonProperty("PrimryErrorCode")]
        public PrimaryErrorCode PrimaryErrorCode { get; set; }
    }
}
