using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConstructionSystem.Web.Startup))]
namespace ConstructionSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
