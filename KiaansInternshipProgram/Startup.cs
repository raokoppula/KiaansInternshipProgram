using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KiaansInternshipProgram.Startup))]
namespace KiaansInternshipProgram
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
