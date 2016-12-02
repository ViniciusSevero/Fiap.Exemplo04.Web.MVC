using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fiap.Exemplo04.Web.MVC.Startup))]
namespace Fiap.Exemplo04.Web.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
