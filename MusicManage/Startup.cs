using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicManage.Startup))]
namespace MusicManage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
