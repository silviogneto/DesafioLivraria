using Livraria.Models.DAL;

namespace Livraria.Models.DTOs
{
    public class LivroDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int AnoPublicacao { get; set; }

        public static LivroDTO ToDto(Livro livro)
        {
            return new LivroDTO
            {
                Id = livro.LivroId,
                Nome = livro.LivroNome,
                Autor = livro.LivroAutor,
                Editora = livro.LivroEditora,
                AnoPublicacao = livro.LivroAnoPublicacao
            };
        }
    }
}
