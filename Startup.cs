using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(GithubActionsStudy.Startup))]

namespace GithubActionsStudy
{
    class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            throw new System.NotImplementedException();
        }
    }

}



