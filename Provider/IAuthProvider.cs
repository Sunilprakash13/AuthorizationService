using AuthorizationService.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationService.Provider
{
    public interface IAuthProvider
    {
        public string GenerateJSONWebToken(Authenticate userInfo, IConfiguration _config);
        public dynamic AuthenticateUser(Authenticate login);
    }
}
