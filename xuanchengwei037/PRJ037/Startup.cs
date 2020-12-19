using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRJ037.Startup))]
namespace PRJ037
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
