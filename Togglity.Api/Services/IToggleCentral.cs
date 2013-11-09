using System.Collections.Generic;

namespace Togglity.Api.Services
{
    public interface IToggleCentral
    {
        IDictionary<string, bool> GetToggles();
    }
}