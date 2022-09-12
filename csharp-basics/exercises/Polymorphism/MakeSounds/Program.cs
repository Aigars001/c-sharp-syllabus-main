using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {

            var parrot1 = new Parrot();
            var parrot2 = new Parrot();

            var radio1 = new Radio();
            var radio2 = new Radio();

            var firework1 = new Firework();
            var firework2 = new Firework();

            var list = new List<ISound>()
            {
                parrot1,parrot2, radio1, radio2, firework1, firework2
            };

            foreach (var sound in list)
            {
                sound.PlaySound();
            }

            Console.ReadKey();
        }
    }
}