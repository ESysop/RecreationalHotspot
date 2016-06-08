using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RecreationalHotspots.Startup))]
namespace RecreationalHotspots
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
