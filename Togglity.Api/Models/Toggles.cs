using System;
using System.Collections.Generic;

namespace Togglity.Api.Models
{
    public class Toggles : IToggles
    {
        protected IDictionary<string, bool> _toggles; 

        public void Set(IDictionary<string, bool> toggleDictionary)
        {
            if (toggleDictionary == null) throw new ArgumentNullException("toggleDictionary");
            _toggles = toggleDictionary;
        }
    }
}