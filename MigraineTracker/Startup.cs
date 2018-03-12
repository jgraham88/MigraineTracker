using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MigraineTracker.Startup))]
namespace MigraineTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
