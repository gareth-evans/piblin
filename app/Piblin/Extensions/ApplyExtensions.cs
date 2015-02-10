using Piblin.Wrappers;

namespace Piblin.Extensions
{
    public static class ApplyExtensions
    {
        public static IPipe<Unit, TOut> Apply<TIn, TOut>(this IPipe<TIn, TOut> pipe, TIn input)
        {
            return new ApplyWrapper<TIn, TOut>(pipe, input);
        }

        public static IPipe<TIn2, TOut> Apply<TIn1, TIn2, TOut>(this IPipe<TIn1, TIn2, TOut> pipe, TIn1 input)
        {
            return new ApplyWrapper<TIn1, TIn2, TOut>(pipe, input);
        }

        public static IPipe<TIn2, TIn3, TOut> Apply<TIn1, TIn2, TIn3, TOut>(this IPipe<TIn1, TIn2, TIn3, TOut> pipe,
            TIn1 input)
        {
            return new ApplyWrapper<TIn1, TIn2, TIn3, TOut>(pipe, input);
        }

        public static IPipe<TIn2, TIn3, TIn4, TOut> Apply<TIn1, TIn2, TIn3, TIn4, TOut>(
            this IPipe<TIn1, TIn2, TIn3, TIn4, TOut> pipe, TIn1 input)
        {
            return new ApplyWrapper<TIn1, TIn2, TIn3, TIn4, TOut>(pipe, input);
        }

        public static IPipe<TIn2, TIn3, TIn4, TIn5, TOut> Apply<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(
            this IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> pipe, TIn1 input)
        {
            return new ApplyWrapper<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(pipe, input);
        }

        public static IPipe<TIn2, TIn3, TIn4, TIn5, TIn6, TOut> Apply<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(
            this IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> pipe, TIn1 input)
        {
            return new ApplyWrapper<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(pipe, input);
        }

        public static IPipe<TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> Apply
            <TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(
            this IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> pipe, TIn1 input)
        {
            return new ApplyWrapper<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(pipe, input);
        }

    }
}