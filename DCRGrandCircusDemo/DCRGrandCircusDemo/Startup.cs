using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DCRGrandCircusDemo.Startup))]
namespace DCRGrandCircusDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
