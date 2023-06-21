using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person //: IComparable<Person>
    {
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>(); 

        public virtual void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd}");
        }

        public void TimeToTravel(DateTime when)
        {
            if(when <= DateOfBirth)
            throw new PersonException("If you travel back in time to a date earlier than your own birth, then the universe will explode!");
            else WriteLine($"Welcome to {when:yyyy}");
        }

        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);

            return baby;
        }

        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }


        public static int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentException(
                    $"{nameof(number)} cannot be less than zero."
                );
            }
            return localFactorial(number);

            int localFactorial(int n)
            {
                if(n <= 1) return 1;
                return n * localFactorial(n-1);
            }
        }

        public event EventHandler Shout;

        public int AngerLevel;

        public void Poke()
        {
            AngerLevel++;
            if(AngerLevel >= 3)
            Shout?.Invoke(this, EventArgs.Empty);
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
        //var d = new Shout(ShoutEvent);
        /* public void ShoutEvent(object sender, EventArgs e)
        {
            WriteLine($"Shout Event is called");
        } */
    }
}
