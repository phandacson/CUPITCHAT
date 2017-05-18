using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CUPITCHAT.Startup))]
namespace CUPITCHAT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
