using Piblin.Wrappers;

namespace Piblin.Extensions
{
    public static class ToUnitExtensions
    {
        public static IPipe<TIn, Unit> ToUnit<TIn, TOut>(this IPipe<TIn, TOut> pipe)
        {
            return new ToUnitWrapper<TIn, TOut>(pipe);
        }

        public static IPipe<TIn1, TIn2, Unit> ToUnit<TIn1, TIn2, TOut>(this IPipe<TIn1, TIn2, TOut> pipe)
        {
            return new ToUnitWrapper<TIn1, TIn2, TOut>(pipe);
        }

        public static IPipe<TIn1, TIn2, TIn3, Unit> ToUnit<TIn1, TIn2, TIn3, TOut>(this IPipe<TIn1, TIn2, TIn3, TOut> pipe)
        {
            return new ToUnitWrapper<TIn1, TIn2, TIn3, TOut>(pipe);
        }

        public static IPipe<TIn1, TIn2, TIn3, TIn4, Unit> ToUnit<TIn1, TIn2, TIn3, TIn4, TOut>(this IPipe<TIn1, TIn2, TIn3, TIn4, TOut> pipe)
        {
            return new ToUnitWrapper<TIn1, TIn2, TIn3, TIn4, TOut>(pipe);
        }

        public static IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, Unit> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(this IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TOut> pipe)
        {
            return new ToUnitWrapper<TIn1, TIn2, TIn3, TIn4, TIn5, TOut>(pipe);
        }

        public static IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, Unit> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(this IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut> pipe)
        {
            return new ToUnitWrapper<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut>(pipe);
        }

        public static IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, Unit> ToUnit<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(this IPipe<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut> pipe)
        {
            return new ToUnitWrapper<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut>(pipe);
        }
    }
}