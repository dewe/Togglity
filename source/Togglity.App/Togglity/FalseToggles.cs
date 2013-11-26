namespace Togglity.App.Togglity
{
    public class FalseToggles : IToggles
    {
        public bool GetToggle(string name)
        {
            return false;
        }
    }
}