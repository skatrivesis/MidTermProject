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
        public void Sort_Name_True()
        {
            MovieList movieList = new MovieList();
            List<Movie> movies = new List<Movie>();

            movieList.InitializeMovieList();

            movieList.AddMovieToList("Pulp Fiction", "Samuel Jackson", "Crime", "Quentin Tarantino");

            movieList.MovieSortByName();

            movies = movieList.ReturnMovieList();

            Assert.Equal("Die Hard", movies[0].MovieName);
        }
    }
}
