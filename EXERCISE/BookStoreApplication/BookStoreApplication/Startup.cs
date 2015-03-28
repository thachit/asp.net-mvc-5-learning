using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookStoreApplication.Startup))]
namespace BookStoreApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
