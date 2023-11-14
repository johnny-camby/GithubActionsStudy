using System;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(GithubActionsStudy.Startup))]

namespace GithubActionsStudy
{
    class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            Console.WriteLine("Azure dev deploy test");
        }
    }
}

