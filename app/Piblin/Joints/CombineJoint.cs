using System;

namespace Piblin.Joints
{
    internal class CombineJoint<TIn1, TIn2, TOut1, TOut2> : IPipe<Tuple<TIn1, TIn2>, Tuple<TOut1, TOut2>>
    {
        private readonly IPipe<TIn1, TOut1> _left;
        private readonly IPipe<TIn2, TOut2> _right;

        public CombineJoint(IPipe<TIn1, TOut1> left, IPipe<TIn2, TOut2>  right)
        {
            _left = left;
            _right = right;
        }

        public Tuple<TOut1, TOut2> Execute(Tuple<TIn1, TIn2> input)
        {
            var leftResult = _left.Execute(input.Item1);
            var rightResult = _right.Execute(input.Item2);

            return new Tuple<TOut1, TOut2>(leftResult, rightResult);
        }
    }

    internal class CombineJoint<TIn1, TIn2, TIn3, TOut1, TOut2, TOut3> : IPipe<Tuple<TIn1, TIn2, TIn3>, Tuple<TOut1, TOut2, TOut3>>
    {
        private readonly IPipe<TIn1, TOut1> _input1;
        private readonly IPipe<TIn2, TOut2> _input2;
        private readonly IPipe<TIn3, TOut3> _input3;

        public CombineJoint(
            IPipe<TIn1, TOut1> input1,
            IPipe<TIn2, TOut2> input2,
            IPipe<TIn3, TOut3> input3)
        {
            _input1 = input1;
            _input2 = input2;
            _input3 = input3;
        }

        public Tuple<TOut1, TOut2, TOut3> Execute(Tuple<TIn1, TIn2, TIn3> input)
        {
            var result1 = _input1.Execute(input.Item1);
            var result2 = _input2.Execute(input.Item2);
            var result3 = _input3.Execute(input.Item3);

            return new Tuple<TOut1, TOut2, TOut3>(result1, result2, result3);
        }
    }

    internal class CombineJoint<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2, TOut3, TOut4> : IPipe<Tuple<TIn1, TIn2, TIn3, TIn4>, Tuple<TOut1, TOut2, TOut3, TOut4>>
    {
        private readonly IPipe<TIn1, TOut1> _input1;
        private readonly IPipe<TIn2, TOut2> _input2;
        private readonly IPipe<TIn3, TOut3> _input3;
        private readonly IPipe<TIn4, TOut4> _input4;

        public CombineJoint(
            IPipe<TIn1, TOut1> input1,
            IPipe<TIn2, TOut2> input2,
            IPipe<TIn3, TOut3> input3,
            IPipe<TIn4, TOut4> input4
        )
        {
            _input1 = input1;
            _input2 = input2;
            _input3 = input3;
            _input4 = input4;
        }

        public Tuple<TOut1, TOut2, TOut3, TOut4> Execute(Tuple<TIn1, TIn2, TIn3, TIn4> input)
        {
            var result1 = _input1.Execute(input.Item1);
            var result2 = _input2.Execute(input.Item2);
            var result3 = _input3.Execute(input.Item3);
            var result4 = _input4.Execute(input.Item4);

            return new Tuple<TOut1, TOut2, TOut3, TOut4>(result1, result2, result3, result4);
        }
    }

    internal class CombineJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2, TOut3, TOut4, TOut5> : IPipe<Tuple<TIn1, TIn2, TIn3, TIn4, TIn5>, Tuple<TOut1, TOut2, TOut3, TOut4, TOut5>>
    {
        private readonly IPipe<TIn1, TOut1> _input1;
        private readonly IPipe<TIn2, TOut2> _input2;
        private readonly IPipe<TIn3, TOut3> _input3;
        private readonly IPipe<TIn4, TOut4> _input4;
        private readonly IPipe<TIn5, TOut5> _input5;

        public CombineJoint(
            IPipe<TIn1, TOut1> input1,
            IPipe<TIn2, TOut2> input2,
            IPipe<TIn3, TOut3> input3,
            IPipe<TIn4, TOut4> input4,
            IPipe<TIn5, TOut5> input5
        )
        {
            _input1 = input1;
            _input2 = input2;
            _input3 = input3;
            _input4 = input4;
            _input5 = input5;
        }

