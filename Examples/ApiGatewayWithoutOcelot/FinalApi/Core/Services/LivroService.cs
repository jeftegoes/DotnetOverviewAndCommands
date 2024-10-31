using System.Collections.Generic;
using Core.Entities;
using Core.Interfaces;

namespace Core.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _repository;

        public LivroService(ILivroRepository repository)
        {
            _repository = repository;
        }

        public List<Livro> GetLivros() => 
            _repository.GetLivros();

        public Livro GetLivro(int id)
            => _repository.GetLivro(id);

        public int Insert(Livro livro) 
            => _repository.Insert(livro);

        public void Update(int id, Livro livro) 
            => _repository.Update(id, livro);
    }
}