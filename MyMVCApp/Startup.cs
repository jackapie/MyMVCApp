using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVCApp.Startup))]
namespace MyMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
