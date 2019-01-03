using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EventParis.Startup))]
namespace EventParis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
