using NUnit.Framework;

namespace Piblin.Tests
{
    [TestFixture]
    public class EchoPipeTests
    {
        [Test]
        public void ShouldRepeatInputAsOutput()
        {
            var sut = new EchoPipe<string>();
            var result = sut.Execute("one");
            Assert.AreEqual("one", result);
        }
    }
}