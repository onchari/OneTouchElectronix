using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneTouchElectronix.Startup))]
namespace OneTouchElectronix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
