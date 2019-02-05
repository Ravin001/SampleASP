using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleASP.Startup))]
namespace SampleASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
