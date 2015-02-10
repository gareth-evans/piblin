using System;
using Moq;
using NUnit.Framework;
using Piblin.Extensions;

namespace Piblin.Tests
{
    [TestFixture]
    public class CombineExtensionsTests
    {
        [Test]
        public void ShouldFeedTwoInputsIntoOnePipe()
        {
            var pipe1 = new Mock<IPipe<string, int>>();
            var pipe2 = new Mock<IPipe<string, int>>();

            pipe1.Setup(x => x.Execute("1")).Returns(1);
            pipe2.Setup(x => x.Execute("2")).Returns(2);

            var composite = pipe1.Object.Combine(pipe2.Object);

            var result = composite.Execute("1", "2");

            Assert.AreEqual(new Tuple<int,int>(1,2), result);
        }

        [Test]
        public void ShouldFeedThreeInputsIntoOnePipe()
        {
            var pipe1 = new Mock<IPipe<string, int>>();
            var pipe2 = new Mock<IPipe<string, int>>();
            var pipe3 = new Mock<IPipe<string, int>>();

            pipe1.Setup(x => x.Execute("1")).Returns(1);
            pipe2.Setup(x => x.Execute("2")).Returns(2);
            pipe3.Setup(x => x.Execute("3")).Returns(3);

            var composite = pipe1.Object.Combine(pipe2.Object, pipe3.Object);

            var result = composite.Execute("1", "2", "3");

            Assert.AreEqual(new Tuple<int, int, int>(1, 2, 3), result);
        }

        [Test]
        public void ShouldFeedFourInputsIntoOnePipe()
        {
            var pipe1 = new Mock<IPipe<string, int>>();
            var pipe2 = new Mock<IPipe<string, int>>();
            var pipe3 = new Mock<IPipe<string, int>>();
            var pipe4 = new Mock<IPipe<string, int>>();

            pipe1.Setup(x => x.Execute("1")).Returns(1);
            pipe2.Setup(x => x.Execute("2")).Returns(2);
            pipe3.Setup(x => x.Execute("3")).Returns(3);
            pipe4.Setup(x => x.Execute("4")).Returns(4);

            var composite = pipe1.Object.Combine(pipe2.Object, pipe3.Object, pipe4.Object);

            var result = composite.Execute("1", "2", "3", "4");

            Assert.AreEqual(new Tuple<int, int, int, int>(1, 2, 3, 4), result);
        }

        [Test]
        public void ShouldFeedFiveInputsIntoOnePipe()
        {
            var pipe1 = new Mock<IPipe<string, int>>();
            var pipe2 = new Mock<IPipe<string, int>>();
            var pipe3 = new Mock<IPipe<string, int>>();
            var pipe4 = new Mock<IPipe<string, int>>();
            var pipe5 = new Mock<IPipe<string, int>>();

            pipe1.Setup(x => x.Execute("1")).Returns(1);
            pipe2.Setup(x => x.Execute("2")).Returns(2);
            pipe3.Setup(x => x.Execute("3")).Returns(3);
            pipe4.Setup(x => x.Execute("4")).Returns(4);
            pipe5.Setup(x => x.Execute("5")).Returns(5);

            var composite = pipe1.Object.Combine(pipe2.Object, pipe3.Object, pipe4.Object, pipe5.Object);

            var result = composite.Execute("1", "2", "3", "4", "5");

            Assert.AreEqual(new Tuple<int, int, int, int, int>(1, 2, 3, 4, 5), result);
        }

        [Test]
        public void ShouldFeedSixInputsIntoOnePipe()
        {
            var pipe1 = new Mock<IPipe<string, int>>();
            var pipe2 = new Mock<IPipe<string, int>>();
            var pipe3 = new Mock<IPipe<string, int>>();
            var pipe4 = new Mock<IPipe<string, int>>();
            var pipe5 = new Mock<IPipe<string, int>>();
            var pipe6 = new Mock<IPipe<string, int>>();

            pipe1.Setup(x => x.Execute("1")).Returns(1);
            pipe2.Setup(x => x.Execute("2")).Returns(2);
            pipe3.Setup(x => x.Execute("3")).Returns(3);
            pipe4.Setup(x => x.Execute("4")).Returns(4);
            pipe5.Setup(x => x.Execute("5")).Returns(5);
            pipe6.Setup(x => x.Execute("6")).Returns(6);

            var composite = pipe1.Object.Combine(pipe2.Object, pipe3.Object, pipe4.Object, pipe5.Object, pipe6.Object);

            var result = composite.Execute("1", "2", "3", "4", "5", "6");

            Assert.AreEqual(new Tuple<int, int, int, int, int, int>(1, 2, 3, 4, 5, 6), result);
        }

        [Test]
        public void ShouldFeedSevenInputsIntoOnePipe()
        {
            var pipe1 = new Mock<IPipe<string, int>>();
            var pipe2 = new Mock<IPipe<string, int>>();
            var pipe3 = new Mock<IPipe<string, int>>();
            var pipe4 = new Mock<IPipe<string, int>>();
            var pipe5 = new Mock<IPipe<string, int>>();
            var pipe6 = new Mock<IPipe<string, int>>();
            var pipe7 = new Mock<IPipe<string, int>>();

            pipe1.Setup(x => x.Execute("1")).Returns(1);
            pipe2.Setup(x => x.Execute("2")).Returns(2);
            pipe3.Setup(x => x.Execute("3")).Returns(3);
            pipe4.Setup(x => x.Execute("4")).Returns(4);
            pipe5.Setup(x => x.Execute("5")).Returns(5);
            pipe6.Setup(x => x.Execute("6")).Returns(6);
            pipe7.Setup(x => x.Execute("7")).Returns(7);

            var composite = pipe1.Object.Combine(pipe2.Object, pipe3.Object, pipe4.Object, pipe5.Object, pipe6.Object, pipe7.Object);

            var result = composite.Execute("1", "2", "3", "4", "5", "6", "7");

            Assert.AreEqual(new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7), result);
        }
    }
}