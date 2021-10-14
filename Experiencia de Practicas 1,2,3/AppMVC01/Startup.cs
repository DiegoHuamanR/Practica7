using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppMVC01.Startup))]
namespace AppMVC01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
