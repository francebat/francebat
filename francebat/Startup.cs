using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(francebat.Startup))]
namespace francebat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
