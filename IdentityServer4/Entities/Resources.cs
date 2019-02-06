﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace FhirIdentity.Entities
{
    public class Resources
    {
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource
                {
                    Name = "role",
                    UserClaims = new List<string> { "role"}
                }
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource
                {
                    Name = "FhirApi",
                    DisplayName = "Fhir Api",
                    Description = "Fhir Api Access",
                    UserClaims = new List<string> { "role" },
                    ApiSecrets = new List<Secret> { new Secret("scopeSecret".Sha256())},
                    Scopes = new List<Scope>
                    {
                        new Scope("fhir.read"),
                        new Scope("fhir.write"),
                        new Scope("fhir.delete")
                    }
                }
            };
        }
    }
}
