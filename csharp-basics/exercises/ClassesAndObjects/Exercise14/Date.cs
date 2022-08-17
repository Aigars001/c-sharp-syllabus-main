using System.Globalization;

namespace Exercise14
{
    internal class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public string WeekdayInDutch()
        {
            CultureInfo netherlands = CultureInfo.CreateSpecificCulture("nl-NL");
            DateTime dateTime = new DateTime(_year, _month, _day);

            return dateTime.ToString("dddd", netherlands);
        }
    }
}
