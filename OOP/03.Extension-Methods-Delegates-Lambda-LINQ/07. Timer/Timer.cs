namespace _07.Timerr
{
    using System;
    using System.Threading;

    public class Timer
    {
        public static void Execute<T>(Action<T> method, T param, int interval)
        {
            method(param);
            Thread.Sleep(interval);
        }
    }
}
