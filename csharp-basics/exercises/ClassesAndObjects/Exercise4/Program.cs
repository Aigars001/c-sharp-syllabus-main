using System;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie[] movies =
            {
                new Movie("Casino Royale", "Eon Productions", "PG­13"),
                new Movie("Glass", "Buena Vista International", "PG­13"),
                new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures")
            };

            List<Movie> moviesList = Movie.GetPg(movies);

            foreach (var film in moviesList)
            {
                film.PrintMovie();
            }

            Console.ReadKey();
        }
    }
}