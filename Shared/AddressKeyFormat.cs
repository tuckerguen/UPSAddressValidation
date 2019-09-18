using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UPSValidation
{

    public class AddressKeyFormat
    {
        /// <summary> Financially respnsible recipient of the shipment </summary>
        public string ConsigneeName { get; set; }

        /// <summary> List containing address line and aparment/suite nubmer </summary>
        [JsonConverter(typeof(SingleValueArrayConverter<string>)), JsonProperty("AddressLine")]
        public List<string> Address { get; set; }

        /// <summary> City </summary>
        [JsonProperty("PoliticalDivision2")]
        public string City { get; set; }

        /// <summary> State </summary>
        [JsonProperty("PoliticalDivision1")]
        public string State { get; set; }

        /// <summary> Zip/Postal Code (firts 5 digits) </summary>
        [JsonProperty("PostcodePrimaryLow")]
        public string Zip { get; set; }

        /// <summary> Zip/Postal Code Extension (second 4 digits) </summary>
        [JsonProperty("PostcodeExtendedLow")]
        public string ZipExtension { get; set; }

        /// <summary> Country code (2 digit) </summary>
        public string CountryCode { get; set; }
    }
}
