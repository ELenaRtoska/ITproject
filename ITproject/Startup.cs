using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITproject.Startup))]
namespace ITproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
