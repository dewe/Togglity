using System.Collections.Generic;
using System.Net;
using FakeItEasy;
using NUnit.Framework;
using Shouldly;
using Togglity.App.Controllers;
using Togglity.App.Services;
using Togglity.App.Togglity;

namespace Togglity.App.Tests
{
    [TestFixture]
    public class When_posting_to_webhook : Specification
    {
        private WebHookController _webHookController;
        private ITogglesAdmin _togglesAdmin;
        private ITogglesService _mockService;

        public override void Given()
        {
            _mockService = FakeToggles.MockTogglesService();
            _togglesAdmin = FakeToggles.MockToggles() as ITogglesAdmin;
            _webHookController = new WebHookController(_mockService, _togglesAdmin);
        }

        public override void When()
        {
            _webHookController.WebHook("anystring");
        }

        [Test]
        public void It_should_get_toggles_from_server()
        {
            A.CallTo(() => _mockService.GetToggles()).MustHaveHappened();
        }

        [Test]
        public void It_should_set_toggles_instance()
        {
            A.CallTo(() => _togglesAdmin.SetAllToggles(A<IDictionary<string, bool>>.Ignored)).MustHaveHappened();
        }

        [Test]
        public void It_should_return_status_ok()
        {
            _webHookController.WebHook("anystring")
                .StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }
}
