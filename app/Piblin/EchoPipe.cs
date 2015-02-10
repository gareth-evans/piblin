using System;

namespace Piblin
{
    public class EchoPipe<T> : IPipe<T, T>
    {
        public T Execute(T input)
        {
            return input;
        }
    }

    public class EchoPipe<T1,T2> : IPipe<T1,T2,Tuple<T1,T2>>
    {
        public Tuple<T1, T2> Execute(T1 input1, T2 input2)
        {
            return new Tuple<T1, T2>(input1, input2);
        }
    }

    public class EchoPipe<T1, T2,  T3> : IPipe<T1, T2, T3, Tuple<T1, T2, T3>>
    {
        public Tuple<T1, T2, T3> Execute(T1 input1, T2 input2, T3 input3)
        {
            return new Tuple<T1, T2, T3>(input1, input2, input3);
        }
    }

    public class EchoPipe<T1, T2, T3, T4> : IPipe<T1, T2, T3, T4, Tuple<T1, T2, T3, T4>>
    {
        public Tuple<T1, T2, T3, T4> Execute(T1 input1, T2 input2, T3 input3, T4 input4)
        {
            return new Tuple<T1, T2, T3, T4>(input1, input2, input3, input4);
        }
    }

    public class EchoPipe<T1, T2, T3, T4, T5> : IPipe<T1, T2, T3,T4,T5, Tuple<T1, T2, T3, T4,T5>>
    {
        public Tuple<T1, T2, T3, T4, T5> Execute(T1 input1, T2 input2, T3 input3, T4 input4, T5 input5)
        {
            return new Tuple<T1, T2, T3, T4, T5>(input1, input2, input3, input4, input5);
        }
    }


}