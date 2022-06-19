using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp {
    public class PeopleApp{

        public static void Main(string[] args)
        {
            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965,12,22);
            bob.BucketList = 
            SevenAncientWonders.StatueOfZeusAtOlympia 
            | SevenAncientWonders.MausoleumAtHalicarnassus;
            
            bob.Children.Add(new Person{Name = "Alfred"});            ;
            bob.Children.Add(new Person{Name = "Zoe"});

            var alice = new Person("Venus");
            alice.Name = "Alice";
            alice.DateOfBirth = new DateTime(1970, 10, 14);

            //var unknown = new Person();
            //alice.HomePlanet = "Venus";

            /* WriteLine(
                format:"{0} was born on {1:dddd, d MMMM yyyy}",
                arg0:bob.Name, 
                arg1:bob.DateOfBirth
            ); */

           /*  WriteLine(
                format:"{0}'s bucket list is {1}.",
                arg0:bob.Name, 
                arg1:bob.BucketList
            ); */

            /* WriteLine($"{bob.Name} has {bob.Children.Count} children:");
            foreach(var child in bob.Children)
            {
                WriteLine($"{child.Name}");
            } */

            BankAccount.InterestRate = 0.012M; // store a shared value

            /* var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mr. Jones";
            jonesAccount.AccountBalance = 2400;

            WriteLine(format:"{0} earned {1:C} interest",
            arg0:jonesAccount.AccountName,
            arg1:jonesAccount.AccountBalance* BankAccount.InterestRate);

            var gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Mrs. Gerrier";
            gerrierAccount.AccountBalance = 98;

            WriteLine(format:"{0} earned {1:C} interest",
            arg0:gerrierAccount.AccountName,
            arg1:gerrierAccount.AccountBalance * BankAccount.InterestRate); */

            //WriteLine($"{bob.Name} is {Person.Species}");

            /* WriteLine($"{bob.Name} is born on {bob.HomePlanet}");
            WriteLine($"{alice.Name} is born on {alice.HomePlanet}"); */

            //WriteLine($"{unknown.Name} is created on planet {unknown.HomePlanet}");
            
            /* bob.WriteToConsole();
            WriteLine(bob.GetOrigin()); */

            /* (string, int) fruit = bob.GetFruit();
            WriteLine($"{fruit.Item1}, {fruit.Item2} there are"); */

            /* var namedFruit = bob.GetNamedFruit();
            WriteLine($"{namedFruit.Name}, {namedFruit.Number} there are"); */

            var sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1975,4,11)
            };

            WriteLine(sam.Origin);
            WriteLine(sam.Greetings);
            WriteLine(sam.Age);

            sam.FavoriteIceCream = "Chocolate Fudge";
            WriteLine($"{sam.Name}'s favorite ice cream is {sam.FavoriteIceCream}");
            sam.FavoritePrimaryColor = "Purple";
            WriteLine($"{sam.Name}'s favorite color is {sam.FavoritePrimaryColor}");
        }
    }
}
