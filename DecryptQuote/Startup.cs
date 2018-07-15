using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DecryptQuote.Startup))]
namespace DecryptQuote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
