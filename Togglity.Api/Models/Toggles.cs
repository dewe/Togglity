using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Togglity.Api.Models
{
    public class Toggles : IToggles
    {
        private IDictionary<string, bool> _toggles;

        public Toggles()
        {
            _toggles = new Dictionary<string, bool>();
        }

        public Toggles(IDictionary<string,bool> toggles )
        {
            Set(toggles);
        }

        public void Set(IDictionary<string, bool> toggleDictionary)
        {
            if (toggleDictionary == null) throw new ArgumentNullException("toggleDictionary");
            _toggles = toggleDictionary;
        }

        public bool GetToggle(string name)
        {
            return _toggles[name];
        }
    }

    
}