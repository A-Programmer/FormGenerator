using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Project.ViewModels
{
    public class FormDataViewModel
    {
        public string FormValues { get; set; }
        public IEnumerable<IFormFile> Files { get; set; }
        public string FilesName { get; set; }
        public int FormId { get; set; }
        

    }
}