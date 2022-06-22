using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Models
{
    public class Product
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
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Display(Name = "Ilość")]
        public virtual int AvailableNumber { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Range(0, 95, ErrorMessage = "Zniżka musi znajdować się w przedziale 0-95")]
        [Display(Name = "Przecena")]
        public virtual int Discount { get; set; }
        [Display(Name = "Kategoria")]
        public virtual Category Category { get; set; }
        [Display(Name = "Ścieżka do zdjęcia")]
        public virtual string photoPath { get; set; }
        [Display(Name = "Czy wyróżnione")]
        public virtual bool isHighlighted { get; set; }
    }
}
