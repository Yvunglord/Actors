using Actors.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Readers
{
    public class TagCodeReader
    {
        public List<TagCode> ReadTagCodes(string filePath)
        { 
            var tagCodes = new List<TagCode>();
            using (var reader = new StreamReader(filePath))
            {
                reader.ReadLine();
                while (!reader.EndOfStream) 
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    tagCodes.Add(new TagCode(values[0], values[1]));
                }
            }

            return tagCodes;
        }
    }
}
