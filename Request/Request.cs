using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSValidation.Request
{
    /// <summary>
    /// Request Container
    /// </summary>
    public class Request
    {
        /// <summary> Identifies the optional processing to be performed </summary>
        public string RequestOption { get; set; }

        /// <summary> Object containing customer info </summary>
        public TransactionReference TransactionReference { get; set; }

        public Request(int requestOption)
        {
            RequestOption = Convert.ToString(requestOption);
        }
    }
}
