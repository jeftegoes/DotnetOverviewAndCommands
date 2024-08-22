using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProjetctUploadFile.ViewModels;

namespace ProjetctUploadFile.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UploadFileController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        public UploadFileController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpPost]
        public async Task<IActionResult> PostTest([FromForm] FormDataViewModel viewModel)
        {
            if (!ModelState.IsValid) {
                return BadRequest();
            }

            if (viewModel.File == null || viewModel.File.Length == 0)  {
                return BadRequest("Arquivo inválido ou não informado.");
            }

            string filePath = _env.WebRootPath + "\\FilesUploaded\\Files";

            using(var stream = new FileStream(filePath + viewModel.File.FileName, FileMode.Create)){
                await viewModel.File.CopyToAsync(stream);
            }

            return Ok();
        }
    }
}