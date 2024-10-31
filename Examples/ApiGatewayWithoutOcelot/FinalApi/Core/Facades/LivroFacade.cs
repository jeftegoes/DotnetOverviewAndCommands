using System.Collections.Generic;
using Core.Entities;
using Core.Interfaces;

namespace Core.Facades
{
    public class LivroFacade : ILivroFacade
    {
        private readonly ILivroService _service;

        public LivroFacade(ILivroService service)
        {
            _service = service;
        }

        public List<Livro> GetLivros() =>
            _service.GetLivros();

        public Livro GetLivro(int id) =>
            _service.GetLivro(id);

        public int Insert(Livro livro) =>
            _service.Insert(livro);

        public void Update(int id, Livro livro) =>
            _service.Update(id, livro);
    }
}