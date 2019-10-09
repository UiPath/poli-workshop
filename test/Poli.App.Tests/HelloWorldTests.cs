using Xunit;
using Poli.App.Core;

namespace Poli.App.Tests
{
    public class HelloWorldTests
    {
        [Fact]
        public void ShouldSayHelloIfNameIsNotNullOrEmpty()
        {
            var helloWorld = new HelloWorld();

            var name = "test";
            var message = helloWorld.GetMessage(name);

            Assert.Equal(message, $"Hello {name}");
        }

        [Fact]
        public void ShouldSayHelloIfNameIsNull()
        {
            var helloWorld = new HelloWorld();

            string name = null;
            var message = helloWorld.GetMessage(name);

            Assert.Equal(message, $"Hello");
        }

        [Fact]
        public void ShouldSayHelloIfNameIsEmpty()
        {
            var helloWorld = new HelloWorld();

            var name = string.Empty;
            var message = helloWorld.GetMessage(name);

            Assert.Equal(message, $"Hello");
        }
    }
}
