using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollegeWebsite.Startup))]
namespace CollegeWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
