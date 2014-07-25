using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTest6.Startup))]
namespace WebTest6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
