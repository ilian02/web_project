using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(soon_to_be_named.Startup))]
namespace soon_to_be_named
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
