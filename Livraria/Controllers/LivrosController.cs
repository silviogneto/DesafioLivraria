using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Livraria.Models.DAL.Repositorios;
using Livraria.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        //private readonly ILivroRepositorio _livroRepositorio;

        //public LivrosController(ILivroRepositorio livroRepositorio)
        //{
        //    _livroRepositorio = livroRepositorio;
        //}

        [HttpGet]
        public IEnumerable<LivroDTO> Get()
        {
            return new LivroDTO[] {
                new LivroDTO
                {
                    Id = 1,
                    Nome = "Game of Thrones",
                    Autor = "George R. R. Martin",
                    Editora = "Bantam Spectra",
                    AnoPublicacao = 1996
                },
                new LivroDTO
                {
                    Id = 2,
                    Nome = "Use a Cabeça! C #",
                    Autor = "Andrew Stellma, Jennifer Greene",
                    Editora = "Alta Books",
                    AnoPublicacao = 2008
                }
            };
        }

        [HttpGet("{id}")]
        public LivroDTO Get(int id)
        {
            if (id == 1)
            {
                return new LivroDTO
                {
                    Id = 1,
                    Nome = "Game of Thrones",
                    Autor = "George R. R. Martin",
                    Editora = "Bantam Spectra",
                    AnoPublicacao = 1996
                };
            }
            else if (id == 2)
            {
                return new LivroDTO
                {
                    Id = 2,
                    Nome = "Use a Cabeça! C #",
                    Autor = "Andrew Stellma, Jennifer Greene",
                    Editora = "Alta Books",
                    AnoPublicacao = 2008
                };
            }

            throw new KeyNotFoundException($"Livro com id: {id} não encontrado");
        }

        [HttpPost]
        public void Post([FromBody] LivroDTO value)
        {

        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] LivroDTO value)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}