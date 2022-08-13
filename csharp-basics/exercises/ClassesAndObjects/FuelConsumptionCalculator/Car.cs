using System;

namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers;
        private double _endKilometers;
        private double _liters;

        public Car(double startOdo)
        {
            _startKilometers = startOdo;
        }

        public double EndKilometers
        {
            get { return _endKilometers; }
            set { _endKilometers = value; }
        }
        public double Liters
        {
            get { return _liters; }
            set { _liters = value; }
        }

        public double CalculateConsumption()
        {
            return (_endKilometers - _startKilometers) / _liters;
        }

        private double ConsumptionPer100Km()
        {
            return Math.Round(100/ CalculateConsumption(),2);
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(double mileage, double liters)
        {
            _endKilometers = mileage;
            _liters += liters;
        }
    }
}
