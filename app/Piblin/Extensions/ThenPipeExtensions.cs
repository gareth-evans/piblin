using System;
using Piblin.Joints;

namespace Piblin.Extensions
{
    public static class ThenPipeExtensions
    {
        public static IPipe<TIn, TOut> Then<TIn, TInOut, TOut>(this IPipe<TIn, TInOut> left, IPipe<TInOut, TOut> right)
        {
            return new ThenJoint<TIn, TInOut, TOut>(left, right);
        }

        public static IPipe<TIn, TOut> Then<TIn, TInOut1, TInOut2, TOut>(
            this IPipe<TIn, Tuple<TInOut1, TInOut2>> left, IPipe<TInOut1, TInOut2, TOut> right)
        {
            var wrapper = new TuplePipeAdapter<TInOut1, TInOut2, TOut>(right);

            return new ThenJoint<TIn, Tuple<TInOut1, TInOut2>, TOut>(left, wrapper);
        }

        public static IPipe<TIn1, TIn2, TOut> Then<TIn1, TIn2, TInOut, TOut>(
            this IPipe<TIn1, TIn2, TInOut> left,
            IPipe<TInOut, TOut> right
            )
        {
            return new ThenJoint<TIn1, TIn2, TInOut, TOut>(left, right);
        }

        public static IPipe<TIn1, TIn2, TIn3, TOut> Then<TIn1, TIn2, TIn3, TInOut, TOut>(
            this IPipe<TIn1, TIn2, TIn3, TInOut> left,
            IPipe<TInOut, TOut> right)
        {
            return new ThenJoint<TIn1, TIn2, TIn3, TInOut, TOut>(left, right);
        }

        public static IPipe<TIn1, TIn2, TIn3, TIn4, TOut> Then<TIn1, TIn2, TIn3, TIn4, TInOut, TOut>(
            this IPipe<TIn1, TIn2, TIn3, TIn4, TInOut> left,
            IPipe<TInOut, TOut> right)
        {
            return new ThenJoint<TIn1, TIn2, TIn3, TIn4, TInOut, TOut>(left, right);
        }

        public static IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> Then<TIn1, TIn2, TIn3, TIn4, TIn5, TInOut, TOut>(
            this IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TInOut> left,
            IPipe<TInOut, TOut> right)
        {
            return new ThenJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TInOut, TOut>(left, right);
        }

        public static IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> Then<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TInOut, TOut>(
            this IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TInOut> left,
            IPipe<TInOut, TOut> right)
        {
            return new ThenJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TInOut, TOut>(left, right);
        }

        public static IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> Then<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TInOut, TOut>(
            this IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TInOut> left,
            IPipe<TInOut, TOut> right)
        {
            return new ThenJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TInOut, TOut>(left, right);
        }

        public static IPipe<TIn, TOut> Then<TIn, TInOut1, TInOut2, TInOut3, TOut>(
            this IPipe<TIn, Tuple<TInOut1, TInOut2, TInOut3>> left,
            IPipe<TInOut1, TInOut2, TInOut3, TOut> right)
        {
            var wrapper = new TuplePipeAdapter<TInOut1, TInOut2, TInOut3, TOut>(right);

            return new ThenJoint<TIn, Tuple<TInOut1, TInOut2, TInOut3>, TOut>(left, wrapper);
        }


        public static IPipe<TIn1, TIn2, TOut> Then<TIn1, TIn2, TInOut1, TInOut2, TOut>(
            this IPipe<TIn1, TIn2, Tuple<TInOut1, TInOut2>> left,
            IPipe<TInOut1, TInOut2, TOut> right)
        {
            var wrapper = new TuplePipeAdapter<TInOut1, TInOut2, TOut>(right);

            return new ThenJoint<TIn1, TIn2, Tuple<TInOut1, TInOut2>, TOut>(left, wrapper);
        }

        public static IPipe<TIn1, TIn2, TIn3, TOut> Then<TIn1, TIn2, TIn3, TInOut1, TInOut2, TInOut3, TOut>(
            this IPipe<TIn1, TIn2, TIn3, Tuple<TInOut1, TInOut2, TInOut3>> left,
            IPipe<TInOut1, TInOut2, TInOut3, TOut> right)
        {
            var wrapper = new TuplePipeAdapter<TInOut1, TInOut2, TInOut3, TOut>(right);

            return new ThenJoint<TIn1, TIn2, TIn3, Tuple<TInOut1, TInOut2, TInOut3>, TOut>(left, wrapper);
        }

