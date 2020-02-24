using System;

namespace Midterm
{
    public class Program
    {
        static void Main(string[] args)
        {
            MovieList movieList = new MovieList();

            movieList.InitializeMovieList();

            movieList.AddMovieToList("Pulp Fiction", "Samuel Jackson", "Crime", "Quentin Tarantino");
            movieList.AddMovieToList("Pulp Fiction", "Samuel Jackson", "Crime", "Quentin Tarantino");

            //movieList.DisplayMovieList();

            movieList.MovieSortByName();

            movieList.SearchByDirectorAndDisplay("Quentin Tarantino");

            //movieList.DisplayMovieList();
        }
    }
}
