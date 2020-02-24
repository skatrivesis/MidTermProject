using System;
using System.Collections.Generic;
using System.Text;

namespace Midterm
{
    public class Movie
    {
        private string movieName;
        private string mainActor;
        private string genre;
        private string director;

        public Movie(string movieName, string mainActor, string genre, string director)
        {
            this.movieName = movieName;
            this.mainActor = mainActor;
            this.genre = genre;
            this.director = director;
        }

        public string MovieName { get => movieName; set => movieName = value; }
        public string MainActor { get => mainActor; set => mainActor = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Director { get => director; set => director = value; }


        public override string ToString()
        {
            return $"{movieName, -25}|{genre,-25}|{mainActor, -25}|{director, -25}";
        }
    }
}
