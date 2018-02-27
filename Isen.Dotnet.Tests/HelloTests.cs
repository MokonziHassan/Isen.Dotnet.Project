using System;
using Xunit;
using Isen.Dotnet.Library;

namespace Isen.Dotnet.Tests
{
    public class HelloTests
    {
        [Fact]
        public void World()
        {
            var result = Hello.World;
            var expected = "Hello, World";
            Assert.True(result == expected);
        }
        [Fact]
        public void Greet()
        {
            var result = Hello.greet("Hassan");
            Assert.StartsWith("Hello Hassan, it is", result);
        }

        public void GreetUpper()
        {
            var result = Hello.GreetUpper("Hassan");
            Assert.StartsWith("Hello Hassan, it is", result);
        }
    }
}
