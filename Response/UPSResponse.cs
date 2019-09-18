using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UPSValidation.Response
{
    public class UPSResponse
    {
        /// <summary> Object containing repsonse data /// </summary>
        public XAVResponse XAVResponse { get; set; }
    }
}
