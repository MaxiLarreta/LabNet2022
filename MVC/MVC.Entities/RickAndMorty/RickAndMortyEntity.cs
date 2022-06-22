using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Entities.RickAndMorty
{
    public class RickAndMortyEntity
    {
        public Info Info { get; set; }
        public List<Result> Results { get; set; }
    }
}
