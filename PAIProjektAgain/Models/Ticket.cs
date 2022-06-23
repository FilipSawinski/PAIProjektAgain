using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Models
{
    public class Ticket
    {
        [Key]
        public virtual string Id { get; set; }
        public virtual ApplicationUser Realizator { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Użytkownik")]
        public virtual ApplicationUser User { get; set; }
        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "To pole jest wymagane.")]
        public virtual string Name { get; set; }
        [Display(Name = "Opis")]
        [Required(ErrorMessage = "To pole jest wymagane.")]
        public virtual string Description { get; set; }
        [Display(Name = "Odpowiedź")]
        public virtual string Answer { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Czy zamknięte?")]
        public virtual bool isClosed { get; set; }
    }
}
