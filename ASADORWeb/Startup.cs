using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASADORWeb.Startup))]
namespace ASADORWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
