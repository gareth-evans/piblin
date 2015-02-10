namespace Piblin.Wrappers
{
    internal class ToUnitWrapper<TIn, TOut> : IPipe<TIn, Unit>
    {
        private readonly IPipe<TIn, TOut> _pipe;

        public ToUnitWrapper(IPipe<TIn, TOut> pipe)
        {
            _pipe = pipe;
        }

        public Unit Execute(TIn input)
        {
            _pipe.Execute(input);

            return Unit.Instance;
        }
    }

    internal class ToUnitWrapper<TIn1, TIn2, TOut> : IPipe<TIn1, TIn2, Unit>
    {
        private readonly IPipe<TIn1, TIn2, TOut> _pipe;

        public ToUnitWrapper(IPipe<TIn1, TIn2, TOut> pipe)
        {
            _pipe = pipe;
        }

        public Unit Execute(TIn1 input1, TIn2 input2)
        {
            _pipe.Execute(input1, input2);

            return Unit.Instance;
        }
    }

    internal class ToUnitWrapper<TIn1, TIn2, TIn3, TOut> : IPipe<TIn1, TIn2, TIn3, Unit>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TOut> _pipe;

        public ToUnitWrapper(IPipe<TIn1, TIn2, TIn3, TOut> pipe)
        {
            _pipe = pipe;
        }

        public Unit Execute(TIn1 input1, TIn2 input2, TIn3 input3)
        {
            _pipe.Execute(input1, input2, input3);

            return Unit.Instance;
        }
    }

    internal class ToUnitWrapper<TIn1, TIn2, TIn3, TIn4, TOut> : IPipe<TIn1, TIn2, TIn3, TIn4, Unit>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TOut> _pipe;

        public ToUnitWrapper(IPipe<TIn1, TIn2, TIn3, TIn4, TOut> pipe)
        {
            _pipe = pipe;
        }

        public Unit Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4)
        {
            _pipe.Execute(input1, input2, input3, input4);

            return Unit.Instance;
        }
    }

    internal class ToUnitWrapper<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> : IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, Unit>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> _pipe;

        public ToUnitWrapper(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> pipe)
        {
            _pipe = pipe;
        }

        public Unit Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5)
        {
            _pipe.Execute(input1, input2, input3, input4, input5);

            return Unit.Instance;
        }
    }

    internal class ToUnitWrapper<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> : IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, Unit>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> _pipe;

        public ToUnitWrapper(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> pipe)
        {
            _pipe = pipe;
        }

        public Unit Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6)
        {
            _pipe.Execute(input1, input2, input3, input4, input5, input6);

            return Unit.Instance;
        }
    }

    internal class ToUnitWrapper<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> : IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, Unit>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> _pipe;

        public ToUnitWrapper(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> pipe)
        {
            _pipe = pipe;
        }

        public Unit Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6, TIn7 input7)
        {
            _pipe.Execute(input1, input2, input3, input4, input5, input6, input7);

            return Unit.Instance;
        }
    }
}