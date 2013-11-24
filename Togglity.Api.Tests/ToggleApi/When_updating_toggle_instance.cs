using System.Collections.Generic;
using NUnit.Framework;
using Shouldly;
using Togglity.Api.Models;

namespace Togglity.Api.Tests.ToggleApi
{
    [TestFixture]
    public class When_updating_toggle_instance
    {
        private ServerToggles _toggles = new ServerToggles(new Dictionary<string, bool> {{"happy", true}});

        [SetUp]
        public void When()
        {
            Toggles.SetInstance(_toggles);
        }

        [Test]
        public void New_toggle_should_be_available()
        {
            Toggles.IsEnabled("happy").ShouldBe(true);
        }
    }
}