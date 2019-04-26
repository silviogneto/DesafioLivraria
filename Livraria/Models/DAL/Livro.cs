using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models.DAL
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string LivroNome { get; set; }
        public string LivroAutor { get; set; }
        public string LivroEditora { get; set; }
        public int LivroAnoPublicacao { get; set; }
    }
}
