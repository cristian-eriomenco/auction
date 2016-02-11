using Microsoft.Owin.Testing;
using TechTalk.SpecFlow;

namespace Auctionata.Tests
{
    public static class FeatureContextExtensions
    {
        private const string KeyServer = "server";

        public static TestServer TestServer(this FeatureContext source)
        {
            return source.Get<TestServer>(KeyServer);
        }

        public static void TestServer(this FeatureContext source, TestServer server)
        {
            source.Add(KeyServer, server);
        }
    }
}
