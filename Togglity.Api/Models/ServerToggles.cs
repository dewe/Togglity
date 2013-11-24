using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Togglity.Api.Models
{
    public class ServerToggles : IToggles, ITogglesAdmin
    {
        private IDictionary<string, bool> _toggles;

        public ServerToggles()
        {
            _toggles = new Dictionary<string, bool>();
        }

        public ServerToggles(IDictionary<string,bool> toggles )
        {
            SetAllToggles(toggles);
        }

        public void SetAllToggles(IDictionary<string, bool> toggleDictionary)
        {
            _toggles = toggleDictionary;
        }

        public bool GetToggle(string name)
        {
            return _toggles[name];
        }
    }

    
}