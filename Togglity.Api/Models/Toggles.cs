using System.Linq;
using System.Web;

namespace Togglity.Api.Models
{
    public static class Toggles
    {
        private static IToggles _toggles;

        static Toggles()
        {
            _toggles = new FalseToggles();
        }

        public static void SetInstance(IToggles toggles)
        {
            // Threadsafe: reference assignment/reading is guaranteed to be atomic.
            _toggles = toggles; 
        }

        public static bool IsEnabled(string toggleName)
        {
            return _toggles.GetToggle(toggleName);
        }
    }
}