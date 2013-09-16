using Nancy;
using Nancy.Testing;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ToggleModuleSpecs
    {
        [Test]
        public void Should_return_status_ok_when_route_exists()
        {
            // Given
            var bootstrapper = new DefaultNancyBootstrapper();
            var browser = new Browser(bootstrapper);

            // When
            var result = browser.Get("/", with =>
            {
                with.HttpRequest();
            });

            // Then
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }
    }
}
