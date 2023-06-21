using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace Packt.Shared
{
    public static class Squarer
    {
        public static double Square<T>(T input) 
        where T : IConvertible
        {
            double d = input.ToDouble(Thread.CurrentThread.CurrentCulture);
            return d * d;
        }
    }
}