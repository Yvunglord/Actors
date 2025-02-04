using Actors.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Actors.Readers
{
    public class RatingReader
    {
        public List<Rating> ReadRatings(string filePath)
        { 
            var ratings = new List<Rating>();
            using (var reader = new StreamReader(filePath))
            {
                reader.ReadLine();
                while (!reader.EndOfStream) 
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');
                    ratings.Add(new Rating(values[0], double.Parse(values[1], CultureInfo.InvariantCulture)));
                }
            }

            return ratings;
        }
    }
}
