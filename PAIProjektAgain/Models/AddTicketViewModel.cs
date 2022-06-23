using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Models
{
    [NotMapped]
    public class AddTicketViewModel
    {
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Nazwa")]
        public virtual string Name { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Opis")]
        public virtual string Description { get; set; }
    }
}
