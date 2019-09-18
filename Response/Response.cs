using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSValidation.Response
{
    public class Response
    {
        /// <summary> Gives status of API request response </summary>
        public ResponseStatus ResponseStatus { get; set; }

        /// <summary> Object containing customer info </summary>
        public TransactionReference TransactionReference { get; set; }
    }
}
