using System.Collections.Generic;

namespace Togglity.App.Services
{
    public interface ITogglesService
    {
        IDictionary<string, bool> GetToggles();
    }
}