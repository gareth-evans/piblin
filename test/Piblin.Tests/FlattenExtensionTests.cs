using System;
using Moq;
using NUnit.Framework;
using Piblin.Extensions;

namespace Piblin.Tests
{
    [TestFixture]
    public class FlattenExtensionTests
    {
        [Test]
        public void ShouldFlattenTupleOfTwoUnitsToUnitInputPipe()
        {
            var pipeMock = new Mock<IPipe<Tuple<Unit, Unit>, int>>();
            pipeMock.Setup(x => x.Execute(new Tuple<Unit, Unit>(Unit.Instance, Unit.Instance)))
                .Returns(1);

            var result = pipeMock.Object
                .Flatten()
                .Execute(Unit.Instance);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void ShouldFlattenTupleOfThreeUnitsToUnitInputPipe()
        {
            var pipeMock = new Mock<IPipe<Tuple<Unit, Unit, Unit>, int>>();
            pipeMock.Setup(x => x.Execute(new Tuple<Unit, Unit, Unit>(Unit.Instance, Unit.Instance, Unit.Instance)))
                .Returns(1);

            var result = pipeMock.Object
                .Flatten()
                .Execute(Unit.Instance);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void ShouldFlattenTupleOfFourUnitsToUnitInputPipe()
        {
            var pipeMock = new Mock<IPipe<Tuple<Unit, Unit, Unit, Unit>, int>>();
            pipeMock.Setup(x => x.Execute(new Tuple<Unit, Unit, Unit, Unit>(Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance)))
                .Returns(1);

            var result = pipeMock.Object
                .Flatten()
                .Execute(Unit.Instance);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void ShouldFlattenTupleOfFiveUnitsToUnitInputPipe()
        {
            var pipeMock = new Mock<IPipe<Tuple<Unit, Unit, Unit, Unit, Unit>, int>>();
            pipeMock.Setup(x => x.Execute(new Tuple<Unit, Unit, Unit, Unit, Unit>(Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance)))
                .Returns(1);

            var result = pipeMock.Object
                .Flatten()
                .Execute(Unit.Instance);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void ShouldFlattenTupleOfSixUnitsToUnitInputPipe()
        {
            var pipeMock = new Mock<IPipe<Tuple<Unit, Unit, Unit, Unit, Unit, Unit>, int>>();
            pipeMock.Setup(x => x.Execute(new Tuple<Unit, Unit, Unit, Unit, Unit, Unit>(Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance)))
                .Returns(1);

            var result = pipeMock.Object
                .Flatten()
                .Execute(Unit.Instance);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void ShouldFlattenTupleOfSevenUnitsToUnitInputPipe()
        {
            var pipeMock = new Mock<IPipe<Tuple<Unit, Unit, Unit, Unit, Unit, Unit, Unit>, int>>();
            pipeMock.Setup(x => x.Execute(new Tuple<Unit, Unit, Unit, Unit, Unit, Unit, Unit>(Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance)))
                .Returns(1);

            var result = pipeMock.Object
                .Flatten()
                .Execute(Unit.Instance);

            Assert.AreEqual(1, result);
        }
    }
}