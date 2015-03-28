using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcMusicStore.Startup))]
namespace mvcMusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
