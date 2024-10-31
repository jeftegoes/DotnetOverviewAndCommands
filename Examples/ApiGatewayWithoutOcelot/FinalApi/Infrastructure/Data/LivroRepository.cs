using System.Collections.Generic;
using System.Linq;
using Core.Entities;
using Core.Mappers;
using Core.Interfaces;

namespace Infrastructure.Data
{
    public class LivroRepository : ILivroRepository
    {
        public List<Livro> livros { get; set; } = new List<Livro>() {
                new Livro { Id = 1, Nome = "Capitães da Areia", NumeroPaginas = 343, IdAutor = 1 },
                new Livro { Id = 2, Nome = "Tieta", NumeroPaginas = 256, IdAutor = 1 }
        };

        public List<Livro> GetLivros()
        {
            return livros;
        }

        public Livro GetLivro(int id)
        {
            return livros.SingleOrDefault(c => c.Id == id);
        }

        public int Insert(Livro livro)
        {
            livros.Add(livro);

            return livro.Id;
        }

        public void Update(int id, Livro livro)
        {
            var livroInDb = livros.SingleOrDefault(c => c.Id == id);

            if (livroInDb != null)
            {
                livroInDb.ToLivro(livro);
            }
        }
    }
}