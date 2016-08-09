using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreeTime.WebApp.Startup))]
namespace FreeTime.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
