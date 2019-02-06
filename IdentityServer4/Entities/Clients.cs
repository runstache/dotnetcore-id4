using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace FhirIdentity.Entities
{
    public class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client()
                {
                    ClientId = "fhirClient",
                    ClientName = "OAuth Fhir Client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("fhirSecret".Sha256())                        
                    },
                    AllowedScopes = new List<string> {"fhir.read", "fhir.write", "fhir.delete"}
                }
            };

        }
    }
}
