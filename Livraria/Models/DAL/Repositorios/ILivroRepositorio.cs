using System.Collections.Generic;

namespace Livraria.Models.DAL.Repositorios
{
    public interface ILivroRepositorio
    {
        IEnumerable<Livro> Get();
        Livro Get(int id);
        void Add(Livro livro);
        void Update(Livro livro);
        void Delete(int id);
    }
}
