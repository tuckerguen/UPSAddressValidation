using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPSValidation
{
    public class Address
    {
        /// <summary> The street address (# + street) </summary>
        public string Address1 { get; set; }

        /// <summary> The street sub-address (building or apartment) </summary>
        public string Address2 { get; set; }

        /// <summary> City </summary>
        public string City { get; set; }

        /// <summary> State </summary>
        public string State { get; set; }

        /// <summary> Zip </summary>
        public string Zip { get; set; }

        /// <summary> Country Code (2-digit) </summary>
        public string Country { get; set; }
    }
}
