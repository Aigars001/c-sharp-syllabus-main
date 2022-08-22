using System;

namespace DragRace
{
    public class Lexus : Vehicle, IBoost
    {

        private string _name = "Lexus";

        public void UseNitrousOxideEngine() 
        {
            Speed += 10;
        }

    }
}