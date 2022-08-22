using System;

namespace DragRace
{
    public class Lexus : Vehicle, IBoost
    {
        public void UseNitrousOxideEngine() 
        {
            Speed += 30;
        }
    }
}