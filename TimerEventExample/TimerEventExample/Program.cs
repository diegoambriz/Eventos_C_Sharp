using System;
using System.Timers;

namespace TimerEventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer { Interval = 3000 };
            timer.Elapsed+=(sender, e) => Console.WriteLine("El timer se ha ejecutado");
            timer.Start();
            Console.ReadLine();
        }
    }
}
