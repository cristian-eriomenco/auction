using Auctionata.Api;
using Microsoft.Owin.Testing;
using TechTalk.SpecFlow;

namespace Auctionata.Tests
{
    [Binding]
    public class WebServer
    {
        [BeforeFeature]
        public void CreateServer()
        {
            FeatureContext.Current.TestServer(TestServer.Create<Startup>());
        }

        [AfterFeature]
        public void StopServer()
        {
            var server = FeatureContext.Current.TestServer();
            server.Dispose();
        }
    }
}
