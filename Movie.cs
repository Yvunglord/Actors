using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors
{
    public class Movie
    {
        public string Title { get; set; }
        public HashSet<string> Actors { get; set; } 
        public string Directors { get; set;}
        public HashSet<string> Tags { get; set; } 
        public double Rating { get; set; }

        public Movie(string title)
        {
            Title = title;
            Actors = new HashSet<string>();
            Tags = new HashSet<string>();
        }
    }
}
