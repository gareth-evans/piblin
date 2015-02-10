using System;
using System.Diagnostics;

namespace Piblin.Diagnostics
{
    public class TimedCodeBlock : IDisposable
    {
        private readonly string _description;
        private readonly Action<string> _loggingAction;
        private readonly Stopwatch _stopwatch;

        public TimedCodeBlock(string description, Action<string> loggingAction)
        {
            _description = description;
            _loggingAction = loggingAction;
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
        }

        public void Dispose()
        {
            _stopwatch.Stop();
            var message = String.Format("Code block '{0}' took {1} ms", _description, _stopwatch.ElapsedMilliseconds);
            _loggingAction(message);
        }
    }
}