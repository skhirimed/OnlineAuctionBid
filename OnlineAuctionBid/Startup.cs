using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineAuctionBid.Startup))]
namespace OnlineAuctionBid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
