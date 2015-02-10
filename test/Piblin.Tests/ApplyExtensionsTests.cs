using NUnit.Framework;
using Piblin.Extensions;

namespace Piblin.Tests
{
    [TestFixture]
    public class ApplyExtensionsTests
    {
        [Test]
        public void ShouldApplyArgumentsToPipeWith7Args()
        {
            var pipe = new ApplyPipeFake()
                .Apply(1)
                .Apply(2)
                .Apply(3)
                .Apply(4)
                .Apply(5)
                .Apply(6)
                .Apply(7);

            var result = pipe.Execute(Unit.Instance);

            Assert.AreEqual(1,result[0]);
            Assert.AreEqual(2,result[1]);
            Assert.AreEqual(3,result[2]);
            Assert.AreEqual(4,result[3]);
            Assert.AreEqual(5,result[4]);
            Assert.AreEqual(6,result[5]);
            Assert.AreEqual(7,result[6]);
        }

        private class ApplyPipeFake : IPipe<int,int,int,int,int,int,int, int[]>
        {
            public int[] Execute(int input1, int input2, int input3, int input4, int input5, int input6, int input7)
            {
                return new[] {input1, input2, input3, input4, input5, input6, input7};
            }
        }
    }
}