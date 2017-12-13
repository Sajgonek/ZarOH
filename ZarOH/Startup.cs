using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZarOH.Startup))]
namespace ZarOH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
