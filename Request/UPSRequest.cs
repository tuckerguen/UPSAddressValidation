using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UPSValidation.Request
{
    public class UPSRequest
    {
        /// <summary> Object containing access key, username and password /// </summary>
        public UPSSecurity UPSSecurity = new UPSSecurity();

        /// <summary> Object containing request data /// </summary>
        public XAVRequest XAVRequest { get; set; }
    }
}
