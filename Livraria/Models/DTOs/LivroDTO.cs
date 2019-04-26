using System;

namespace Livraria.Models.DTOs
{
    public class LivroDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int AnoPublicacao { get; set; }
    }
}
