using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnCICD.Startup))]
namespace LearnCICD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
