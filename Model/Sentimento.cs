using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FellingAPI.Model
{
    public class Sentimento
    {
        public int Id { get; set; }
        public List<string> palavrasChave { get; set; }
        public string Nome { get; set; }
    }
}