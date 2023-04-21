using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Movie
    {
        public string moviename;
        public string moviedirector;

        // Getters & Setters 
        private string rating;
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "R")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

        public Movie(string aMoviename, string aMoviedirector, string aRating)
        {
            moviename = aMoviename;
            moviedirector = aMoviedirector;
            Rating = aRating; // getters & setters protection
        }
    }
}
