using System.Collections.Generic;
using Togglity.Api.Models;

namespace Togglity.Api.Tests
{
    public class FakeToggles : Toggles
    {
        public IDictionary<string, bool> InternalToggles
        {
            get { return _toggles; }
            set { _toggles = value; }
        }
    }
}