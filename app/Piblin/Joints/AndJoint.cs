using System;

namespace Piblin.Joints
{
    internal class AndJoint<TIn, TOut1, TOut2> : IPipe<TIn, Tuple<TOut1, TOut2>>
    {
        private readonly IPipe<TIn, TOut1> _left;
        private readonly IPipe<TIn, TOut2> _right;

        public AndJoint(IPipe<TIn, TOut1> left, IPipe<TIn, TOut2> right)
        {
            _left = left;
            _right = right;
        }

        public Tuple<TOut1, TOut2> Execute(TIn input)
        {
            var leftResult = _left.Execute(input);
            var rightResult = _right.Execute(input);

            return new Tuple<TOut1, TOut2>(leftResult, rightResult);
        }
    }

}