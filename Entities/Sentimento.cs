using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FellingAPI.Entities
{
    public class Sentimento
    {
        public int Id { get; set; }
        public List<Keyword> Keywords { get; set; }
        public string Nome { get; set; }
    }
}