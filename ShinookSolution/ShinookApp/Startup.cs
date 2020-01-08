using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShinookApp.Startup))]
namespace ShinookApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
