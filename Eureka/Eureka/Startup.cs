using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eureka.Startup))]
namespace Eureka
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
