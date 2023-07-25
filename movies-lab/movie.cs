using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movies_database
{
    internal class Movie
    {
        //properties
        public string Title { get; set; }
        public string Category { get; set; }
        public int YearReleased { get; set; }
        public int Runtime { get; set; }

        //constructor
        public Movie(string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }

        //overloaded constructor
        public Movie(string _title, string _category, int _yearReleased, int _runtime)
        {
            Title = _title;
            Category = _category;
            YearReleased = _yearReleased;
            Runtime = _runtime;
        }
    }
}

//Justin's flow
//1. Make class 