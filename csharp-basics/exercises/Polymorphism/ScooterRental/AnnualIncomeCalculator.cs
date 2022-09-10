namespace ScooterRental
{
    public class AnnualIncomeCalculator
    {
        public static decimal CalculateAnnualIncome(List<RentedScooter> rentedScooters, int? year, bool includeNotCompleteRentals)
        {
            decimal result = 0;

            switch(includeNotCompleteRentals)
            {
                case true when year == (DateTime.UtcNow.Year):
                {
                    foreach(var rented in rentedScooters)
                    {
                        if(!rented.EndTime.HasValue)
                        {
                            rented.EndTime = DateTime.UtcNow;
                            result += RentPriceCalcualtor.CalculateIncomeForRentedScooter(rented.StartTime, rented.EndTime, rented.PricePerMinute);
                        }
                        else
                        {
                            if(year == rented.EndTime.Value.Year)
                            {
                                result += RentPriceCalcualtor.CalculateIncomeForRentedScooter(rented.StartTime, rented.EndTime, rented.PricePerMinute);
                            }
                        }
                    }

                break;

                }

                default:
                {
                    foreach (var rented in rentedScooters)
                    {
                        if (rented.EndTime.HasValue)
                        {
                            result += RentPriceCalcualtor.CalculateIncomeForRentedScooter(rented.StartTime, rented.EndTime, rented.PricePerMinute);
                        }
                    }

                    break;
                }
            }

            return result;
        }

    }
}
