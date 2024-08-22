using Microsoft.AspNetCore.Http;

namespace ProjetctUploadFile.ViewModels
{
    public class FormDataViewModel
    {
        public string FieldA { get; set; }
        public string FieldB { get; set; }
        public IFormFile File { get; set; }
    }
}