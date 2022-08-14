using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class FuelGauge
    {
        private int _fuelLevel;

        public int ReportFuelLevel()
        {
            return _fuelLevel;
        }

        public bool checkFuelLevel()
        {
            bool isEmpty = false;
            if (_fuelLevel < 1)
            {
                isEmpty = true;
                Console.WriteLine("You are out of fuel");
            }
            return isEmpty;
        }

        public void FillUp()
        {
            if (_fuelLevel < 70)
            {
                _fuelLevel++;
            }
        }

        public void BurnFuel()
        {
            if (!checkFuelLevel())
            {
                _fuelLevel--;
            }
        }
    }
}
