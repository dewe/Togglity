using FakeItEasy;
using NUnit.Framework;
using Togglity.App.Togglity;

namespace Togglity.App.Tests
{
    [TestFixture]
    public class When_calling_static_toggle : Specification
    {
        private IToggles _toggles;

        public override void Given()
        {
            _toggles = FakeToggles.MockToggles();
            Toggles.SetInstance(_toggles);
        }

        public override void When()
        {
            Toggles.IsEnabled("anything");
        }

        [Test]
        public void It_should_use_the_internal_toggle_instance()
        {
            A.CallTo(() => _toggles.GetToggle("anything")).MustHaveHappened();
        }
    }
}