using System.Collections.Generic;
using FakeItEasy;
using NUnit.Framework;
using Togglity.Api.Models;
using Togglity.Api.Services;

namespace Togglity.Api.Tests.Context
{
    public abstract class With_fake_toggles
    {
        protected IDictionary<string, bool> TogglesDictionary;
        protected ITogglesServer TogglesServer;
        public IToggles Toggles;

        [SetUp]
        public void Setup()
        {
            Initialize();
            Given();
            When();
        }

        private void Initialize()
        {
            Toggles = A.Fake<IToggles>();
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