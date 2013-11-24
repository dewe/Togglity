using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Togglity.Api.Models
{
    public class ServerToggles : IToggles
    {
        private IDictionary<string, bool> _toggles;

        public ServerToggles()
        {
            _toggles = new Dictionary<string, bool>();
        }

        public ServerToggles(IDictionary<string,bool> toggles )
        {
            Set(toggles);
        }

        public void Set(IDictionary<string, bool> toggleDictionary)
        {
            _toggles = toggleDictionary;
        }

        public bool this[string name]
        {
            get { return _toggles[name]; }
        }
    }

    
}