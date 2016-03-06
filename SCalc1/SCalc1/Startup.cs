using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SCalc1.Startup))]
namespace SCalc1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
