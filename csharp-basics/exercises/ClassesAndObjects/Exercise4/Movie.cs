using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        public static List<Movie> GetPg(Movie[] arr)
        {
            List<Movie> pgArray = new List<Movie>();

            foreach (var i in arr)
            {
                if (i._rating == "PG")
                {
                    pgArray.Add(i);
                }
            }
            return pgArray;
        }

        public void PrintMovie()
        {
            Console.WriteLine($"{_title} from {_studio} is rated: {_rating}");
        }
    }
}
