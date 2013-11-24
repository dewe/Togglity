using System.Collections.Generic;
using NUnit.Framework;
using Shouldly;
using Togglity.Api.Models;

namespace Togglity.Api.Tests.ToggleApi
{
    [TestFixture]
    public class When_creating_new_toggles
    {
        private ServerToggles _toggles;

        [SetUp]
        public void When()
        {
            _toggles = new ServerToggles(new Dictionary<string, bool>
            {
                {"newtoggle", true}
            });
        }

        [Test]
        public void New_toggle_should_be_available()
        {
            _toggles.GetToggle("newtoggle").ShouldBe(true);
        }
    }
}