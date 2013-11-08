using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;
using NUnit.Framework;
using Shouldly;
using Togglity.Api.Controllers;
using Togglity.Api;
using Togglity.Api.Services;

namespace Togglity.Api.Tests
{
    [TestFixture]
    public class When_posting_to_webhook
    {
        private ITogglesService _togglesService = A.Fake<ITogglesService>();

        [Test]
        public void It_should_get_toggles_from_server()
        {
            var togglesController = new TogglesController(_togglesService);

            togglesController.WebHook("anystring");

            A.CallTo(() => _togglesService.GetToggles()).MustHaveHappened();
        }

        [Test]
        public void It_should_return_status_ok()
        {
            var togglesController = new TogglesController(_togglesService);

            var result = togglesController.WebHook("anystring");

            result.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }
}
