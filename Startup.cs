using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EfDbfMvcProject.Startup))]
namespace EfDbfMvcProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
