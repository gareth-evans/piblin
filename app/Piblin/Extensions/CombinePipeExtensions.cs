using System;
using Piblin.Joints;

namespace Piblin.Extensions
{
    public static class CombinePipeExtensions
    {
        public static IPipe<Tuple<TIn1, TIn2>, Tuple<TOut1, TOut2>> Combine<TIn1, TIn2, TOut1, TOut2>(
            this IPipe<TIn1, TOut1> left, 
            IPipe<TIn2, TOut2> right
        )
        {
            return new CombineJoint<TIn1, TIn2, TOut1, TOut2>(left, right);
        }

        public static IPipe<Tuple<TIn1, TIn2, TIn3>, Tuple<TOut1, TOut2, TOut3>> 
            Combine<TIn1, TIn2, TIn3, TOut1, TOut2, TOut3>(
            this IPipe<TIn1, TOut1> left, IPipe<TIn2, TOut2> middle, IPipe<TIn3, TOut3> right)
        {
            return new CombineJoint<TIn1, TIn2, TIn3, TOut1, TOut2, TOut3>(left, middle, right);
        }

        public static IPipe<Tuple<TIn1, TIn2, TIn3, TIn4>, Tuple<TOut1, TOut2, TOut3, TOut4>> 
            Combine<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2, TOut3, TOut4>(
            this IPipe<TIn1, TOut1> one, IPipe<TIn2, TOut2> two, IPipe<TIn3, TOut3> three, IPipe<TIn4, TOut4> four)
        {
            return new CombineJoint<TIn1, TIn2, TIn3, TIn4, TOut1, TOut2, TOut3, TOut4>(one, two, three, four);
        }

        public static IPipe<Tuple<TIn1, TIn2, TIn3, TIn4, TIn5>, Tuple<TOut1, TOut2, TOut3, TOut4, TOut5>> 
            Combine<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2, TOut3, TOut4, TOut5>(
            this IPipe<TIn1, TOut1> one, IPipe<TIn2, TOut2> two, IPipe<TIn3, TOut3> three, IPipe<TIn4, TOut4> four, IPipe<TIn5, TOut5> five)
        {
            return new CombineJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TOut1, TOut2, TOut3, TOut4, TOut5>(one, two, three, four, five);
        }

        public static IPipe<Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6>, Tuple<TOut1, TOut2, TOut3, TOut4, TOut5, TOut6>>
    Combine<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2, TOut3, TOut4, TOut5, TOut6>(
    this IPipe<TIn1, TOut1> one, IPipe<TIn2, TOut2> two, IPipe<TIn3, TOut3> three, IPipe<TIn4, TOut4> four, IPipe<TIn5, TOut5> five, IPipe<TIn6, TOut6> six)
        {
            return new CombineJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TOut1, TOut2, TOut3, TOut4, TOut5, TOut6>(one, two, three, four, five, six);
        }

        public static IPipe<Tuple<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7>, Tuple<TOut1, TOut2, TOut3, TOut4, TOut5, TOut6, TOut7>>
            Combine<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2, TOut3, TOut4, TOut5, TOut6, TOut7>(
                this IPipe<TIn1, TOut1> one, 
                IPipe<TIn2, TOut2> two, 
                IPipe<TIn3, TOut3> three, 
                IPipe<TIn4, TOut4> four, 
                IPipe<TIn5, TOut5> five, 
                IPipe<TIn6, TOut6> six, 
                IPipe<TIn7, TOut7> seven)
        {
            return new CombineJoint<TIn1, TIn2, TIn3, TIn4, TIn5, TIn6, TIn7, TOut1, TOut2, TOut3, TOut4, TOut5, TOut6, TOut7>(one, two, three, four, five, six, seven);
        }
    }
}