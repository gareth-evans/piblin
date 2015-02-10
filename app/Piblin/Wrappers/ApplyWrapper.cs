namespace Piblin.Wrappers
{
    internal class ApplyWrapper<TIn, TOut> : IPipe<Unit, TOut>
    {
        private readonly IPipe<TIn, TOut> _pipe;
        private readonly TIn _input;

        public ApplyWrapper(IPipe<TIn, TOut> pipe, TIn input)
        {
            _pipe = pipe;
            _input = input;
        }

        public TOut Execute(Unit input)
        {
            return _pipe.Execute(_input);
        }
    }

    internal class ApplyWrapper<TIn1, TIn2, TOut> : IPipe<TIn2, TOut>
    {
        private readonly IPipe<TIn1, TIn2, TOut> _pipe;
        private readonly TIn1 _input;

        public ApplyWrapper(IPipe<TIn1, TIn2, TOut> pipe, TIn1 input)
        {
            _pipe = pipe;
            _input = input;
        }

        public TOut Execute(TIn2 input)
        {
            return _pipe.Execute(_input, input);
        }
    }

    internal class ApplyWrapper<TIn1, TIn2, TIn3, TOut> : IPipe<TIn2, TIn3, TOut>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TOut> _pipe;
        private readonly TIn1 _input;

        public ApplyWrapper(IPipe<TIn1, TIn2, TIn3, TOut> pipe, TIn1 input)
        {
            _pipe = pipe;
            _input = input;
        }

        public TOut Execute(TIn2 input1, TIn3 input2)
        {
            return _pipe.Execute(_input, input1, input2);
        }
    }

    internal class ApplyWrapper<TIn1, TIn2, TIn3, TIn4, TOut> : IPipe<TIn2, TIn3, TIn4, TOut>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TOut> _pipe;
        private readonly TIn1 _input;

        public ApplyWrapper(IPipe<TIn1, TIn2, TIn3, TIn4, TOut> pipe, TIn1 input)
        {
            _pipe = pipe;
            _input = input;
        }

        public TOut Execute(TIn2 input1, TIn3 input2, TIn4 input3)
        {
            return _pipe.Execute(_input, input1, input2, input3);
        }
    }

    internal class ApplyWrapper<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> : IPipe<TIn2, TIn3, TIn4, TIn5, TOut>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> _pipe;
        private readonly TIn1 _input;

        public ApplyWrapper(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> pipe, TIn1 input)
        {
            _pipe = pipe;
            _input = input;
        }

        public TOut Execute(TIn2 input1, TIn3 input2, TIn4 input3, TIn5 input4)
        {
            return _pipe.Execute(_input, input1, input2, input3, input4);
        }
    }

    internal class ApplyWrapper<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> : IPipe<TIn2, TIn3, TIn4, TIn5, TIn6, TOut>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> _pipe;
        private readonly TIn1 _input;

        public ApplyWrapper(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> pipe, TIn1 input)
        {
            _pipe = pipe;
            _input = input;
        }

        public TOut Execute(TIn2 input1, TIn3 input2, TIn4 input3, TIn5 input4, TIn6 input5)
        {
            return _pipe.Execute(_input, input1, input2, input3, input4, input5);
        }
    }

    internal class ApplyWrapper<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> :
        IPipe<TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> _pipe;
        private readonly TIn1 _input;

        public ApplyWrapper(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> pipe, TIn1 input)
        {
            _pipe = pipe;
            _input = input;
        }

        public TOut Execute(TIn2 input1, TIn3 input2, TIn4 input3, TIn5 input4, TIn6 input5, TIn7 input6)
        {
            return _pipe.Execute(_input, input1, input2, input3, input4, input5, input6);
        }
    }
}