﻿using System;
using System.Linq;
using MonitoringLib;
using static System.Console;

namespace MonitoringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*WriteLine("Processing. Please wait...");
            Recorder.Start();

            int[] largeArray = Enumerable.Range(1,10_000).ToArray();
            System.Threading.Thread.Sleep(new Random().Next(5,10)*1000);

            Recorder.Stop();*/

            int[] numbers = Enumerable.Range(1,50_000).ToArray();
            WriteLine("Using String Adding +");
            Recorder.Start();
            string s = "";
            for(int i =0; i< numbers.Length; i++)
            {
                s += numbers[i] + ", ";
            }
            Recorder.Stop();
            WriteLine("Using StringBuilder");
            Recorder.Start();
            var builder = new System.Text.StringBuilder();
            for(int i=0; i< numbers.Length; i++)
            {
                builder.Append(numbers[i]); builder.Append(", ");
            }
            Recorder.Stop();
            
        }
    }
}
