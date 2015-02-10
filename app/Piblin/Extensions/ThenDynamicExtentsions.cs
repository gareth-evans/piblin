using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vtbct.Pipeline.Extensions
{
    public interface IPipe
    {
        void Initialize(IPipe next);
        Task Execute(dynamic context);
    }

    public class Builder : IFluentBuilder
    {
        private readonly IList<Type> _pipeline = new List<Type>();

        public IFluentBuilder With<T>()
            where T : IPipe
        {
            _pipeline.Add(typeof(T));
            return this;
        }

        IFluentBuilder IFluentBuilder.Then<T>()
        {
            return With<T>();
        }

        public IPipe Build(Func<Type, object> typeResolver)
        {
            var stepInstances = CreateSteps(typeResolver);

            for (var i = 0; i < stepInstances.Length - 1; i++)
            {
                stepInstances[i].Initialize(stepInstances[i + 1]);
            }

            stepInstances[stepInstances.Length - 1].Initialize(Pipe.Null);

            return stepInstances[0];
        }

        private IPipe[] CreateSteps(Func<Type, object> typeResolver)
        {
            return _pipeline.Select(x => (IPipe)typeResolver(x)).ToArray();
        }

    }



    public interface IFluentBuilder
    {
        IFluentBuilder Then<T>() where T : IPipe;
        IPipe Build(Func<Type, object> typeResolver);
    }

    public static class CompletedTaskFactory
    {
        public static Task FromResult<T>(T result)
        {
            var tcs = new TaskCompletionSource<T>();
            tcs.SetResult(result);

            return tcs.Task;
        }
    }

    public static class Pipe
    {
        public static readonly IPipe Null = new NullPipe();

        private class NullPipe : IPipe
        {
            public void Initialize(IPipe next)
            {
            }

            public Task Execute(dynamic context)
            {
                return CompletedTaskFactory.FromResult<object>(null);
            }
        }
    }
}