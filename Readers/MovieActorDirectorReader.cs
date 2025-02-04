using Actors.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Readers
{
    public class MovieActorDirectorReader
    {
        public List<MovieActorDirector> ReadMovieActorDirector(string filePath)
        {
            var movieActorsDirectors = new List<MovieActorDirector>();
            using (var reader = new StreamReader(filePath)) 
            {
                reader.ReadLine();
                while (!reader.EndOfStream) 
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');
                    movieActorsDirectors.Add(new MovieActorDirector(values[0], values[2], values[3]));
                }
            }

            return movieActorsDirectors;
        }
    }
}
