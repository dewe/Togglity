using System.Collections;
using System.Collections.Generic;

namespace Togglity.Api.Models
{
    public interface IToggleAdmin
    {
        void Set(IDictionary<string,bool> newToggles);
    }
}