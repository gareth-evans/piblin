using System;

namespace Piblin.Extensions
{
    public static class SplitExtensions
    {
        public static IPipe<TIn, Tuple<TOut1, TOut2>> SplitInto<TIn, TInOut1, TInOut2, TOut1, TOut2>(this IPipe<TIn, Tuple<TInOut1, TInOut2>> source, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2,TOut2> pipe2)
        {
            return new SplitJoint<TIn, TInOut1, TInOut2, TOut1, TOut2>(source, pipe1, pipe2);
        }

        public static IPipe<TIn1, TIn2, Tuple<TOut1, TOut2>> SplitInto<TIn1, TIn2, TInOut1, TInOut2, TOut1, TOut2>(this IPipe<TIn1, TIn2, Tuple<TInOut1, TInOut2>> source, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            return new SplitJoint<TIn1, TIn2, TInOut1, TInOut2, TOut1, TOut2>(source, pipe1, pipe2);
        }

        public static IPipe<TIn1, Tuple<TOut1, TInOut2>> ForkFirstInto<TIn1,TInOut1, TInOut2, TOut1>(this IPipe<TIn1, Tuple<TInOut1, TInOut2>> source, IPipe<TInOut1, TOut1> pipe1)
        {
            return new SplitJoint<TIn1, TInOut1, TInOut2, TOut1, TInOut2>(source, pipe1, new EchoPipe<TInOut2>());
        }

        public static IPipe<TIn1, TIn2, Tuple<TOut1, TInOut2>> ForkFirstInto<TIn1, TIn2, TInOut1, TInOut2, TOut1>(this IPipe<TIn1, TIn2, Tuple<TInOut1, TInOut2>> source, IPipe<TInOut1, TOut1> pipe1)
        {
            return new SplitJoint<TIn1, TIn2, TInOut1, TInOut2, TOut1, TInOut2>(source, pipe1, new EchoPipe<TInOut2>());
        }

        public static IPipe<TIn1, TIn2, Tuple<TInOut1, TOut2>> ForkSecondInto<TIn1, TIn2, TInOut1, TInOut2, TOut2>(this IPipe<TIn1, TIn2, Tuple<TInOut1, TInOut2>> source, IPipe<TInOut2, TOut2> pipe2)
        {
            return new SplitJoint<TIn1, TIn2, TInOut1, TInOut2, TInOut1, TOut2>(source, new EchoPipe<TInOut1>(), pipe2);
        }

        public static IPipe<TIn1, Tuple<TInOut1, TOut2>> ForkSecondInto<TIn1, TInOut1, TInOut2, TOut2>(this IPipe<TIn1, Tuple<TInOut1, TInOut2>> source, IPipe<TInOut2, TOut2> pipe2)
        {
            return new SplitJoint<TIn1, TInOut1, TInOut2, TInOut1, TOut2>(source, new EchoPipe<TInOut1>(), pipe2);
        }

        public static IPipe<TIn1, TIn2, TIn3, Tuple<TOut1, TOut2>> SplitInto<TIn1,TIn2,TIn3, TInOut1, TInOut2, TOut1, TOut2>(this IPipe<TIn1, TIn2, TIn3, Tuple<TInOut1, TInOut2>> source, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            return new SplitJoint<TIn1, TIn2, TIn3, TInOut1, TInOut2, TOut1, TOut2>(source, pipe1, pipe2);
        }

        public static IPipe<TIn1, TIn2, TIn3, TIn4, Tuple<TOut1, TOut2>> SplitInto<TIn1, TIn2, TIn3, TIn4, TInOut1, TInOut2, TOut1, TOut2>(this IPipe<TIn1, TIn2, TIn3, TIn4, Tuple<TInOut1, TInOut2>> source, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            return new SplitJoint<TIn1, TIn2, TIn3, TIn4, TInOut1, TInOut2, TOut1, TOut2>(source, pipe1, pipe2);
        }

