using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Models
{
    [NotMapped]
    public class AnswerTicketViewModel
    {
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Odpowiedź")]
        public virtual string Answer { get; set; }
        public virtual string Id { get; set; }
        [Display(Name = "Nazwa")]
        public virtual string Name { get; set; }
        [Display(Name = "Opis")]
        public virtual string Description { get; set; }
    }
}
