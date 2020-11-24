using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_3.Startup))]
namespace _3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
