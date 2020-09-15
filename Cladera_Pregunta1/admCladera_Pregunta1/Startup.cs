using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(admCladera_Pregunta1.Startup))]
namespace admCladera_Pregunta1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
