using System.Net;
using FakeItEasy;
using NUnit.Framework;
using Shouldly;
using Togglity.Api.Tests.Webhook;

namespace Togglity.Api.Tests.TogglesController
{
    [TestFixture]
    public class When_posting_to_webhook : With_fake_toggles
    {
        private Controllers.TogglesController _togglesController;

        public override void Given()
        {
            _togglesController = new Controllers.TogglesController(TogglesServer, TogglesAdmin);
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
            A.CallTo(() => TogglesAdmin.SetAllToggles(TogglesDictionary)).MustHaveHappened();
        }

        [Test]
        public void It_should_return_status_ok()
        {
            _togglesController.WebHook("anystring")
                .StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }
}
