using System;

namespace Piblin.Wrappers
{
    internal class FlattenWrapper<TOut> : IPipe<Unit, TOut>
    {
        private readonly Func<TOut> _pipeFunc;

        public FlattenWrapper(IPipe<Tuple<Unit, Unit>, TOut> pipe)
        {
            _pipeFunc = () => pipe.Execute(new Tuple<Unit, Unit>(Unit.Instance, Unit.Instance));
        }

        public FlattenWrapper(IPipe<Tuple<Unit, Unit, Unit>, TOut> pipe)
        {
            _pipeFunc = () => pipe.Execute(new Tuple<Unit, Unit, Unit>(Unit.Instance, Unit.Instance, Unit.Instance));
        }

        public FlattenWrapper(IPipe<Tuple<Unit, Unit, Unit, Unit>, TOut> pipe)
        {
            _pipeFunc = () => pipe.Execute(new Tuple<Unit, Unit, Unit, Unit>(Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance));
        }

        public FlattenWrapper(IPipe<Tuple<Unit, Unit, Unit, Unit, Unit>, TOut> pipe)
        {
            _pipeFunc = () => pipe.Execute(new Tuple<Unit, Unit, Unit, Unit, Unit>(Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance));
        }

        public FlattenWrapper(IPipe<Tuple<Unit, Unit, Unit, Unit, Unit, Unit>, TOut> pipe)
        {
            _pipeFunc = () => pipe.Execute(new Tuple<Unit, Unit, Unit, Unit, Unit, Unit>(Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance));
        }

        public FlattenWrapper(IPipe<Tuple<Unit, Unit, Unit, Unit, Unit, Unit, Unit>, TOut> pipe)
        {
            _pipeFunc = () => pipe.Execute(new Tuple<Unit, Unit, Unit, Unit, Unit, Unit, Unit>(Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance, Unit.Instance));
        }

        public TOut Execute(Unit input)
        {
            var result = _pipeFunc();
            return result;
        }
    }
}