using System;
using Midterm;
using Xunit;
using System.Collections.Generic;
using System.Text;

namespace XUnitMidterm
{
    public class MovieList_Test
    {
        [Fact]
        public void Sort_Name_True() //sorts are all the same except for different fields
        {
            MovieList movieList = new MovieList();
            List<Movie> movies = new List<Movie>();

            movieList.InitializeMovieList();

            movieList.AddMovieToList("Pulp Fiction", "Samuel Jackson", "Crime", "Quentin Tarantino");

            movieList.MovieSortByName();

            movies = movieList.ReturnMovieList();

            Assert.Equal("Die Hard", movies[0].MovieName);
        }

        [Fact]
        public void Movie_SortGenre_True() 
        {
            MovieList movieList = new MovieList();
            List<Movie> movies = new List<Movie>();

            movieList.InitializeMovieList();

            movieList.MovieSortByActor();

            movies = movieList.ReturnMovieList();

            Assert.Equal("Brad Pitt", movies[0].MainActor);
        }
        
        [Fact]
        public void Movie_Initialize_Count()
        {
            MovieList movieList = new MovieList();
            List<Movie> movies = new List<Movie>();

            movieList.InitializeMovieList(); //9 movies are initialized as of now. 

            movies = movieList.ReturnMovieList();

            Assert.Equal(9, movies.Count);
        }
    }
}
