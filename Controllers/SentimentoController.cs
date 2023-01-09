using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FellingAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SentimentoController : ControllerBase
    {
        public SentimentoController()
        {

        }
        
        [HttpGet("Sentimento{texto}")]
        public IActionResult AnalizarSentimento(string texto)
        {
            
            return Ok();
        }
    }
}