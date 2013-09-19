using Nancy;
using Nancy.Testing;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ToggleModuleSpecs
    {
        private DefaultNancyBootstrapper _bootstrapper;
        private Browser _browser;

        [SetUp]
        public void Setup()
        {
            _bootstrapper = new DefaultNancyBootstrapper();
            _browser = new Browser(_bootstrapper);
        }

        [Test]
        public void Should_return_status_ok_when_route_exists()
        {
            var result = _browser.Get("/", with => with.HttpRequest());

            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }

        [Test]
        public void Should_return_json()
        {
            var result = _browser.Get("/", with => with.HttpRequest());

            Assert.AreEqual("application/json; charset=utf-8", result.ContentType);
        }

    }
}
