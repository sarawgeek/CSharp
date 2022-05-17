using System;
using System.Linq;
using static System.Console;

namespace LinqWithObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqWithArrayOfExceptions();
        }

        static void LinqWithArrayOfStrings()
        {
            string[] names = { "Ram", "Pam", "Shyam", "Jim", "Mike", "Angela", "Kevin", "Creed", "Dwight", "Michael" };
            //var query = names.Where(new Func<string, bool>(NameLongerThanFour));
            //var query = names.Where(NameLongerThanFour);
            var query = names
                .Where(name => name.Length >4)
                .OrderBy(name => name.Length)
                .ThenBy(name => name);
            foreach (string name in query)
            {
                WriteLine(name);
            }
        }

        static bool NameLongerThanFour(string name)
        {
            return name.Length > 4;
        }

        static void LinqWithArrayOfExceptions()
        {
            var errors = new Exception[]
            {
                new ArgumentException(),
                new SystemException(),
                new IndexOutOfRangeException(),
                new InvalidOperationException(),
                new NullReferenceException(),
                new InvalidCastException(),
                new OverflowException(),
                new DivideByZeroException(),
                new ApplicationException()
            };
            var numberErrors = errors.OfType<ArithmeticException>();
            foreach (var error in numberErrors)
            {
                WriteLine(error);
            }
        }
    }


}
