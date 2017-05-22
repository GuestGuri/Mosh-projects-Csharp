using System;
using System.Threading;

namespace StopWatch
{

    public class StopWatch
    {
        private DateTime _begin = DateTime.Now;
        private DateTime _end;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Already running");
            }
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("StopWatch is not running");
            }
            _isRunning = false;
            this._end = DateTime.Now;
        }

        public TimeSpan Duration()
        {
            return _end - _begin;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            Console.WriteLine("Press Enter to start StopWatch or Exit");
            while (true)
            {
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    stopWatch.Start();
                    Console.ReadLine(); 
                    stopWatch.Stop();
                    Console.WriteLine(stopWatch.Duration());
                    continue;
                }
                break;
            }
        }
    }
}
