using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VeganRecipe.Startup))]
namespace VeganRecipe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
