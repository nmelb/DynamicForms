using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DynamicForms.Startup))]
namespace DynamicForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
