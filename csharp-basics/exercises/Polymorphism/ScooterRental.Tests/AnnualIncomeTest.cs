using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScooterRental.Tests
{
    [TestClass]
    public class AnnualIncomeTest
    {
        private IScooterService _scooterService;
        private IRentalCompany _company;
        private List<Scooter> _inventory;
        private List<RentedScooter> _rentedScooters;

        [TestInitialize]
        public void Setup()
        {
            _inventory = new List<Scooter>();
            _scooterService = new ScooterService(_inventory);
            _rentedScooters = new List<RentedScooter>();
            _company = new RentalCompany("CompanyName", _rentedScooters, _scooterService);
            _scooterService.AddScooter("1", 0.2m);
            _scooterService.AddScooter("2", 0.2m);
            _scooterService.AddScooter("3", 0.2m);
        }

        [TestMethod]
        public void AnnualIncomeTest_Year2022_IncludingNotFinishedRentals()
        {
            //Arrange
            var rentedScooter1 = new RentedScooter("1", DateTime.UtcNow.AddMinutes(-21600), 0.2m);
            var rentedScooter2 = new RentedScooter("2", DateTime.UtcNow.AddMinutes(-10), 0.2m);

            //Act
            _rentedScooters.Add(rentedScooter1);
            _rentedScooters.Add(rentedScooter2);
            _company.EndRent("2");

            //Assert
            var result = AnnualIncomeCalculator.CalculateAnnualIncome(_rentedScooters, 2022, true);
            result.Should().Be(322);
        }

        [TestMethod]
        public void AnnualIncomeTest_Year2022_ExcludingNotFinishedRentals()
        {
            //Arrange
            var rentedScooter1 = new RentedScooter("1", DateTime.UtcNow.AddMinutes(-21600), 0.2m);
            var rentedScooter2 = new RentedScooter("2", DateTime.UtcNow.AddMinutes(-10), 0.2m);

            //Act
            _rentedScooters.Add(rentedScooter1);
            _rentedScooters.Add(rentedScooter2);
            _company.EndRent("2");

            //Assert
            var result = AnnualIncomeCalculator.CalculateAnnualIncome(_rentedScooters, 2022, false);
            result.Should().Be(2);
        }
    }
}
