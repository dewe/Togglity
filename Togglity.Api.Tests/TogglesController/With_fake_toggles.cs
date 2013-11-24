using System.Collections.Generic;
using FakeItEasy;
using NUnit.Framework;
using Togglity.Api.Models;
using Togglity.Api.Services;

namespace Togglity.Api.Tests.Webhook
{
    public abstract class With_fake_toggles
    {
        protected IDictionary<string, bool> TogglesDictionary;
        protected ITogglesServer TogglesServer;
        public ITogglesAdmin TogglesAdmin;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Given();
            When();
        }

        private void Initialize()
        {
            TogglesAdmin = A.Fake<ITogglesAdmin>();
            TogglesServer = A.Fake<ITogglesServer>();
            TogglesDictionary = A.Fake<IDictionary<string, bool>>();
            A.CallTo(() => TogglesServer.GetToggles()).Returns(TogglesDictionary);
        }

        public virtual void Given()
        {
        }

        public virtual void When()
        {
        }
    }
}