using System;
using Moq;
using NUnit.Framework;
using Piblin.Extensions;

namespace Piblin.Tests
{
    [TestFixture]
    public class SplitExtensionsTests
    {
        [Test]
        public void ShouldSendEachPartOfTwoTupleToTwoDifferentPipes()
        {
            var sender = new Mock<IPipe<Unit, Tuple<A, B>>>();

            sender.Setup(x => x.Execute(Unit.Instance)).Returns(new Tuple<A, B>(new A(), new B()));

            var receiverA = new Mock<IPipe<A, Unit>>();
            var receiverB = new Mock<IPipe<B, Unit>>();

            receiverA.Setup(x => x.Execute(It.IsAny<A>())).Returns(Unit.Instance);
            receiverB.Setup(x => x.Execute(It.IsAny<B>())).Returns(Unit.Instance);

            var pipeline = sender.Object.SplitInto(receiverA.Object, receiverB.Object);

            pipeline.Execute(Unit.Instance);

            receiverA.Verify(r => r.Execute(It.IsAny<A>()));
            receiverB.Verify(r => r.Execute(It.IsAny<B>()));
        }
    }
}