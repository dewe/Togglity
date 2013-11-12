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
    public class When_updating_toggles
    {
        private Dictionary<string, bool> _toggleDictionary;
        private FakeToggles _toggles;

        [SetUp]
        public void SetUp()
        {
            _toggles = new FakeToggles { InternalToggles = A.Dummy<IDictionary<string, bool>>() };
        }

        [Test]
        public void It_should_replace_all_toggles()
        {
            var newToggles = new Dictionary<string, bool> { { "newtoggle", true } };

            _toggles.Set(newToggles);

            _toggles.InternalToggles.ShouldBeSameAs(newToggles);
        }

        [Test]
        public void It_should_throw_on_null_toggles()
        {
            Assert.Throws<ArgumentNullException>(
                () => _toggles.Set(null));
        }

    }

    public class FakeToggles : Toggles
    {
        public IDictionary<string, bool> InternalToggles
        {
            get { return _toggles; }
            set { _toggles = value; }
        }
    }
}
