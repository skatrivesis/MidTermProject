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
            movies.Add(new Movie("Pulp Fiction", "Samuel Jackson", "Crime", "Quentin Tarantino"));
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
            Console.WriteLine($"\nMovies directed by >> {input}");
            Header();
            foreach (Movie movie in movies)
            {
                if (input.ToLower() == movie.Director.ToLower())
                {
                    Console.WriteLine(movie);
                }
            }
            Console.WriteLine();
        }
        public void SearchByGenreAndDisplay(string input)
        {
            Console.WriteLine($"\nMovies in the following genre >> {input}");
            Header();
            foreach (Movie movie in movies)
            {
                if (input.ToLower() == movie.Genre.ToLower())
                {
                    Console.WriteLine(movie);
                }
            }
            Console.WriteLine();
        }
        public void SearchByActorAndDisplay(string input)
        {
            Console.WriteLine($"\nMovies with the following actor >> {input}");
            Header();
            foreach (Movie movie in movies)
            {
                if (input.ToLower() == movie.MainActor.ToLower())
                {
                    Console.WriteLine(movie);
                }
            }
            Console.WriteLine();
        }
        public void SearchByNameAndDisplay(string input)
        {
            Console.WriteLine($"\nMovies with the following name >> {input}");
            Header();
            foreach (Movie movie in movies)
            {
                if (input.ToLower() == movie.MovieName.ToLower())
                {
                    Console.WriteLine(movie);
                }
            }
            Console.WriteLine();
        }
        public void DisplayMovieList()
        {
            Header();
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();
        }
        public void Header()
        {
            Console.WriteLine($"\n{"MOVIE TITLE",-25} {"GENRE",-25} {"MAIN ACTOR",-25} {"DIRECTOR",-25}");
            for (int i = 0; i < 100; i++) { Console.Write("="); }
            Console.WriteLine();
        }
        //TODO: see if this is needed, do I need to return the list of movies?
        public List<Movie> ReturnMovieList()
        {
            return movies;
        }
    }
}
