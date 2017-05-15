﻿using System.Collections.Generic;
using IdentityServer4;
using IdentityServer4.Models;

namespace IdentityServer.Helpers
{
    internal class Clients {
        public static IEnumerable<Client> Get() {
            return new List<Client> {
                new Client {
                    ClientId = "fletnix",
                    ClientName = "Fletnix totally not a copy of netflix...",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "role",
                        "api1"
                    },
                    RedirectUris = new List<string> {"http://localhost:5000/signin-oidc"},
                    PostLogoutRedirectUris = new List<string> {"http://localhost:5000"}
                }
            };
        }
    }
}