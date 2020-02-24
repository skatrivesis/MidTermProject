using System;
using Midterm;
using Xunit;
using System.Collections.Generic;

namespace XUnitMidterm
{
    public class Movie_Test
    {
        [Fact]
        public void Movie_Exist_True()
        {
            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie("Die Hard", "Bruce Willis", "Action", "John McTiernan"));

            Assert.Equal("Bruce Willis", movies[0].MainActor);
        }
    }
}
