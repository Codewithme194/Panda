using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PandaBook.Startup))]
namespace PandaBook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
