using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mary = new Person { Name = "Mary" };
            var harry = new Person { Name = "Harry" };
            var jill = new Person { Name = "Jill" };

            var baby1 = mary.ProcreateWith(harry);
            baby1.Name = "Garry";

            var baby2 = Person.Procreate(harry, jill);

            var baby3 = harry * mary;
            harry.Shout += Harry_Shout;
            // harry.Poke();
            // harry.Poke();
            // harry.Poke();
            // harry.Poke();

            /* WriteLine($"{harry.Name} has {harry.Children.Count} children");
            /* WriteLine($"{harry.Name} has {harry.Children.Count} children");
            WriteLine($"{mary.Name} has {mary.Children.Count} children");
            WriteLine($"{jill.Name} has {jill.Children.Count} children");

            WriteLine(
                format:"{0}'s first child name is \"{1}\"",
                arg0: harry.Name,
                arg1: harry.Children[0].Name
            ); */

            //WriteLine($"5! value is {Person.Factorial(5)}");

            // Implementing Interfaces
            /* Person[] people =
            {
                new Person { Name = "Simon"},
                new Person { Name = "Jenny" },
                new Person { Name = "Adam" },
                new Person { Name = "Richard" }
            };
             WriteLine("Initial list of people");
             foreach(var person in people)
             {
                WriteLine($"{person.Name}");
             }

             Array.Sort(people, new PersonComparer());
             WriteLine("Sorted list of people");
             foreach(var person in people)
             {
                WriteLine($"{person.Name}");
             } */

             // Working with Generic Types
             /* var obj1 = new GenericThing<int>();
             obj1.Data = 42;
             WriteLine(obj1.Process(42));

             var obj2 = new GenericThing<string>();
             obj2.Data = "hello";
             WriteLine(obj2.Process("hello")); */

             // Working with Generic Methods
             
        }

        public static void Harry_Shout(object sender, EventArgs args)
        {
            var person = (Person)sender;
            WriteLine($"{person.Name} is this Angry: {person.AngerLevel}");
        }
    }
}
