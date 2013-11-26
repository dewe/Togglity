using System.Collections.Generic;
using FakeItEasy;
using Togglity.App.Services;
using Togglity.App.Togglity;

namespace Togglity.App.Tests
{
    public static class FakeToggles
    {
        public static ITogglesService MockTogglesService()
        {
            var togglesServer = A.Fake<ITogglesService>();
            A.CallTo(() => togglesServer.GetToggles())
                .Returns(A.Fake<IDictionary<string, bool>>());
            return togglesServer;
        }

        public static IToggles MockToggles()
        {
            return A.Fake<IToggles>(x => x.Implements(typeof (ITogglesAdmin)));
        }
    }
}