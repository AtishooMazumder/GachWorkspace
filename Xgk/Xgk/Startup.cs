using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Xgk.Startup))]
namespace Xgk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
