using System.Collections.Generic;

namespace Togglity.Api.Services
{
    public interface ITogglesServer
    {
        IDictionary<string, bool> GetToggles();
    }
}