using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PAIProjektAgain.Models
{
    [NotMapped]
    public class SearchByIdViewModel
    {
        [Key]
        public virtual string Id { get; set; }
    }
}
