using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasicApplication.Startup))]
namespace BasicApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
