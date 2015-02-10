using System;
using Piblin.Joints;

namespace Piblin.Extensions
{
    public static class AndPipeExtensions
    {
        public static IPipe<TIn, Tuple<TOut1, TOut2>> And<TIn, TOut1, TOut2>(this IPipe<TIn, TOut1> source,
            IPipe<TIn, TOut2> pipe)
        {
            return new AndJoint<TIn, TOut1, TOut2>(source, pipe);
        }
    }
}