using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FellingAPI.Entities
{
    public class Keyword
    {
        public int Id { get; set; }
        public string Grafia { get; set; }
        public int SentimentoId { get; set; }
    }
}