using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyProyectNet.Startup))]
namespace MyProyectNet
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
