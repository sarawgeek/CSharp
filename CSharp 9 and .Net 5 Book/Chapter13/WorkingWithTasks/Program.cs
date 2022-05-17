using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using static System.Console;

namespace WorkingWithTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            /*WriteLine("Running methods Synchronously on one thread");
            MethodA();
            MethodB();
            MethodC();*/

            /*WriteLine("Running methods asynchronously on multiple threads");
            Task taskA = new Task(MethodA);
            taskA.Start();
            Task taskB = Task.Factory.StartNew(MethodB);
            Task taskC = Task.Run(new Action(MethodC));

            Task[] tasks = {taskA, taskB, taskC};
            Task.WaitAll(tasks);*/

            WriteLine("Passing the result of one task to another");

            var taskCallWebServiceThenStoredProcedure = Task.Factory.StartNew(CallWebService)
                                                        .ContinueWith(previousResult => 
                                                        CallStoredProcedure(previousResult.Result));

            WriteLine($"Result:{taskCallWebServiceThenStoredProcedure.Result}");
            WriteLine($"{timer.ElapsedMilliseconds:#,##0} ms elapsed.");
            //Console.WriteLine("Hello World!");
        }
        static void MethodA()
        {
            WriteLine("Starting Method A");
            Thread.Sleep(3000);
            WriteLine("Finished Method A");
        }

        static void MethodB()
        {
            WriteLine("Starting Method B");
            Thread.Sleep(2000);
            WriteLine("Finished Method B");
        }

        static void MethodC()
        {
            WriteLine("Starting Method C");
            Thread.Sleep(1000);
            WriteLine("Finished Method C");
        }

        static decimal CallWebService()
        {
            WriteLine("Starting Call to Web Service");
            Thread.Sleep((new Random()).Next(2000,4000));
            WriteLine("Finished Call to Web Service");
            return 89.99M;
        }

        static string CallStoredProcedure(decimal amount)
        {
            WriteLine("Starting call to Stored Procedure");
            Thread.Sleep((new Random()).Next(2000,4000));
            WriteLine("Finishing call to Stored Procedure");
            return $"12 product costs more than {amount:C}.";
        }
    }
}
