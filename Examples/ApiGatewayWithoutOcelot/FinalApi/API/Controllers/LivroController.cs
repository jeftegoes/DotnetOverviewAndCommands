using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivroController : ControllerBase
    {

        private readonly ILogger<LivroController> _logger;
        private readonly ILivroFacade _facade;

        public LivroController(ILogger<LivroController> logger, ILivroFacade facade)
        {
            _logger = logger;
            _facade = facade;
        }

        [HttpGet]
        public IActionResult GetLivros()
        {
            return Ok(_facade.GetLivros());
        }

        [HttpGet("{id}")]
        public IActionResult GetLivro(int id)
        {
            return Ok(_facade.GetLivro(id));
        }

        [HttpPost]
        public IActionResult Insert(Livro livro)
        {
            var id = _facade.Insert(livro);
            
            return Ok(id);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Livro livro)
        {
            _facade.Update(id, livro);
            
            return Ok();
        }
    }
}
