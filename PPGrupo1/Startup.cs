using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PPGrupo1.StartupOwin))]

namespace PPGrupo1
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
