using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jcool_University.Startup))]
namespace Jcool_University
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
