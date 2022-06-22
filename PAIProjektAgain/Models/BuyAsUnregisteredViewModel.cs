using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Models
{
    [NotMapped]
    public class BuyAsUnregisteredViewModel
    {
        public virtual Product prod { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]

        [Display(Name = "Adres")]
        public virtual string Adress { get; set; }
        [RegularExpression(@"^([0-9]{2}-)?[0-9]{3}$", ErrorMessage = "To nie jest poprawny kod pocztowy")]
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Kod pocztowy")]
        public virtual string Zipcode { get; set; }
        public virtual string prodId { get; set; }
    }
}
