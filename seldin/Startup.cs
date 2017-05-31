using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(seldin.Startup))]
namespace seldin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
