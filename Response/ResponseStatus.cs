using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSValidation.Response
{
    public class ResponseStatus
    {
        /// <summary> Response code from the api /// </summary>
        public string Code { get; set; }
        
        /// <summary> Description of the response /// </summary>
        public string Description { get; set; }
    }
}
