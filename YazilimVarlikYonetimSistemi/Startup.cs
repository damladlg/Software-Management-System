using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YazilimVarlikYonetimSistem.Startup))]
namespace YazilimVarlikYonetimSistem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
