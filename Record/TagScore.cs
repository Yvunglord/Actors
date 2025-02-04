using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actors.Record
{
    public record TagScore(string MovieId, string TagId, double Relevance);
}
