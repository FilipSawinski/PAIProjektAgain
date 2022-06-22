using Microsoft.AspNetCore.Http;
using PAIProjektAgain.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Controllers
{
    public class AddPhotoViewModel
    {
        [MaxFileSizeAttribute(5 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".jpeg", ".png" })]
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Zdjęcie")]
        public IFormFile photo { get; set; }
        public virtual string Id { get; set; }
    }
}
