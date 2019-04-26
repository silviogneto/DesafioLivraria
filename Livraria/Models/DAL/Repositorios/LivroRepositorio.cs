using System.Collections.Generic;
using System.Linq;

namespace Livraria.Models.DAL.Repositorios
{
    public class LivroRepositorio : ILivroRepositorio
    {
        private readonly LivrariaContext _context;

        public LivroRepositorio(LivrariaContext context)
        {
            _context = context;
        }

        public IEnumerable<Livro> Get()
        {
            return _context.Livros;
        }

        public Livro Get(int id)
        {
            return _context.Livros.Single(x => x.LivroId == id);
        }

        public void Add(Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }

        public void Update(Livro livro)
        {
            _context.Livros.Update(livro);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var livro = _context.Livros.SingleOrDefault(x => x.LivroId == id);
            if (livro != null)
            {
                _context.Livros.Remove(livro);
                _context.SaveChanges();
            }
        }
    }
}
