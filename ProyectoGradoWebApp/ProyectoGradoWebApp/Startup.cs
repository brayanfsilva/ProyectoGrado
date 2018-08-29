using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoGradoWebApp.Startup))]
namespace ProyectoGradoWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
