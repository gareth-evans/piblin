using System;
using Piblin.Wrappers;

namespace Piblin.Extensions
{
    public static class FlattenExtensions
    {
        public static IPipe<Unit, TOut> Flatten<TOut>(this IPipe<Tuple<Unit, Unit>, TOut> pipe)
        {
            return new FlattenWrapper<TOut>(pipe);
        }

        public static IPipe<Unit, TOut> Flatten<TOut>(this IPipe<Tuple<Unit, Unit, Unit>, TOut> pipe)
        {
            return new FlattenWrapper<TOut>(pipe);
        }

        public static IPipe<Unit, TOut> Flatten<TOut>(this IPipe<Tuple<Unit, Unit, Unit, Unit>, TOut> pipe)
        {
            return new FlattenWrapper<TOut>(pipe);
        }

        public static IPipe<Unit, TOut> Flatten<TOut>(this IPipe<Tuple<Unit, Unit, Unit, Unit, Unit>, TOut> pipe)
        {
            return new FlattenWrapper<TOut>(pipe);
        }

        public static IPipe<Unit, TOut> Flatten<TOut>(this IPipe<Tuple<Unit, Unit, Unit, Unit, Unit, Unit>, TOut> pipe)
        {
            return new FlattenWrapper<TOut>(pipe);
        }

        public static IPipe<Unit, TOut> Flatten<TOut>(this IPipe<Tuple<Unit, Unit, Unit, Unit, Unit, Unit, Unit>, TOut> pipe)
        {
            return new FlattenWrapper<TOut>(pipe);
        }
    }
}