namespace Piblin
{
    public interface IPipe<in TIn, out TOut>
    {
        TOut Execute(TIn input);
    }

    public interface IPipe<in TIn1, in TIn2, out TOut>
    {
        TOut Execute(TIn1 input1, TIn2 input2);
    }

    public interface IPipe<in TIn1, in TIn2, in TIn3, out TOut>
    {
        TOut Execute(TIn1 input1, TIn2 input2, TIn3 input3);
    }

    public interface IPipe<in TIn1, in TIn2, in TIn3, in TIn4, out TOut>
    {
        TOut Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4);
    }

    public interface IPipe<in TIn1, in TIn2, in TIn3, in TIn4, in TIn5, out TOut>
    {
        TOut Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5);
    }

    public interface IPipe<in TIn1, in TIn2, in TIn3, in TIn4, in TIn5,in TIn6, out TOut>
    {
        TOut Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6);
    }

    public interface IPipe<in TIn1, in TIn2, in TIn3, in TIn4, in TIn5, in TIn6, in TIn7, out TOut>
    {
        TOut Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6, TIn7 input7);
    }

    public interface IPipe<in TIn1, in TIn2, in TIn3, in TIn4, in TIn5, in TIn6, in TIn7, in TIn8, out TOut>
    {
        TOut Execute(TIn1 input1, TIn2 input2, TIn3 input3, TIn4 input4, TIn5 input5, TIn6 input6, TIn7 input7, TIn8 input8);
    }
}