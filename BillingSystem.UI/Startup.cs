using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BillingSystem.UI.Startup))]
namespace BillingSystem.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
