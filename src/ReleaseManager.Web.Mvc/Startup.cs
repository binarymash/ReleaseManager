using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReleaseManager.Web.Mvc.Startup))]
namespace ReleaseManager.Web.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
