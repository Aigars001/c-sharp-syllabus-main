using System;

namespace DragRace
{
    public class Tesla : Vehicle
    {
        private string _name = "Tesla";
        public override void SpeedUp()
        {
            Speed += rnd.Next(15, 40);
        }

        public override void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }
    }
}