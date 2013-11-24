using System.Collections.Generic;
using NUnit.Framework;
using Shouldly;
using Togglity.Api.Models;

namespace Togglity.Api.Tests.Toggles
{
    [TestFixture]
    public class When_updating_toggles
    {
        private ServerToggles _toggles = new ServerToggles();

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
