using System.Collections.Generic;

namespace Togglity.Api.Models
{
    public interface IToggles
    {
        void Set(IDictionary<string, bool> toggleDictionary);
    }
}