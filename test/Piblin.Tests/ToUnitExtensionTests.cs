using Moq;
using NUnit.Framework;
using Piblin.Extensions;

namespace Piblin.Tests
{
    [TestFixture]
    public class ToUnitExtensionTests
    {
        [Test]
        public void ShouldTerminateWithAUnit()
        {
            var input = new Mock<IPipe<string, int>>();
            var sut = input.Object.ToUnit();
            
            var result = sut.Execute("1");

            input.Verify(i => i.Execute("1"));
            Assert.AreEqual(Unit.Instance, result);
        }
    }
}