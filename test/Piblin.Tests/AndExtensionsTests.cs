using Moq;
using NUnit.Framework;
using Piblin.Extensions;

namespace Piblin.Tests
{
    [TestFixture]
    public class AndExtensionsTests
    {
        [Test]
        public void ShouldPassOneInputIntoTwoPipes()
        {
            var subject1 = new Mock<IPipe<string, int>>();
            var subject2 = new Mock<IPipe<string, int>>();

            subject1.Setup(x => x.Execute("input")).Returns(1);
            subject2.Setup(x => x.Execute("input")).Returns(2);

            var composite = subject1.Object.And(subject2.Object);

            var result = composite.Execute("input");

            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(2, result.Item2);
        }
    }
}