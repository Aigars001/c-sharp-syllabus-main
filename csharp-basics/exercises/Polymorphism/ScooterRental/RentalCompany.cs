using ScooterRental.Validators;
using ScooterRental.Exceptions;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        public string Name { get; }

        private List<RentedScooter> _rentedScooterList;

        private IScooterService _scooterService;

        public RentalCompany(string name, List<RentedScooter> rentedScooterList, IScooterService scooterService)
        {
            Name = name;
            _rentedScooterList = rentedScooterList;
            _scooterService = scooterService;
        }

        public void StartRent(string id)
        {           
            Validator.IdValidator(id);

            var scooter = _scooterService.GetScooterById(id);

            if (scooter == null)
            {
                throw new ScooterDoesntExistException(id);
            }
                   
            if (_rentedScooterList.Any(s => s.Id == id))
            {
                throw new ScooterAlreadyRentedException(id);
            }
       
            scooter.IsRented = true;
            _rentedScooterList.Add(new RentedScooter(scooter.Id, DateTime.UtcNow, scooter.PricePerMinute));                        
        }

        public decimal EndRent(string id)
        {
            Validator.IdValidator(id);

            var scooter = _scooterService.GetScooterById(id);

            if (scooter == null)
            {
                throw new ScooterDoesntExistException(id);
            }

            var rentedScooter = _rentedScooterList.FirstOrDefault(s => s.Id == id && !s.EndTime.HasValue);
            rentedScooter.EndTime = DateTime.UtcNow;
            scooter.IsRented = false;

            var price = RentPriceCalcualtor.CalculateIncomeForRentedScooter(rentedScooter.StartTime, rentedScooter.EndTime, rentedScooter.PricePerMinute);  

            return price;
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            if (includeNotCompletedRentals == true)
            {
                return AnnualIncomeCalculator.CalculateAnnualIncome(_rentedScooterList, 2022, true);
            }
            else
            {
                return AnnualIncomeCalculator.CalculateAnnualIncome(_rentedScooterList, 2022, false);
            }
        }
    }
}
