using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1351300203.Startup))]
namespace _1351300203
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
