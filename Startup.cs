using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthPrediction.Startup))]
namespace HealthPrediction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
