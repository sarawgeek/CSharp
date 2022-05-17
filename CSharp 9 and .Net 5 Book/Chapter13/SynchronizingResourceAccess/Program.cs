using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace SynchronizingResourceAccess
{
    class Program
    {
        static Random r = new Random();
        static string Message;
        static object conch = new object();
        static void Main(string[] args)
        {
            WriteLine("Please Wait!");
            Stopwatch sw = Stopwatch.StartNew();
            Task a = Task.Factory.StartNew(MethodA);
            Task b = Task.Factory.StartNew(MethodB);
            Task.WaitAll(new Task[]{a,b});
            WriteLine();
            WriteLine($"Result:{Message}");
            WriteLine($"{sw.ElapsedMilliseconds : #,##0} elapsed milliseconds");
        }

        static void MethodA()
        {
            try
            {
                if (Monitor.TryEnter(conch, TimeSpan.FromSeconds(15)))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(r.Next(2000));
                        Message += "A";
                        Write(".");
                    }
                }
                else
                {
                    WriteLine("Method A Failed to Enter Monitor Lock");
                }
            }
            finally
            {
                Monitor.Exit(conch);
            }
        }
        static void MethodB()
        {
            try
            {
                if (Monitor.TryEnter(conch, TimeSpan.FromSeconds(15)))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(r.Next(2000));
                        Message += "B";
                        Write(".");
                    }
                }
                else
                {
                    WriteLine("Method B failed to Enter Monitor Lock");
                }
            }
            finally
            {
                Monitor.Exit(conch);
            }
        }
    }
}
