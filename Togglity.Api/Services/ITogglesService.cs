using System.Collections.Generic;

namespace Togglity.Api.Services
{
    public interface ITogglesService
    {
        IDictionary<string, bool> GetToggles();
    }
}