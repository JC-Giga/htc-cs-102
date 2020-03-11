using System;
using System.Windows;

namespace MovieList
{
    public class Movie
    {
        public string Title
        {
            get;
            set;
        }

        public int ReleaseYear
        {
            get;
            set;
        }

        public int Rating
        {
            get;
            set;
        }

        public void ShowDetails()
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            infoString += "\nUser Rating: " + this.Rating;
            MessageBox.Show(infoString);
        }

        public Movie(string myTitle, int myReleaseYear, int myRating)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
            this.Rating = myRating;
        }
    }
}
