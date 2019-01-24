using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebEFTest0806.Startup))]
namespace WebEFTest0806
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
