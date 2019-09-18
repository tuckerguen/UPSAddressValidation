using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;
using UPSValidation.Response;
using UPSValidation.Request;


namespace UPSValidation
{
    /// <summary>
    /// Contains methods for verifying addresses with the UPS api
    /// </summary>
    public class UPS
    {
        /// <summary> Static HttpClient reference for api calls </summary>
        private static HttpClient _httpClient = new HttpClient();

        /// <summary> The UPS rest api url (different for testing and production use) </summary>
        private string Url = "https://onlinetools.ups.com/rest/XAV";

        /// <summary> Is the api use for testing or for production </summary>
        public bool isTesting = Convert.ToBoolean(ConfigurationManager.AppSettings["isTesting"]);

        /// <summary> Identifies the optional processing to be performed </summary>
        public int RequestOption = 1;

        public UPS (int requestOption)
        {
            RequestOption = requestOption;
        }


        /// <summary>
        /// Asynchronously requests verification from the UPS api of the address passed to it
        /// </summary>
        /// <param name="request">Object specifying details of the request to the UPS api</param>
        /// <returns></returns>
        public async Task<UPSResponse> Request(AddressKeyFormat address)
        {
            var request = new UPSRequest()
            {
                XAVRequest = new XAVRequest(RequestOption)
                {
                    AddressKeyFormat = address
                }
            };

            var requestJson = JsonConvert.SerializeObject(request);
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");
            var reply = await _httpClient.PostAsync(Url, content);
            var responseContent = await reply.Content.ReadAsStringAsync();
            UPSResponse response = JsonConvert.DeserializeObject<UPSResponse>(responseContent);
            return response;
        }

        /// <summary>
        /// Tells if the given address is valid, ambiguous, or invalid (according to UPS)
        /// </summary>
        /// <param name="Address1">Street name and number</param>
        /// <param name="address2">Apartment or suite number. If N/A, enter null or empty string</param>
        /// <param name="city">City</param>
        /// <param name="state">State</param>
        /// <param name="zip">Zip/postal code</param>
        /// <returns>
        /// If valid, returns list of length 1 containing UPS's version of the valid address
        /// If ambiguous, returns a list up to length 15 containing UPS suggested versions of the address
        /// If invalid, returns null
        /// </returns>
        public async Task<List<Address>> Validate(string address1, string address2, string city, string state, string zip)
        {
            var addressKeyFormat = new AddressKeyFormat()
            {
                Address = new List<string>() { address1, address2 },
                City = city,
                State = state,
                CountryCode = "US",
                Zip = zip.Length > 5 ? zip.Substring(0, 5) : zip,
                ZipExtension = zip.Length > 5 ? zip.Substring(4, 4) : null
            };

            var response = await Request(addressKeyFormat);
            if(response.XAVResponse == null)
                return null;
            
            if (response.XAVResponse.NoCandidatesIndicator == "")
                return null;

            var candidates = response.XAVResponse.Candidate;
            var candidateAddresses = new List<Address>();

            foreach(Candidate c in candidates)
            {
                var candAddress = c.AddressKeyFormat;
                candidateAddresses.Add
                (
                    new Address()
                    {
                        Address1 = candAddress.Address[0],
                        Address2 = candAddress.Address.Count > 1 ? candAddress.Address[1] : null,
                        City = candAddress.City,
                        State = candAddress.State,
                        Zip = candAddress.Zip + ("-" + candAddress.ZipExtension ?? ""),
                        Country = candAddress.CountryCode
                    }
                );
            }
            return candidateAddresses;          
        }

    }
}
