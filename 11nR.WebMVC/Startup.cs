using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_11nR.WebMVC.Startup))]
namespace _11nR.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
