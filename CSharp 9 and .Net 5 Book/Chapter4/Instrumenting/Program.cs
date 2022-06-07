using System.Diagnostics;
using static System.Console;
using System.IO;
// See https://aka.ms/new-console-template for more information

MainDebug();

static void MainDebug()
{
    Trace.Listeners.Add(new TextWriterTraceListener(File.Create("log.txt")));

    Trace.AutoFlush = true;
    Debug.WriteLine("Debug says, I am watching!");
    Trace.WriteLine("Trace says, I am watching!");
}




