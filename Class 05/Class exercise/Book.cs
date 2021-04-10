using System;
using System.Collections.Generic;
using System.Text;

namespace Class_exercise
{
    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; } = 0;
        public int Rating { get; set; } = 0;

        public Book()
        {

        }
        public Book(string author, string title, int year)
        {
            Author = author;
            Title = title;
            Year = year;
        }
        public Book(string author, string title, int year, int pages)
        {
            Author = author;
            Title = title;
            Year = year;
            Pages = pages;
        }
        public Book(string author, string title, int year, int pages, int rating)
        {
            Author = author;
            Title = title;
            Year = year;
            Pages = pages;
            Rating = rating;
        }

        public string BookSummary()
        {
            string summury = "This is a short book summary from the author that is born in the city in that country";
            return summury;
        }
        public string AuthorInfo()
        {
            string info = "Author was born in that year in that counrty his first book was that book and so on and so on";
            return info;
        }
    }
}
