using System;
using Xunit;

namespace Google.Showcase.V1Beta1.IntegrationTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var client = new Google.Showcase.V1Beta1.EchoClientBuilder().Build();
            var response = client.Echo(new EchoRequest { Content = "Foo"});
            Assert.Equal("Foo", response.Content);
        }
    }
}
