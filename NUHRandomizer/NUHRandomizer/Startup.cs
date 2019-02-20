using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NUHRandomizer.Startup))]
namespace NUHRandomizer
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
