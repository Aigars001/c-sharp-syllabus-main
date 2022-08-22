using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Toyota : Vehicle, IBoost
    {
        private string _name = "Toyota";

        public void UseNitrousOxideEngine()
        {
            Speed += 10;
        }
    }
}
