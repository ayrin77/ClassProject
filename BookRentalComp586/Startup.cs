using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookRentalComp586.Startup))]
namespace BookRentalComp586
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
