using Actors.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Readers
{
    public class PersonDataReader
    {
        public List<PersonData> ReadPersonData(string filePath)
        { 
            var personData = new List<PersonData>();
            using (var reader = new StreamReader(filePath))
            { 
                reader.ReadLine();
                while (!reader.EndOfStream) 
                {
                    var line = reader.ReadLine();
                    var values = line.Split('\t');
                    personData.Add(new PersonData(values[0], values[1], values[4]));
                }
            }

            return personData;
        }
    }
}
