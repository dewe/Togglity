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
        private Toggles _toggles = new Toggles();

        [SetUp]
        public void When()
        {
            _toggles.Set(new Dictionary<string, bool>
            {
                { "newtoggle", true },
                { "otherToggle", false }
            });
        }

        [Test]
        public void New_toggles_should_be_available()
        {
            _toggles["newtoggle"].ShouldBe(true);
            _toggles["otherToggle"].ShouldBe(false);
        }
    }
}
