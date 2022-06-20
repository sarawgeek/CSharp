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

            /* WriteLine(sam.Origin);
            WriteLine(sam.Greetings);
            WriteLine(sam.Age); */

            /* sam.FavoriteIceCream = "Chocolate Fudge";
            WriteLine($"{sam.Name}'s favorite ice cream is {sam.FavoriteIceCream}");
            sam.FavoritePrimaryColor = "Red";
            WriteLine($"{sam.Name}'s favorite color is {sam.FavoritePrimaryColor}"); */

            sam.Children.Add(new Person{ Name = "Alice"});
            sam.Children.Add(new Person{ Name = "Ben"});
            sam[1] = new Person{Name = "Chris"};

            /* WriteLine($"{sam.Name}'s First Children is {sam.Children[0].Name}");
            WriteLine($"{sam.Name}'s First Children is {sam.Children[1].Name}");

            WriteLine($"{sam.Name}'s First Children is {sam[0].Name}");
            WriteLine($"{sam.Name}'s First Children is {sam[1].Name}"); */

            object[] passengers = {
                new FirstClassPassenger { AirMiles = 1_419 },
                new FirstClassPassenger { AirMiles = 16_562 },
                new BusinessClassPassenger(),
                new CoachClassPassenger { CarryOnKG = 25.7 },
                new CoachClassPassenger { CarryOnKG = 0 }
            };

            foreach(object passenger in passengers)
            {
                decimal flightCost = passenger switch
                {
                    // C# 8.0 syntax
                    /* FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
                    FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
                    FirstClassPassenger _                         => 2000M, */

                    FirstClassPassenger p => p.AirMiles switch
                    {
                        > 35000 => 1500M,
                        > 15000 => 1750M,
                        _       => 2000M
                    },

                    BusinessClassPassenger _                      => 1000M,
                    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                    CoachClassPassenger _                         => 650M,
                    _                                             => 800M
                };

                //WriteLine($"Flight Costs {flightCost} for {passenger}");
            }


            var jeff = new ImmutablePerson
            {
                FirstName = "Jeff",
                LastName = "Winger"
            };

            var car = new ImmutableVehicle
            {
                Wheels = 4,
                Brand = "Mazda MX-5 RF",
                Color = "Soul Red Crystal Metallic"
            };

            var paintedCar = car with {Color = "PolyMetal grey Metallic"};

            //WriteLine($"Car {car.Brand}'s original color is {car.Color} and new color is {paintedCar.Color}");

            var oscar = new ImmutableAnimal("Oscar", "Labrador");
            var (who, what) = oscar;
            WriteLine($"{who} is {what}");
        }
    }
}
