﻿using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using System.Runtime.Intrinsics.Arm;

namespace GeekShopping.IdentityServer.Configuration
{
    public static class IdentityConfiguration
    {
        public const string Admin = "ADMIN";
        public const string Customer = "COSTUMER";

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile()
            };
        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("geek_shopping", "GeekShopping Server"),
                new ApiScope(name: "read", "Read Data."),
                new ApiScope(name: "write", "Write Data."),
                new ApiScope(name: "delete", "Delete Data."),
            };
        public static IEnumerable<Client> Clients => new 
            List<Client> 
        {
            new Client
            {
                ClientId = "client",
                ClientSecrets = {new Secret("my_super_secret".Sha256())},
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                AllowedScopes = {"read", "write", "profile"}
            },
            new Client
            {
                ClientId = "geek_shopping",
                ClientSecrets = {new Secret("my_super_secret".Sha256())},
                AllowedGrantTypes = GrantTypes.Code,
                RedirectUris = {"http://localhost:18584/signin-oidc"},
                PostLogoutRedirectUris = {"http://localhost:18584/signout-callback-oidc"},
                AllowedScopes = new List<string>
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Email,
                    IdentityServerConstants.StandardScopes.Profile,
                    "geek_shopping"
                }
            }
            
        };
    }
}
