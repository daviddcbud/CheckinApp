using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CheckInApp.Startup))]
namespace CheckInApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
