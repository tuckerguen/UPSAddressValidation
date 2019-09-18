using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSValidation.Response.ErrorHandling.Simple
{
    class Error
    {
        /// <summary> Unique numerical identifier of the error </summary>
        public string Code { get; set; }

        /// <summary> Description of the error </summary>
        public string Description { get; set; }
    }
}
