using Moq;
using NUnit.Framework;
using Piblin.Extensions;

namespace Piblin.Tests
{
    [TestFixture]
    public class WithLoggingExtensionsTests
    {
        [Test]
        public void ShouldCallLoggingDelegateOnceAfterPipeHasBeenExecuted()
        {
            var callbackCount = 0;
            var pipeMock = new Mock<IPipe<Unit, Unit>>();
            var pipe = pipeMock.Object;
            var loggedPipe = pipe.WithLogging(s => callbackCount++);

            Assert.AreEqual(0, callbackCount);

            loggedPipe.Execute(Unit.Instance);

            Assert.AreEqual(1, callbackCount);
        }
    }
}