using FakeItEasy;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using Togglity.Api.Models;

namespace Togglity.Api.Tests
{
    [TestFixture]
    public class When_updating_toggles
    {
        private IDictionary<string, bool> _newToggleDictionary;
        private Toggles _toggles;

        [SetUp]
        public void Given()
        {
            _toggles = new Toggles(A.Fake<IDictionary<string, bool>>());
            _newToggleDictionary = new Dictionary<string, bool>
            {
                { "newtoggle", true }
            };

            When();
        }

        public void When()
        {
            _toggles.Set(_newToggleDictionary);
        }

        [Test]
        public void New_toggles_should_be_available()
        {
            _toggles.GetToggle("newtoggle").ShouldBe(true);
        }

        [Test]
        public void It_should_throw_if_updating_with_null()
        {
            Assert.Throws<ArgumentNullException>(
                () => _toggles.Set(null));
        }
        }
}
