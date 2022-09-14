using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationService.Repository
{
    public interface ICredentialsRepo
    {
        public Dictionary<string, string> GetCredentials();

        //public dynamic GetCredentials();
    }
}
