using Actors.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Readers
{
    public class MovieCodeReader
    {
        public List<MovieCode> ReadMovieCodes(string filePath)
        { 
            var movieCodes = new List<MovieCode>();
            using (var reader = new StreamReader(filePath))
            { 
                reader.ReadLine();
                while (!reader.EndOfStream)
                { 
                    var line = reader.ReadLine();
                    var values = line.Split("\t");
                    if ((values[3] == "RU" || values[3] == "US") || (values[4] == "RU" || values[4]=="US"))
                    {
                        movieCodes.Add(new MovieCode(values[0], values[2]));
                    }
                }
            }

            return movieCodes;
        }
    }
}
