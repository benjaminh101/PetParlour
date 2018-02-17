using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Petparlour.Startup))]
namespace Petparlour
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
