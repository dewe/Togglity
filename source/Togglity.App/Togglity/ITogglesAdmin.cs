using System.Collections.Generic;

namespace Togglity.App.Togglity
{
    public interface ITogglesAdmin
    {
        void SetAllToggles(IDictionary<string, bool> toggleDictionary);
    }
}