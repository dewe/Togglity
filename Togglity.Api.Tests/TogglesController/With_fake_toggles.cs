using System.Collections.Generic;
using FakeItEasy;
using NUnit.Framework;
using Togglity.Api.Services;

namespace Togglity.Api.Tests.TogglesController
{
    public abstract class With_fake_toggles
    {
        [SetUp]
        public void Setup()
        {
            Given();
            When();
        }

        public ITogglesService GetAMockedMockTogglesServer()
        {
            var togglesServer = A.Fake<ITogglesService>();
            A.CallTo(() => togglesServer.GetToggles())
                .Returns(A.Fake<IDictionary<string, bool>>());
            return togglesServer;
        }

        public virtual void Given()
        {
        }

        public virtual void When()
        {
        }
    }
}