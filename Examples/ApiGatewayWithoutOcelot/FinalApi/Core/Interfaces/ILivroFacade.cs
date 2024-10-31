using System.Collections.Generic;
using Core.Entities;

namespace Core.Interfaces
{
    public interface ILivroFacade
    {
         List<Livro> GetLivros();
         Livro GetLivro(int id);
         int Insert(Livro livro);
         void Update(int id, Livro livro);
    }
}