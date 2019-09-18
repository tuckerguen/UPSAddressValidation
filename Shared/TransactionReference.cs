using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UPSValidation
{
    /// <summary>
    /// TransactionReference identifies transactions
    /// between client and server
    /// </summary>
    public class TransactionReference
    {
        /// <summary> 
        /// Used to synchronize request/response pairs. 
        /// Established by the client and is echoed by the server 
        /// </summary>
        public string CustomerContext { get; set; }
    }
}
