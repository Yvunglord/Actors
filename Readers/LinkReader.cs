using Actors.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Readers
{
    public class LinkReader
    {
        public List<Link> ReadLinks(string filePath)
        { 
            var links = new List<Link>();
            using (var reader = new StreamReader(filePath))
            { 
                reader.ReadLine();
                while (!reader.EndOfStream) 
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    links.Add(new Link(values[1], values[0]));
                }
            }

            return links;
        }
    }
}
