using Core.Entities;

namespace Core.Mappers
{
    public static class LivroMapper
    {
        public static void ToLivro(this Livro livro, Livro livroInDb)
        {
            livro.Id = livroInDb.Id;
            livro.IdAutor = livroInDb.IdAutor;
            livro.Nome = livroInDb.Nome;
            livro.NumeroPaginas = livroInDb.NumeroPaginas;
        }
    }
}