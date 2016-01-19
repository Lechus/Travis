using NUnit.Framework;

namespace Travis.Tests
{
    [TestFixture]
    public class SeriveTests
    {
        protected IService Sut { get; set; }

        [TestFixtureSetUp]
        public void Init()
        {
            Sut = new Service();
        }

        [Test]
        public void ThenResultReturnName()
        {
            var name = Sut.DoSomething();

            Assert.That(name, Is.EqualTo("Leszek"));
        }
    }
}