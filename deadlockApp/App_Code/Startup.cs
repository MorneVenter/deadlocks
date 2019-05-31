using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(deadlockApp.Startup))]
namespace deadlockApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
