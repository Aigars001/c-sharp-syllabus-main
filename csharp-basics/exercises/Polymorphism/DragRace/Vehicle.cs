using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DragRace
{
    public class Vehicle : ICar
    {
        public int Speed
        { get; protected set; }

        private string _name { get; }

        public Random rnd;

        public Vehicle()
        {
            rnd = new Random();
            Speed = 0;
            ShowCurrentSpeed = Speed.ToString();
            GetName = _name;
        }

        public virtual void SpeedUp()
        {
            Speed += rnd.Next(5, 30);
        }

        public void SlowDown()
        {
            Speed -= rnd.Next(5, 30);
        }

        public string ShowCurrentSpeed
        { get;  }

        public virtual void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
        public string GetName
        { get; }

    }
}
