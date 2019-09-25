using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewWebApp.Startup))]
namespace NewWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
