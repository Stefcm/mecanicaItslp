using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mecanicaItslp.Startup))]
namespace mecanicaItslp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
