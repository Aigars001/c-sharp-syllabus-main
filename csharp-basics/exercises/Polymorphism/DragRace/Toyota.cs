using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Toyota : Vehicle, IBoost
    {
        public void UseNitrousOxideEngine()
        {
            Speed += 30;
        }
    }
}
