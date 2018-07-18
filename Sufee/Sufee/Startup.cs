using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sufee.Startup))]
namespace Sufee
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
