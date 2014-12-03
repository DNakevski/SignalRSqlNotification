using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRScaleOutNotifications.Startup))]
namespace SignalRScaleOutNotifications
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
