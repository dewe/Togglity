using NUnit.Framework;

namespace Togglity.App.Tests
{
    public abstract class Specification
    {
        [SetUp]
        public void Setup()
        {
            Given();
            When();
        }

        public virtual void Given()
        {
        }

        public virtual void When()
        {
        }
    }
}