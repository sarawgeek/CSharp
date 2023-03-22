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
             /* string number1 = "4";
             WriteLine("{0} squared is {1}",
             arg0: number1,
             arg1: Squarer.Square<string>(number1));

             byte number2 = 3;
             WriteLine("{0} squared is {1}",
             arg0: number2,
             arg1: Squarer.Square<byte>(number2)); */

             // Inheriting from classes
             /* Employee john = new Employee
             {
                Name = "John Jones",
                DateOfBirth = new DateTime(1988,8,11),
                EmployeeCode = "P7113090",
                HireDate = new DateTime(2021,10,1)
             };
             john.WriteToConsole();
             //WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");
             WriteLine(john.ToString());

             Employee aliceInEmployee = new Employee
             {
                Name = "Alice",
                EmployeeCode = "7113090"
             };

             Person jackInPerson = new Employee
             {
                Name = "Jack",
                HireDate = new DateTime(2022,10,11)
             };

             //jackInPerson.WriteNew();

             Person aliceInPerson = aliceInEmployee;
             aliceInEmployee.WriteToConsole();
             aliceInPerson.WriteToConsole();
             WriteLine(aliceInEmployee.ToString());
             WriteLine(aliceInPerson.ToString()); */

            // Exceptions
            /* try
            {
                john.TimeToTravel(new DateTime(1990, 10, 21));
                john.TimeToTravel(new DateTime(1985, 10, 21));
            }
            catch (PersonException ex)
            {
                WriteLine(ex.Message);
            } */

            // Extending types when you can't inherit
            string email1 = "jack@mail.com";
            string email2 = "pamela1&.com";

            WriteLine(format:
            "{0} is valid email address: {1}",
            arg0: email1,
            arg1: email1.IsValidMail()
            );

            WriteLine(format:
            "{0} is valid email address: {1}",
            arg0: email2,
            arg1: email2.IsValidMail()
            ); 
        }

        public static void Harry_Shout(object sender, EventArgs args)
        {
            var person = (Person)sender;
            WriteLine($"{person.Name} is this Angry: {person.AngerLevel}");
        }
    }
}
