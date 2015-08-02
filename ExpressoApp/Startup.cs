using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExpressoApp.Startup))]
namespace ExpressoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
