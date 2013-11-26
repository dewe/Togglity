using System.Collections.Generic;
using System.Net;
using FakeItEasy;
using NUnit.Framework;
using Shouldly;
using Togglity.Api.Models;
using Togglity.Api.Services;

namespace Togglity.Api.Tests.TogglesController
{
    [TestFixture]
    public class When_posting_to_webhook : With_fake_toggles
    {
        private Controllers.TogglesController _togglesController;
        private ITogglesService _service;
        private ITogglesAdmin _toggles;

        public override void Given()
        {
            _service = GetAMockedMockTogglesServer();
            _toggles = A.Fake<ITogglesAdmin>();
            _togglesController = new Controllers.TogglesController(_service, _toggles);
        }

        public override void When()
        {
            _togglesController.WebHook("anystring");
        }

        [Test]
        public void It_should_get_toggles_from_server()
        {
            A.CallTo(() => _service.GetToggles()).MustHaveHappened();
        }

        [Test]
        public void It_should_update_toggles()
        {
            A.CallTo(() => _toggles.SetAllToggles(A<IDictionary<string, bool>>.Ignored)).MustHaveHappened();
        }

        [Test]
        public void It_should_return_status_ok()
        {
            _togglesController.WebHook("anystring")
                .StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }
}
