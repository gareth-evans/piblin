using System;
using Piblin.Diagnostics;

namespace Piblin.Extensions
{
    public static class WithLoggingPipeExtensions
    {
        public static IPipe<TIn, TOut> WithLogging<TIn, TOut>(this IPipe<TIn, TOut> pipe, Action<string> loggingAction)
        {
            return new LoggingPipeAdapter<TIn, TOut>(pipe, loggingAction);
        }

        private class LoggingPipeAdapter<TIn, TOut> : IPipe<TIn, TOut>
        {
            private readonly IPipe<TIn, TOut> _pipe;
            private readonly Action<string> _loggingAction;

            public LoggingPipeAdapter(IPipe<TIn, TOut> pipe, Action<string> loggingAction)
            {
                _pipe = pipe;
                _loggingAction = loggingAction;
            }

            public TOut Execute(TIn input)
            {
                using (new TimedCodeBlock(_pipe.GetType().Name, _loggingAction))
                {
                    return _pipe.Execute(input);
                }
            }
        }
    }
}