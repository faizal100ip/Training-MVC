using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Training.MVC.Startup))]
namespace Training.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
