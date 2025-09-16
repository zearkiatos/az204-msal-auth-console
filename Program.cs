using System;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Configuration;

namespace MSALAuthConsole
{
    class Program
    {

        private readonly string _clientId = AppConfiguration.ClientId;
        private readonly string _tenantId = AppConfiguration.TenantId;

        public static async Task Main(string[] args)
        {

            var app = PublicClientApplicationBuilder
                .Create(_clientId)
      
                .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)

                .WithRedirectUri("http://localhost")
                .Build(); 
            string[] scopes = { "user.read" };
            
            AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

            Console.WriteLine($"Token:\t{result.AccessToken}");
        }
    }
}