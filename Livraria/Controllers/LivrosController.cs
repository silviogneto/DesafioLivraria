using System.Collections.Generic;
using System.Linq;
using Livraria.Models.DAL;
using Livraria.Models.DAL.Repositorios;
using Livraria.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroRepositorio _livroRepositorio;

        public LivrosController(ILivroRepositorio livroRepositorio)
        {
            _livroRepositorio = livroRepositorio;
        }

        [HttpGet]
        public IEnumerable<LivroDTO> Get()
        {
            return _livroRepositorio.Get().Select(x => LivroDTO.ToDto(x)).OrderBy(x => x.Nome);
        }

        [HttpGet("{id}")]
        public LivroDTO Get(int id)
        {
            var livro = _livroRepositorio.Get(id);

            return LivroDTO.ToDto(livro);
        }

        [HttpPost]
        public void Post([FromBody] LivroDTO value)
        {
            _livroRepositorio.Add(new Livro
            {
                LivroNome = value.Nome,
                LivroAutor = value.Autor,
                LivroEditora = value.Editora,
                LivroAnoPublicacao = value.AnoPublicacao
            });
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] LivroDTO value)
        {
            var livro = _livroRepositorio.Get(id);
            if (livro != null)
            {
                livro.LivroNome = value.Nome;
                livro.LivroAutor = value.Autor;
                livro.LivroEditora = value.Editora;
                livro.LivroAnoPublicacao = value.AnoPublicacao;

                _livroRepositorio.Update(livro);
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _livroRepositorio.Delete(id);
        }
    }
}