        public static IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, Tuple<TOut1, TOut2>> SplitInto<TIn1, TIn2, TIn3, TIn4, TIn5, TInOut1, TInOut2, TOut1, TOut2>(this IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, Tuple<TInOut1, TInOut2>> source, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            return new SplitJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TInOut1, TInOut2, TOut1, TOut2>(source, pipe1, pipe2);
        }

        public static IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, Tuple<TOut1, TOut2>> SplitInto<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TInOut1, TInOut2, TOut1, TOut2>(this IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, Tuple<TInOut1, TInOut2>> source, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            return new SplitJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TInOut1, TInOut2, TOut1, TOut2>(source, pipe1, pipe2);
        }

        public static IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, Tuple<TOut1, TOut2>> SplitInto<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TInOut1, TInOut2, TOut1, TOut2>(this IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, Tuple<TInOut1, TInOut2>> source, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            return new SplitJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TInOut1, TInOut2, TOut1, TOut2>(source, pipe1, pipe2);
        }
    }

    internal class SplitJoint<TIn, TInOut1, TInOut2, TOut1, TOut2> : IPipe<TIn, Tuple<TOut1, TOut2>>
    {
        private readonly IPipe<TIn, Tuple<TInOut1, TInOut2>> _parent;
        private readonly IPipe<TInOut1, TOut1> _pipe1;
        private readonly IPipe<TInOut2, TOut2> _pipe2;

        public SplitJoint(IPipe<TIn,Tuple<TInOut1, TInOut2>> parent, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            _parent = parent;
            _pipe1 = pipe1;
            _pipe2 = pipe2;
        }

        public Tuple<TOut1, TOut2> Execute(TIn input)
        {
            var result1 = _parent.Execute(input);
            var result2 = _pipe1.Execute(result1.Item1);
            var result3 = _pipe2.Execute(result1.Item2);

            return new Tuple<TOut1, TOut2>(result2, result3);
        }
    }

    internal class SplitJoint<TIn1, TIn2, TInOut1, TInOut2, TOut1, TOut2> : IPipe<TIn1, TIn2, Tuple<TOut1, TOut2>>
    {
        private readonly IPipe<TIn1, TIn2, Tuple<TInOut1, TInOut2>> _parent;
        private readonly IPipe<TInOut1, TOut1> _pipe1;
        private readonly IPipe<TInOut2, TOut2> _pipe2;

        public SplitJoint(IPipe<TIn1, TIn2, Tuple<TInOut1, TInOut2>> parent, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            _parent = parent;
            _pipe1 = pipe1;
            _pipe2 = pipe2;
        }

        public Tuple<TOut1, TOut2> Execute(TIn1 input1, TIn2 input2)
        {
            var result1 = _parent.Execute(input1, input2);
            var result2 = _pipe1.Execute(result1.Item1);
            var result3 = _pipe2.Execute(result1.Item2);

            return new Tuple<TOut1, TOut2>(result2, result3);
        }
    }

    internal class SplitJoint<TIn1, TIn2, TIn3, TInOut1, TInOut2, TOut1, TOut2> : IPipe<TIn1, TIn2, TIn3, Tuple<TOut1, TOut2>>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, Tuple<TInOut1, TInOut2>> _parent;
        private readonly IPipe<TInOut1, TOut1> _pipe1;
        private readonly IPipe<TInOut2, TOut2> _pipe2;

        public SplitJoint(IPipe<TIn1, TIn2, TIn3, Tuple<TInOut1, TInOut2>> parent, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            _parent = parent;
            _pipe1 = pipe1;
            _pipe2 = pipe2;
        }

