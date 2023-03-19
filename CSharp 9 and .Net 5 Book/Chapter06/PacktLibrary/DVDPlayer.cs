using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class DVDPlayer : IPlayer
    {
        public void Pause()
        {
            WriteLine("Pausing DVD Player");
        }

        public void Play()
        {
            WriteLine("Playing DVD Player");
        }
    }
}