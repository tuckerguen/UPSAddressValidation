using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSValidation.Response.ErrorHandling.ErrorFault
{
    class PrimaryErrorCode
    {
        ///<summary> A unique numerical value used to identify the error </summary>
        public string Code { get; set; }

        /// <summary> A description of the general problem </summary>
        public string Description { get; set; }
    }
}
