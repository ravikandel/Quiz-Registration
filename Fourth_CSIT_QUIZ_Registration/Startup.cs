using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fourth_CSIT_QUIZ_Registration.Startup))]
namespace Fourth_CSIT_QUIZ_Registration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
