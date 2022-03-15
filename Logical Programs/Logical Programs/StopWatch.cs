using System;

namespace Logical_Programs
{
    internal class StopWatch
    {
        private DateTime _initialStartTime;
        private DateTime _startTime;
        private bool _isStart = false;
        private TimeSpan _totalTimeSpan;
        public void Run()
        {
            Console.WriteLine("This is a stopwatch program");
            Console.WriteLine("Press 1 to start the stopwatch");
            Console.WriteLine("Press 2 to stop the stopwatch");
            Console.WriteLine("Press 0 to exit the program");
            StopWatch stopwatch = new StopWatch();
            int input = -1;
            do
            {
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        stopwatch.Start();
                        break;
                    case 2:
                        stopwatch.Stop();
                        break;
                    case 0:
                        Console.WriteLine("Bye");
                        break;
                }
            } while (input != 0);
        }
        public void Start()
        {
            if (!_isStart)
            {
                _isStart = true;
                _startTime = DateTime.Now;
                _initialStartTime = _startTime;
                Console.WriteLine("Time started at {0}", _startTime.ToString("HH:mm:ss.ff"));
                Console.WriteLine("Choose desired operation from the options above.");
            }
        }
        public void Stop()
        {
            if (_isStart)
            {
                _isStart = false;
                DateTime stopTime = DateTime.Now;
                TimeSpan timeSpan = stopTime.Subtract(_startTime);
                _totalTimeSpan += timeSpan;
                Console.WriteLine("Time stopped at: {0}", stopTime.ToString("HH:mm:ss.ff"));
                Console.WriteLine("Total Timespan: {0} ", _totalTimeSpan.ToString(@"hh\:mm\:ss\.ff"));
                Console.WriteLine("Choose desired operation from the options above.");
            }

        }
    }
}