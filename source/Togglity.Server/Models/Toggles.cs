using System.Collections;
using System.Collections.Generic;

namespace Togglity.Server.Models
{
    public class Toggles : IEnumerable<Feature>
    {
        private readonly List<Feature> _features = new List<Feature>();  

        public IEnumerator<Feature> GetEnumerator()
        {
            return _features.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Feature feature)
        {
            _features.Add(feature);
        }
    }
}