using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GatewayApi.Controllers
{
    public class LivroController : ProxyBaseController
    {

        public LivroController(
            ILogger<LivroController> logger, 
            IHttpClientFactory httpClientFactory,
            IGatewayService gatewayService) : base(logger,httpClientFactory, gatewayService)
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> GetLivros()
        {
            return Ok(await base.ProxyGetTo<List<Livro>>("Livro"));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLivro(int id)
        {
            return Ok(await base.ProxyGetTo<Livro>($"Livro/{id}"));
        }

        [HttpPost]
        public async Task<IActionResult> Insert(Livro livro)
        {
            var result = await base.ProxyPostTo<Livro>("Livro", livro);
            
            return Created($"~/Api/Proxy/Insert/{result}", result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Livro livro)
        {
            return Ok(await base.ProxyPutTo<Livro>($"Livro/{id}", livro));
        }
    }
}
