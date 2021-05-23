using Microsoft.DotNet.InternalAbstractions;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture(Platform.)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}