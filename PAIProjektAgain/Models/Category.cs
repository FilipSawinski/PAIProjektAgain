using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Models
{
    public class Category
    {
        [Key]
        public virtual string Id { get; set; }
        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "To pole jest wymagane.")]
        public virtual string Name { get; set; }
        [Display(Name = "Czy publiczna?")]
        [Required(ErrorMessage = "To pole jest wymagane.")]
        public virtual bool isPublic { get; set; }
    }
}
