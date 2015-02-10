using System;
using Moq;
using NUnit.Framework;
using Piblin.Extensions;

namespace Piblin.Tests
{
    [TestFixture]
    public class ExecuteExtensionTests
    {
        [Test]
        public void ShouldPassTwoArgumentsToTuplePipe()
        {
            var pipeMock = new Mock<IPipe<Tuple<string, int>, Unit>>();
            var pipe = pipeMock.Object;

            pipe.Execute("someValue", 1);

            pipeMock.Verify(x => x.Execute(new Tuple<string, int>("someValue", 1)));
        }

        [Test]
        public void ShouldPassThreeArgumentsToTuplePipe()
        {
            var pipeMock = new Mock<IPipe<Tuple<string, bool, int>, Unit>>();
            var pipe = pipeMock.Object;

            pipe.Execute("someValue", true, 1);

            pipeMock.Verify(x => x.Execute(new Tuple<string, bool, int>("someValue", true, 1)));
        }

        [Test]
        public void ShouldPassFourArgumentsToTuplePipe()
        {
            var pipeMock = new Mock<IPipe<Tuple<string, bool, decimal, int>, Unit>>();
            var pipe = pipeMock.Object;

            pipe.Execute("someValue", true, 4m, 1);

            pipeMock.Verify(x => x.Execute(new Tuple<string, bool, decimal, int>("someValue", true, 4m, 1)));
        }

        [Test]
        public void ShouldPassFiveArgumentsToTuplePipe()
        {
            var pipeMock = new Mock<IPipe<Tuple<string, bool, decimal, double, int>, Unit>>();
            var pipe = pipeMock.Object;

            pipe.Execute("someValue", true, 4m, 67d, 1);

            pipeMock.Verify(x => x.Execute(new Tuple<string, bool, decimal, double, int>("someValue", true, 4m, 67d, 1)));
        }
    }
}