using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(review.Startup))]
namespace review
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
