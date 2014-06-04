using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TinDo.Web.Startup))]
namespace TinDo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
