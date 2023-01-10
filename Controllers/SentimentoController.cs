using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FellingAPI.Entities;
using FellingAPI.Context;

namespace FellingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SentimentoController : ControllerBase
    {
        private readonly SentimentoDB _context;
        public SentimentoController(SentimentoDB contexto)
        {
            _context = contexto;
        }

        [HttpGet("AnalisarSentimento")]
        public IActionResult AnalisarSentimento(string texto)
        {
            var sentimentos = _context.Sentimentos.ToList();
            var keywords = _context.Keywords.ToList();
            var sentimento = "";
            var w = "";
            foreach (var k in keywords)
            {

                if (texto.Contains(k.Grafia))
                {
                    w = k.Grafia;
                    var s = _context.Sentimentos.Find(k.SentimentoId);
                    sentimento = s.Nome;
                }
            }

            return Ok($"Sentimento é de: {sentimento} a palavra encontrada foi: {w}");

        }

        [HttpPost("Cadastrar")]
        public IActionResult Create(Sentimento sentimento)
        {
            _context.Add(sentimento);
            _context.SaveChanges();
            return Created("", sentimento);
        }

        [HttpGet("TodosOsSentimentos")]
        public IActionResult GetSentimentos()
        {
            var sentimentos = _context.Sentimentos.ToList();
            var keywords = _context.Keywords.ToList();

            for (int i = 0; i < sentimentos.Count; i++)
            {
                sentimentos[i].Keywords = keywords;
            }

            return Ok(sentimentos);
        }
    }
}