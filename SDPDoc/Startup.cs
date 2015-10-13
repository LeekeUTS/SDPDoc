using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SDPDoc.Startup))]
namespace SDPDoc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
