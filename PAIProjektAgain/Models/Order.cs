using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Models
{
    public class Order
    {
        [Key]
        public virtual string Id { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        public virtual List<Product> ProductList { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Adres")]
        public virtual string Adress { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Kod pocztowy")]
        public virtual string Zipcode { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Status")]
        public virtual string Status { get; set; }
        [Display(Name = "Kupujący")]
        public virtual ApplicationUser Buyer { get; set; }
        [Display(Name = "Cena")]
        public virtual float Price { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Data")]
        public virtual DateTime purchaseDateTime { get; set; }
        public virtual ApplicationUser Realizator { get; set; }
    }
}
