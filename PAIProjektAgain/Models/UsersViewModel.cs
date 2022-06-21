using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Models
{
    public class UsersViewModel
    {
        [Key]
        public string Id { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        public Boolean isAdmin { get; set; }
    }
}