        public static IPipe<TIn, TOut> Then<TIn, TInOut1, TInOut2, TInOut3, TInOut4, TOut>(
            this IPipe<TIn, Tuple<TInOut1, TInOut2, TInOut3, TInOut4>> left,
            IPipe<TInOut1, TInOut2, TInOut3, TInOut4, TOut> right)
        {
            var wrapper = new TuplePipeAdapter<TInOut1, TInOut2, TInOut3, TInOut4, TOut>(right);

            return new ThenJoint<TIn, Tuple<TInOut1, TInOut2, TInOut3, TInOut4>, TOut>(left, wrapper);
        }

        public static IPipe<TIn, TOut> Then<TIn, TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TOut>(
            this IPipe<TIn, Tuple<TInOut1, TInOut2, TInOut3, TInOut4, TInOut5>> left,
            IPipe<TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TOut> right)
        {
            var wrapper = new TuplePipeAdapter<TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TOut>(right);

            return new ThenJoint<TIn, Tuple<TInOut1, TInOut2, TInOut3, TInOut4, TInOut5>, TOut>(left, wrapper);
        }

        public static IPipe<TIn, TOut> Then<TIn, TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TInOut6, TOut>(
            this IPipe<TIn, Tuple<TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TInOut6>> left,
            IPipe<TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TInOut6, TOut> right)
        {
            var wrapper = new TuplePipeAdapter<TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TInOut6, TOut>(right);

            return new ThenJoint<TIn, Tuple<TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TInOut6>, TOut>(left, wrapper);
        }

        public static IPipe<TIn, TOut> Then<TIn, TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TInOut6, TInOut7, TOut>(
            this IPipe<TIn, Tuple<TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TInOut6, TInOut7>> left,
            IPipe<TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TInOut6, TInOut7, TOut> right)
        {
            var wrapper = new TuplePipeAdapter<TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TInOut6, TInOut7, TOut>(right);

            return new ThenJoint<TIn, Tuple<TInOut1, TInOut2, TInOut3, TInOut4, TInOut5, TInOut6, TInOut7>, TOut>(left, wrapper);
        }

        private class TuplePipeAdapter<TIn1, TIn2, TOut> : IPipe<Tuple<TIn1, TIn2>, TOut>
        {
            private readonly IPipe<TIn1, TIn2, TOut> _pipe;

            public TuplePipeAdapter(IPipe<TIn1, TIn2, TOut> pipe)
            {
                _pipe = pipe;
            }

            public TOut Execute(Tuple<TIn1, TIn2> input)
            {
                return _pipe.Execute(input.Item1, input.Item2);
            }
        }

        public class TuplePipeAdapter<TIn1, TIn2, TIn3, TOut> : IPipe<Tuple<TIn1, TIn2, TIn3>, TOut>
        {
            private readonly IPipe<TIn1, TIn2, TIn3, TOut> _pipe;

            public TuplePipeAdapter(IPipe<TIn1, TIn2, TIn3, TOut> pipe)
            {
                _pipe = pipe;
            }

            public TOut Execute(Tuple<TIn1, TIn2, TIn3> input)
            {
                return _pipe.Execute(input.Item1, input.Item2, input.Item3);
            }
        }

        private class TuplePipeAdapter<TIn1, TIn2, TIn3, TIn4, TOut> : IPipe<Tuple<TIn1, TIn2, TIn3, TIn4>, TOut>
        {
            private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TOut> _pipe;

            public TuplePipeAdapter(IPipe<TIn1, TIn2, TIn3, TIn4, TOut> pipe)
            {
                _pipe = pipe;
            }

            public TOut Execute(Tuple<TIn1, TIn2, TIn3, TIn4> input)
            {
                return _pipe.Execute(input.Item1, input.Item2, input.Item3, input.Item4);
            }
        }

        private class TuplePipeAdapter<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> : IPipe<Tuple<TIn1, TIn2, TIn3, TIn4, TIn5>, TOut>
        {
            private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> _pipe;

            public TuplePipeAdapter(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> pipe)
            {
                _pipe = pipe;
            }

            public TOut Execute(Tuple<TIn1, TIn2, TIn3, TIn4, TIn5> input)
            {
                return _pipe.Execute(input.Item1, input.Item2, input.Item3, input.Item4, input.Item5);
            }
        }

        private class TuplePipeAdapter<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> : IPipe<Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>, TOut>
        {
            private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> _pipe;

            public TuplePipeAdapter(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> pipe)
            {
                _pipe = pipe;
            }

            public TOut Execute(Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6> input)
            {
                return _pipe.Execute(input.Item1, input.Item2, input.Item3, input.Item4, input.Item5, input.Item6);
            }
        }

        private class TuplePipeAdapter<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> : IPipe<Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>, TOut>
        {
            private readonly IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> _pipe;

            public TuplePipeAdapter(IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> pipe)
            {
                _pipe = pipe;
            }

            public TOut Execute(Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7> input)
            {
                return _pipe.Execute(input.Item1, input.Item2, input.Item3, input.Item4, input.Item5, input.Item6, input.Item7);
            }
        }
    }
}