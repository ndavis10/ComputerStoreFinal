using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComputerStoreFinal.Startup))]
namespace ComputerStoreFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
