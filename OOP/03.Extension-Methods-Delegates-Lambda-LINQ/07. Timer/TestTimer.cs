//Using delegates write a class Timer that can execute certain method at each t seconds.
namespace _07.Timerr
{
    using System;

    class TestTimer
    {
        static void Main()
        {
            var print = new Action<string>(Console.WriteLine);
            while (true)
            {
                Timer.Execute(print, "Test", 1500);
            }
        }
    }
}