        public Tuple<TOut1, TOut2> Execute(TIn1 input1, TIn2 input2, TIn3 input3)
        {
            var result1 = _parent.Execute(input1, input2, input3);
            var result2 = _pipe1.Execute(result1.Item1);
            var result3 = _pipe2.Execute(result1.Item2);

            return new Tuple<TOut1, TOut2>(result2, result3);
        }
    }

    internal class SplitJoint<TIn1, TIn2, TIn3, TIn4, TInOut1, TInOut2, TOut1, TOut2> : IPipe<TIn1, TIn2, TIn3, TIn4, Tuple<TOut1, TOut2>>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, Tuple<TInOut1, TInOut2>> _parent;
        private readonly IPipe<TInOut1, TOut1> _pipe1;
        private readonly IPipe<TInOut2, TOut2> _pipe2;

        public SplitJoint(IPipe<TIn1, TIn2, TIn3,TIn4, Tuple<TInOut1, TInOut2>> parent, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            _parent = parent;
            _pipe1 = pipe1;
            _pipe2 = pipe2;
        }

        public Tuple<TOut1, TOut2> Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4)
        {
            var result1 = _parent.Execute(input1, input2, input3, input4);
            var result2 = _pipe1.Execute(result1.Item1);
            var result3 = _pipe2.Execute(result1.Item2);

            return new Tuple<TOut1, TOut2>(result2, result3);
        }
    }

    internal class SplitJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TInOut1, TInOut2, TOut1, TOut2> : IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, Tuple<TOut1, TOut2>>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, Tuple<TInOut1, TInOut2>> _parent;
        private readonly IPipe<TInOut1, TOut1> _pipe1;
        private readonly IPipe<TInOut2, TOut2> _pipe2;

        public SplitJoint(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, Tuple<TInOut1, TInOut2>> parent, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            _parent = parent;
            _pipe1 = pipe1;
            _pipe2 = pipe2;
        }

        public Tuple<TOut1, TOut2> Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5)
        {
            var result1 = _parent.Execute(input1, input2, input3, input4, input5);
            var result2 = _pipe1.Execute(result1.Item1);
            var result3 = _pipe2.Execute(result1.Item2);

            return new Tuple<TOut1, TOut2>(result2, result3);
        }
    }

    internal class SplitJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TInOut1, TInOut2, TOut1, TOut2> : IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, Tuple<TOut1, TOut2>>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, Tuple<TInOut1, TInOut2>> _parent;
        private readonly IPipe<TInOut1, TOut1> _pipe1;
        private readonly IPipe<TInOut2, TOut2> _pipe2;

        public SplitJoint(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, Tuple<TInOut1, TInOut2>> parent, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            _parent = parent;
            _pipe1 = pipe1;
            _pipe2 = pipe2;
        }

        public Tuple<TOut1, TOut2> Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6)
        {
            var result1 = _parent.Execute(input1, input2, input3, input4, input5, input6);
            var result2 = _pipe1.Execute(result1.Item1);
            var result3 = _pipe2.Execute(result1.Item2);

            return new Tuple<TOut1, TOut2>(result2, result3);
        }
    }

    internal class SplitJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TInOut1, TInOut2, TOut1, TOut2> : IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, Tuple<TOut1, TOut2>>
    {
        private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, Tuple<TInOut1, TInOut2>> _parent;
        private readonly IPipe<TInOut1, TOut1> _pipe1;
        private readonly IPipe<TInOut2, TOut2> _pipe2;

        public SplitJoint(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, Tuple<TInOut1, TInOut2>> parent, IPipe<TInOut1, TOut1> pipe1, IPipe<TInOut2, TOut2> pipe2)
        {
            _parent = parent;
            _pipe1 = pipe1;
            _pipe2 = pipe2;
        }

        public Tuple<TOut1, TOut2> Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6, TIn7 input7)
        {
            var result1 = _parent.Execute(input1, input2, input3, input4, input5, input6, input7);
            var result2 = _pipe1.Execute(result1.Item1);
            var result3 = _pipe2.Execute(result1.Item2);

            return new Tuple<TOut1, TOut2>(result2, result3);
        }
    }
}