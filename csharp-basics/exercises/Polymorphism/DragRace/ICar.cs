using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public interface ICar
    {
        int Speed { get; }
        void SpeedUp();
        void SlowDown();

        string GetName { get; }

        string ShowCurrentSpeed { get; }

        void StartEngine();
    }
}
