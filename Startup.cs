using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamenEncuestasDevel.Startup))]
namespace ExamenEncuestasDevel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
