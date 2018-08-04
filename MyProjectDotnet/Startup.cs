using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyProjectDotnet.Startup))]
namespace MyProjectDotnet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
