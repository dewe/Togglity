using System.Collections.Generic;

namespace Togglity.Api.Models
{
    public interface ITogglesAdmin
    {
        void SetAllToggles(IDictionary<string, bool> toggleDictionary);
    }
}