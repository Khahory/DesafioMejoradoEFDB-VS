using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DesafioMejoradoEFDB.Startup))]
namespace DesafioMejoradoEFDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
