using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public interface IPlayer
    {
        void Play();
        void Pause();
        void Stop()
        {
            WriteLine("Default Stopping");
        }   
    }
}