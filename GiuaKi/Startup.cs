using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GiuaKi.Startup))]
namespace GiuaKi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
