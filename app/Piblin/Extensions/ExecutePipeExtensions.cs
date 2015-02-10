using System;

namespace Piblin.Extensions
{
    public static class ExecutePipeExtensions
    {
        public static TOut Execute<TIn1, TIn2, TOut>(this IPipe<Tuple<TIn1, TIn2>, TOut> pipe, TIn1 input1, TIn2 input2)
        {
            var tuple = new Tuple<TIn1, TIn2>(input1, input2);

            return pipe.Execute(tuple);
        }

        public static TOut Execute<TIn1, TIn2, TIn3, TOut>(this IPipe<Tuple<TIn1, TIn2, TIn3>, TOut> pipe, TIn1 input1, TIn2 input2, TIn3 input3)
        {
            var tuple = new Tuple<TIn1, TIn2, TIn3>(input1, input2, input3);

            return pipe.Execute(tuple);
        }

        public static TOut Execute<TIn1, TIn2, TIn3, TIn4, TOut>(this IPipe<Tuple<TIn1, TIn2, TIn3, TIn4>, TOut> pipe, TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4)
        {
            var tuple = new Tuple<TIn1, TIn2, TIn3, TIn4>(input1, input2, input3, input4);

            return pipe.Execute(tuple);
        }

        public static TOut Execute<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IPipe<Tuple<TIn1, TIn2, TIn3, TIn4, TIn5>, TOut> pipe, TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5)
        {
            var tuple = new Tuple<TIn1, TIn2, TIn3, TIn4, TIn5>(input1, input2, input3, input4, input5);

            return pipe.Execute(tuple);
        }

        public static TOut Execute<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IPipe<Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>, TOut> pipe, TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6)
        {
            var tuple = new Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>(input1, input2, input3, input4, input5, input6);

            return pipe.Execute(tuple);
        }

        public static TOut Execute<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IPipe<Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>, TOut> pipe, TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6, TIn7 input7)
        {
            var tuple = new Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>(input1, input2, input3, input4, input5, input6, input7);

            return pipe.Execute(tuple);
        }

    }
}