namespace Piblin.Joints
{
    internal class ThenJoint<TIn, TInOut, TOut> : IPipe<TIn, TOut>
    {
        private readonly IPipe<TIn, TInOut> _left;
        private readonly IPipe<TInOut, TOut> _right;

        public ThenJoint(IPipe<TIn, TInOut> left, IPipe<TInOut, TOut> right)
        {
            _left = left;
            _right = right;
        }

        public TOut Execute(TIn input)
        {
            var leftResult = _left.Execute(input);
            return _right.Execute(leftResult);
        }
    }

    internal class ThenJoint<TIn1, TIn2, TInOut, TOut> : IPipe<TIn1, TIn2, TOut>
    {
        private readonly IPipe<TIn1, TIn2, TInOut> _left;
        private readonly IPipe<TInOut, TOut> _right;

        public ThenJoint(IPipe<TIn1, TIn2,TInOut> left, IPipe<TInOut, TOut> right)
        {
            _left = left;
            _right = right;
        }

        public TOut Execute(TIn1 input1, TIn2 input2)
        {
            var result = _left.Execute(input1, input2);
            return _right.Execute(result);
        }
    }

    internal class ThenJoint<TIn1, TIn2, TIn3, TInOut, TOut> : IPipe<TIn1, TIn2, TIn3, TOut>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TInOut> _left;
        private readonly IPipe<TInOut, TOut> _right;

        public ThenJoint(IPipe<TIn1, TIn2, TIn3, TInOut> left, IPipe<TInOut, TOut> right)
        {
            _left = left;
            _right = right;
        }

        public TOut Execute(TIn1 input1, TIn2 input2, TIn3 input3)
        {
            var result = _left.Execute(input1, input2, input3);
            return _right.Execute(result);
        }
    }

    internal class ThenJoint<TIn1, TIn2, TIn3, TIn4, TInOut, TOut> : IPipe<TIn1, TIn2, TIn3, TIn4, TOut>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TInOut> _left;
        private readonly IPipe<TInOut, TOut> _right;

        public ThenJoint(IPipe<TIn1, TIn2, TIn3, TIn4, TInOut> left, IPipe<TInOut, TOut> right)
        {
            _left = left;
            _right = right;
        }

        public TOut Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4)
        {
            var result = _left.Execute(input1, input2, input3, input4);
            return _right.Execute(result);
        }
    }

    internal class ThenJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TInOut, TOut> : IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TInOut> _left;
        private readonly IPipe<TInOut, TOut> _right;

        public ThenJoint(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TInOut> left, IPipe<TInOut, TOut> right)
        {
            _left = left;
            _right = right;
        }

        public TOut Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5)
        {
            var result = _left.Execute(input1, input2, input3, input4, input5);
            return _right.Execute(result);
        }
    }

    internal class ThenJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TInOut, TOut> : IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TInOut> _left;
        private readonly IPipe<TInOut, TOut> _right;

        public ThenJoint(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TInOut> left, IPipe<TInOut, TOut> right)
        {
            _left = left;
            _right = right;
        }

        public TOut Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6)
        {
            var result = _left.Execute(input1, input2, input3, input4, input5, input6);
            return _right.Execute(result);
        }
    }

    internal class ThenJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TInOut, TOut> : IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TInOut> _left;
        private readonly IPipe<TInOut, TOut> _right;

        public ThenJoint(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TInOut> left, IPipe<TInOut, TOut> right)
        {
            _left = left;
            _right = right;
        }

        public TOut Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6, TIn7 input7)
        {
            var result = _left.Execute(input1, input2, input3, input4, input5, input6, input7);
            return _right.Execute(result);
        }
    }
}