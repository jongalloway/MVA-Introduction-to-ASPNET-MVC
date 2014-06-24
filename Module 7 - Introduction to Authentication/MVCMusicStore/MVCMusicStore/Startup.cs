using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMusicStore.Startup))]
namespace MVCMusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
