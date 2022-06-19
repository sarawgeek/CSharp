using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public partial class Person : object
    {
        public Person()
        {
        }
        public Person(string planet)
        {
            HomePlanet = planet;
        }
        public string Name;
        public DateTime DateOfBirth;
        public SevenAncientWonders BucketList;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapiens";

        public readonly string HomePlanet = "Earth";

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name:"Apples", Number:5);
        }
    }

}
