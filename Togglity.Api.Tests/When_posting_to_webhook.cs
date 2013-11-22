using FakeItEasy;
using NUnit.Framework;
using Shouldly;
using System.Net;
using Togglity.Api.Controllers;
using Togglity.Api.Tests.Context;

namespace Togglity.Api.Tests
{
    [TestFixture]
    public class When_posting_to_webhook : With_fake_toggles
    {
        private TogglesController _togglesController;

        public override void Given()
        {
            _togglesController = new TogglesController(TogglesServer, Toggles);
        }

        public override void When()
        {
            _togglesController.WebHook("anystring");
        }

        [Test]
        public void It_should_get_toggles_from_server()
        {
            A.CallTo(() => TogglesServer.GetToggles()).MustHaveHappened();
        }

        [Test]
        public void It_should_update_toggles()
        {
            A.CallTo(() => Toggles.Set(TogglesDictionary)).MustHaveHappened();
        }

        [Test]
        public void It_should_return_status_ok()
        {
            _togglesController.WebHook("anystring")
                .StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }
}
