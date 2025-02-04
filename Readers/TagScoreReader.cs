using Actors.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Actors.Readers
{
    public class TagScoreReader
    {
        public List<TagScore> ReadTagScores(string filePath)
        { 
            var tagScores = new List<TagScore>();
            using (var reader = new StreamReader(filePath))
            { 
                reader.ReadLine();
                while (!reader.EndOfStream) 
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (double.Parse(values[2], CultureInfo.InvariantCulture) > 0.5)
                    { 
                        tagScores.Add(new TagScore(values[0], values[1], double.Parse(values[2], CultureInfo.InvariantCulture)));
                    }                    
                }
            }

            return tagScores;
        }
    }
}
