using System;
using System.Dynamic;
using System.Threading.Tasks;
using NUnit.Framework;
using Vtbct.Pipeline.Extensions;

namespace Vtbct.Pipeline.Tests
{
    [TestFixture]
    public class InterfaceInputOutputSpike
    {
        [Test]
        public async void Blah()
        {
            dynamic exp = new ExpandoObject();

            exp.Property = "Hello World";

            var pipe = new Builder()
                .With<DynamicPipe>()
                .Then<DynamicPipe2>()
                .Build(Activator.CreateInstance);


            //var p = new DynamicPipe()
            //    .Then(new DynamicPipe2());

            await pipe.Execute(exp);

            var s = exp.Property;

        }
    }

    public class DynamicPipe : IPipe
    {
        private IPipe _next;

        public void Initialize(IPipe next)
        {
            _next = next;
        }

        public Task Execute(dynamic context)
        {
            return _next.Execute(context);
        }
    }

    public class DynamicPipe2 : IPipe
    {
        private IPipe _next;

        public void Initialize(IPipe next)
        {
            _next = next;
        }

        async Task IPipe.Execute(dynamic context)
        {
            await _next.Execute(context);

            context["Property"] = "Hello again";

        }
    }

    public class Pipe1<T> : IPipe<T, T>
    {
        public virtual T Execute(T input)
        {
            return input;
        }
    }

    public class Pipe2 : IPipe<IB, IC>
    {
        public IC Execute(IB input)
        {
            return new C1();
        }
    }


    public interface IA
    {

    }

    public class A1 : IA
    {
    }

    public interface IB
    {
        
    }

    public interface IC : IB
    {
        
    }

    class C1 : IC
    {
    }

    public class B1 : IB
    {
    }


   
}