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

        private string _name;

        public Random rnd;

        public Vehicle()
        {
            rnd = new Random();
            Speed = 0;
        }

        public virtual void SpeedUp()
        {
            Speed += rnd.Next(10, 40);
        }

        public void SlowDown()
        {
            if(Speed > 0)
            {
                Speed -= rnd.Next(10, 40);
                if(Speed < 0)
                {
                    Speed = 0;
                }
            }
            else
            {
                Speed = 0;
            }
        }

        public string ShowCurrentSpeed
        {
            get => Speed.ToString();
        }

        public virtual void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
