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
using Togglity.Api.Models;
using Togglity.Api.Services;

namespace Togglity.Api.Tests
{
    [TestFixture]
    public class When_posting_to_webhook
    {
        private Dictionary<string, bool> _toggleDictionary;
        private IToggleCentral _toggleCentral;
        private IToggleAdmin _toggles;

        [SetUp]
        public void SetUp()
        {
            _toggleDictionary = new Dictionary<string, bool>();
            _toggleCentral = A.Fake<IToggleCentral>();
            _toggles = A.Fake<IToggleAdmin>();

            A.CallTo(() => _toggleCentral.GetToggles()).Returns(_toggleDictionary);
        }

        [Test]
        public void It_should_get_toggles_from_server()
        {
            var togglesController = new TogglesController(_toggleCentral, _toggles);

            togglesController.WebHook("anystring");

            A.CallTo(() => _toggleCentral.GetToggles()).MustHaveHappened();
        }

        [Test]
        public void It_should_update_toggles()
        {
            var togglesController = new TogglesController(_toggleCentral, _toggles);

            togglesController.WebHook("anystring");

            A.CallTo(() => _toggles.Set(_toggleDictionary)).MustHaveHappened();
        }

        [Test]
        public void It_should_return_status_ok()
        {
            var togglesController = new TogglesController(_toggleCentral, _toggles);

            var result = togglesController.WebHook("anystring");

            result.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }
}
