using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Models.DAL
{
    public class LivrariaContext : DbContext
    {
        public virtual DbSet<Livro> Livros { get; set; }

        public LivrariaContext(DbContextOptions<LivrariaContext> options) : base(options)
        {
        }
    }
}
