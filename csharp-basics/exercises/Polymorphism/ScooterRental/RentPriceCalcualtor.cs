namespace ScooterRental
{
    public class RentPriceCalcualtor
    {
        private static decimal ReturnDailyLimitOrPricePerDay(decimal pricePerDay, decimal limit)
        {
            if (pricePerDay >= limit)
            {
                return limit;
            }
            else
            {
                return pricePerDay;
            }
        }

        public static decimal CalculateIncomeForRentedScooter(DateTime startRent, DateTime? endRent, decimal pricePerMinute)
        {
            var maxPrice = 20m;
            var price = 0m;

            if (startRent.Date == endRent.Value.Date)
            {
                TimeSpan timeSpan = endRent.Value - startRent;
                var tempPrice = (decimal)timeSpan.TotalMinutes * pricePerMinute;

                price = ReturnDailyLimitOrPricePerDay(tempPrice, maxPrice);
            }
 
            if (startRent.Date != endRent.Value.Date)
            {
                var totalDays = (endRent.Value.Date - startRent.Date).TotalDays;
                var firstDayPrice = (1440 - (decimal)startRent.TimeOfDay.TotalMinutes) * pricePerMinute;
                var lastDayPrice = (1440 - (decimal)endRent.Value.TimeOfDay.TotalMinutes) * pricePerMinute;

                for (int i = 0; i <= totalDays; i++)
                {
                    if (i == 0)
                    {
                        price += ReturnDailyLimitOrPricePerDay(firstDayPrice, maxPrice);
                    }
                    else if (i == totalDays)
                    {
                        price += ReturnDailyLimitOrPricePerDay(lastDayPrice, maxPrice);
                    }
                    else
                    {
                        price += maxPrice;
                    }
                }
            }

            return Math.Round(price, 2);
        }
    }
}
