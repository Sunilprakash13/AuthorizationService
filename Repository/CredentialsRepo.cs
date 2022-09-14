using AuthorizationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationService.Repository
{
    public class CredentialsRepo:ICredentialsRepo
    {
        //private Dictionary<string, string> ValidUsersDictionary = new Dictionary<string, string>()
        //{
        //       {"Sunil","Prakash"},
        //       {"Kavin","Raj"},
        //       {"Arun","Pradeep"},
        //       {"Praveen","shaw"}
        //};

        private readonly AuthorizationDBContext db;
        public CredentialsRepo(AuthorizationDBContext _db)
        {
            this.db = _db;

        }

        public Dictionary<string, string> ValidUsersDictionary { get; private set; }

        

        //public Dictionary<string, string> GetCredentials()
        public Dictionary<string, string> GetCredentials()
        {

            var ValidUserDictionary1 = db.authenticates.Select(x => new Authenticate
            {
                Id = x.Id,
                Name = x.Name,
                Password = x.Password
            }).ToList();


            var ValidUserDictionary = ValidUserDictionary1.Select(p => new { Name = p.Name, Password = p.Password })
    .ToDictionary(x => x.Name, x => x.Password);

            return ValidUserDictionary;
        }

        

   

         
    }
}