        public Tuple<TOut1, TOut2, TOut3, TOut4, TOut5> Execute(Tuple<TIn1, TIn2, TIn3, TIn4, TIn5> input)
        {
            var result1 = _input1.Execute(input.Item1);
            var result2 = _input2.Execute(input.Item2);
            var result3 = _input3.Execute(input.Item3);
            var result4 = _input4.Execute(input.Item4);
            var result5 = _input5.Execute(input.Item5);

            return new Tuple<TOut1, TOut2, TOut3, TOut4, TOut5>(result1, result2, result3, result4, result5);
        }
    }

    internal class CombineJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2, TOut3, TOut4, TOut5, TOut6> : IPipe<Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>, Tuple<TOut1, TOut2, TOut3, TOut4, TOut5, TOut6>>
    {
        private readonly IPipe<TIn1, TOut1> _input1;
        private readonly IPipe<TIn2, TOut2> _input2;
        private readonly IPipe<TIn3, TOut3> _input3;
        private readonly IPipe<TIn4, TOut4> _input4;
        private readonly IPipe<TIn5, TOut5> _input5;
        private readonly IPipe<TIn6, TOut6> _input6;

        public CombineJoint(
            IPipe<TIn1, TOut1> input1,
            IPipe<TIn2, TOut2> input2,
            IPipe<TIn3, TOut3> input3,
            IPipe<TIn4, TOut4> input4,
            IPipe<TIn5, TOut5> input5,
            IPipe<TIn6, TOut6> input6
        )
        {
            _input1 = input1;
            _input2 = input2;
            _input3 = input3;
            _input4 = input4;
            _input5 = input5;
            _input6 = input6;
        }

        public Tuple<TOut1, TOut2, TOut3, TOut4, TOut5,TOut6> Execute(Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> input)
        {
            var result1 = _input1.Execute(input.Item1);
            var result2 = _input2.Execute(input.Item2);
            var result3 = _input3.Execute(input.Item3);
            var result4 = _input4.Execute(input.Item4);
            var result5 = _input5.Execute(input.Item5);
            var result6 = _input6.Execute(input.Item6);

            return new Tuple<TOut1, TOut2, TOut3, TOut4, TOut5, TOut6>(result1, result2, result3, result4, result5, result6);
        }
    }

    internal class CombineJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2, TOut3, TOut4, TOut5, TOut6, TOut7> : IPipe<Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>, Tuple<TOut1, TOut2, TOut3, TOut4, TOut5, TOut6, TOut7>>
    {
        private readonly IPipe<TIn1, TOut1> _input1;
        private readonly IPipe<TIn2, TOut2> _input2;
        private readonly IPipe<TIn3, TOut3> _input3;
        private readonly IPipe<TIn4, TOut4> _input4;
        private readonly IPipe<TIn5, TOut5> _input5;
        private readonly IPipe<TIn6, TOut6> _input6;
        private readonly IPipe<TIn7, TOut7> _input7;

        public CombineJoint(
            IPipe<TIn1, TOut1> input1,
            IPipe<TIn2, TOut2> input2,
            IPipe<TIn3, TOut3> input3,
            IPipe<TIn4, TOut4> input4,
            IPipe<TIn5, TOut5> input5,
            IPipe<TIn6, TOut6> input6,
            IPipe<TIn7, TOut7> input7
        )
        {
            _input1 = input1;
            _input2 = input2;
            _input3 = input3;
            _input4 = input4;
            _input5 = input5;
            _input6 = input6;
            _input7 = input7;
        }

        public Tuple<TOut1, TOut2, TOut3, TOut4, TOut5, TOut6, TOut7> Execute(Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> input)
        {
            var result1 = _input1.Execute(input.Item1);
            var result2 = _input2.Execute(input.Item2);
            var result3 = _input3.Execute(input.Item3);
            var result4 = _input4.Execute(input.Item4);
            var result5 = _input5.Execute(input.Item5);
            var result6 = _input6.Execute(input.Item6);
            var result7 = _input7.Execute(input.Item7);

            return new Tuple<TOut1, TOut2, TOut3, TOut4, TOut5, TOut6, TOut7>(result1, result2, result3, result4, result5, result6, result7);
        }
    }
}