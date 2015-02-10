using System;
using Moq;
using NUnit.Framework;
using Piblin.Extensions;

namespace Piblin.Tests
{
    [TestFixture]
    public class ThenExtensionsTests
    {
        [Test]
        public void ShouldUseOutputFromLeftPipeAsInputToRightPipe()
        {
            var left = new Mock<IPipe<string, int>>();
            var right = new Mock<IPipe<int, bool>>();

            left.Setup(x => x.Execute("1")).Returns(1);

            var sut = left.Object.Then(right.Object);

            sut.Execute("1");

            right.Verify(x => x.Execute(1));
        }

        [Test]
        public void ShouldFeedTwoInputsIntoOnePipe2()
        {
            var left = new Mock<IPipe<string, Tuple<string, int>>>();
            var right = new Mock<IPipe<string, int, bool>>();

            left.Setup(x => x.Execute("1")).Returns(new Tuple<string, int>("1", 2));

            var sut = left.Object.Then(right.Object);

            sut.Execute("1");

            right.Verify(x => x.Execute("1", 2));
        }

        [Test]
        public void ShouldFeedThreeInputsIntoOnePipe()
        {
            var left = new Mock<IPipe<string, Tuple<A, B, C>>>();
            var right = new Mock<IPipe<A, B, C, D>>();

            left.Setup(x => x.Execute("1")).Returns(new Tuple<A, B, C>(new A(), new B(), new C()));

            var sut = left.Object.Then(right.Object);

            sut.Execute("1");

            right.Verify(x => x.Execute(It.IsAny<A>(), It.IsAny<B>(), It.IsAny<C>()));
        }

        [Test]
        public void ShouldFeedFourInputsIntoOnePipe()
        {
            var left = new Mock<IPipe<string, Tuple<A, B, C, D>>>();
            var right = new Mock<IPipe<A, B, C, D, E>>();

            left.Setup(x => x.Execute("1")).Returns(new Tuple<A, B, C, D>(new A(), new B(), new C(), new D()));

            var sut = left.Object.Then(right.Object);

            sut.Execute("1");

            right.Verify(x => x.Execute(It.IsAny<A>(), It.IsAny<B>(), It.IsAny<C>(), It.IsAny<D>()));
        }

        [Test]
        public void ShouldFeedFiveInputsIntoOnePipe()
        {
            var left = new Mock<IPipe<string, Tuple<A, B, C, D, E>>>();
            var right = new Mock<IPipe<A, B, C, D, E, F>>();

            left.Setup(x => x.Execute("1")).Returns(new Tuple<A, B, C, D, E>(new A(), new B(), new C(), new D(), new E()));

            var sut = left.Object.Then(right.Object);

            sut.Execute("1");

            right.Verify(x => x.Execute(It.IsAny<A>(), It.IsAny<B>(), It.IsAny<C>(), It.IsAny<D>(), new E()));
        }
    }
}