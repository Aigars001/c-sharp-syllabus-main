using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Odometer
    {
        private FuelGauge _fuelGauge;
        private int _odometerReading;

        public Odometer(FuelGauge fuelGauge)
        {
            _fuelGauge = fuelGauge;
        }

        public int OdometerReading()
        {
            return _odometerReading;
        }

        public void AddMileage()
        {
            if (!_fuelGauge.checkFuelLevel())
            {
                _odometerReading++;
            }

            if (_odometerReading == 1000000)
            {
                _odometerReading = 0;
            }
        }

        public void BurnFuelPerKm()
        {
            if (_odometerReading % 10 == 0)
            {
                _fuelGauge.BurnFuel();
            }
        }
    }
}
