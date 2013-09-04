using Owin;

namespace easySolutions.easyFestival.WebFrontend
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
