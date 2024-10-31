using System;

namespace Core.Entities
{
    public class Livro
    {
        public int Id { get; set; }
        public int IdAutor { get; set; }
        public string Nome { get; set; }
        public int NumeroPaginas { get; set; }
    }
}