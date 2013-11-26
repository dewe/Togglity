using System.Collections.Generic;
using NUnit.Framework;
using Shouldly;
using Togglity.App.Togglity;

namespace Togglity.App.Tests
{
    [TestFixture]
    public class When_setting_static_toggle_instance
    {
        [TestCase("toggleA")]
        [TestCase("toggleB")]
        [TestCase("toggleC")]
        public void New_toggles_should_be_available(string toggleName)
        {
            var instance = new ServerToggles(new Dictionary<string, bool>
            {
                {toggleName, true},
                {"otherToggle", true}
            });

            Toggles.SetInstance(instance);

            Toggles.IsEnabled(toggleName).ShouldBe(true);
        }
    }
}