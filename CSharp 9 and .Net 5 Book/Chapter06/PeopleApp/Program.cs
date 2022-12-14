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

            /* WriteLine($"{harry.Name} has {harry.Children.Count} children");
            WriteLine($"{mary.Name} has {mary.Children.Count} children");
            WriteLine($"{jill.Name} has {jill.Children.Count} children");

            WriteLine(
                format:"{0}'s first child name is \"{1}\"",
                arg0: harry.Name,
                arg1: harry.Children[0].Name
            ); */
            
            // Local Function
            //WriteLine($"5! factorial is {Person.Factorial(-1)}");

            // Delegates and Events
            var p1 = new Person{Name = "Harry"};


            p1.Shout += Object_Shout;
            p1.Poke();
            p1.Poke();
            p1.Poke();
            p1.Poke();
        }
        public static void Object_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry {p.AngerLevel}");
        }
    }
}
