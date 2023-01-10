using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FellingAPI.Context;
using FellingAPI.Controllers;
using FellingAPI.Entities;

namespace FellingAPI.Context
{
    public class SentimentoDB : DbContext
    {
        public SentimentoDB(DbContextOptions options): base(options)
        {

        }

        public DbSet<Sentimento> Sentimentos { get; set; }
        public DbSet<Keyword> Keywords { get; set; }

    }
}