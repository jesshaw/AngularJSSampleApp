using System.Text;
using AngularJSWebApp1.ServiceModel;
using MovielApp.ServiceInterface;
using NUnit.Framework;
using ServiceStack;
using ServiceStack.Testing;

namespace MovielApp.Tests
{
    [TestFixture]
    public class UnitTests
    {
        private readonly ServiceStackHost appHost;

        public UnitTests()
        {
            appHost = new BasicAppHost(typeof (MyService).Assembly)
            {
                ConfigureContainer = container =>
                {
                    //Add your IoC dependencies here
                }
            }
                .Init();
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            appHost.Dispose();
        }

        [Test]
        public void TestMethod1()
        {
            var service = appHost.Container.Resolve<MyService>();

            var response = (HelloResponse) service.Any(new Hello {Name = "World"});

            Assert.That(response.Result, Is.EqualTo("Hello, World!"));
        }


        [Test]
        public void TestMethod2()
        {
            var sb = new StringBuilder(10);
            sb.Append("1234567890");
            sb.Append("abc");

            Assert.That(sb.ToString(), Is.EqualTo("1234567890abc"));
        }
    }
}