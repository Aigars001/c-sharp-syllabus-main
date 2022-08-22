using System;

namespace DragRace
{
    public class Tesla : Vehicle
    {
        public override void SpeedUp()
        {
            Speed += rnd.Next(15, 50);
        }

        public override void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }
    }
}