using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace UPSValidation.Request
{ 
    public class UsernameToken
    {
        /// <summary> UPS account username </summary>
        public string Username = ConfigurationManager.AppSettings["UPSUsername"];

        /// <summary> UPS account password </summary>
        public string Password = ConfigurationManager.AppSettings["UPSPassword"];
    }
}
