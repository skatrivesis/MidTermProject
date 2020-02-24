using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public class MovieList
    {
        List<Movie> movies = new List<Movie>();

        public void InitializeMovieList()
        {
            movies.Add(new Movie("The Dark Knight", "Christian Bale", "Action", "Christopher Nolan"));
            movies.Add(new Movie("Die Hard", "Bruce Willis", "Action", "John McTiernan"));
        }
        public void MovieSortByActor()
        {
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=netframework-4.8 
            //information on where I got this sort. I don't fully understand it, but with some testing I got it working
            //TODO: look into ways to overload this method so I can save code
            movies.Sort(delegate (Movie x, Movie y)
            {
                if (x.MainActor == null && y.MainActor == null) return 0;
                else if (x.MainActor == null) return -1;
                else if (y.MainActor == null) return 1;
                else return x.MainActor.CompareTo(y.MainActor);
            });
        }
        public void MovieSortByName()
        {
            movies.Sort(delegate (Movie x, Movie y)
            {
                if (x.MovieName == null && y.MovieName == null) return 0;
                else if (x.MovieName == null) return -1;
                else if (y.MovieName == null) return 1;
                else return x.MovieName.CompareTo(y.MovieName);
            });
        }
        public void MovieSortByGenre()
        {
            movies.Sort(delegate (Movie x, Movie y)
            {
                if (x.Genre == null && y.Genre == null) return 0;
                else if (x.Genre == null) return -1;
                else if (y.Genre == null) return 1;
                else return x.Genre.CompareTo(y.Genre);
            });
        }
        public void MovieSortByDirector()
        {
            movies.Sort(delegate (Movie x, Movie y)
            {
                if (x.Director == null && y.Director == null) return 0;
                else if (x.Director == null) return -1;
                else if (y.Director == null) return 1;
                else return x.Director.CompareTo(y.Director);
            });
        }
        public void AddMovieToList(string movieName, string mainActor, string genre, string director)
        {
            movies.Add(new Movie(movieName, mainActor, genre, director));
        }
        public void SearchByDirectorAndDisplay(string input)
        {
            foreach (Movie movie in movies)
            {
                if (input.ToLower() == movie.Director.ToLower())
                {
                    Console.WriteLine(movie);
                }
            }
        }
        public void DisplayMovieList()
        {
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
        public List<Movie> ReturnMovieList()
        {
            return movies;
        }
    }
}
