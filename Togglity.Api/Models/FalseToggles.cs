using System.Collections.Generic;

namespace Togglity.Api.Models
{
    public class FalseToggles : IToggles
    {
        public bool GetToggle(string name)
        {
            return false;
        }
    }
}