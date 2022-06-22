using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Models
{
    [NotMapped]
    public class ProductViewModel
    {
        [Key]
        public virtual string Id { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Nazwa")]
        public virtual string Name { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Opis")]
        public virtual string Description { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Cena")]
        public virtual float Price { get; set; }
        [Display(Name = "Cena po zniżce")]
        public virtual float PriceAfterDiscount { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Liczba dostępnych")]
        public virtual int AvailableNumber { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Range(0, 95, ErrorMessage = "Zniżka musi znajdować się w przedziale 0-95")]
        [Display(Name = "Przecena")]
        public virtual int Discount { get; set; }
        [Display(Name = "Kategoria")]
        [NotMapped]
        public IEnumerable<SelectListItem> Categories { get; set; }
        [Display(Name = "Nazwa kategorii")]
        [NotMapped]
        public virtual string CategoryName { get; set; }

        public virtual string CategoryId { get; set; }
        [Display(Name = "Czy wyróżniony?")]
        public virtual bool isHighlited { get; set; }
    }
}
