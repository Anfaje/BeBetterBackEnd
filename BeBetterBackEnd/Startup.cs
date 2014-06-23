using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeBetterBackEnd.Startup))]
namespace BeBetterBackEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
