using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Test;
using System.Security.Claims;
using IdentityModel;

namespace FhirIdentity.Entities
{
    public class Users
    {
        public static List<TestUser> Get()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "F438F148-C70C-4EB5-B1AE-8469C443A424",
                    Username = "fhiruser",
                    Password = "fhirpassword",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Email, ""),
                        new Claim(JwtClaimTypes.Role, "admin")
                    }
                }
            };
        }
    }
}
