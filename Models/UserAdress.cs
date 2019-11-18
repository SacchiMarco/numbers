using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace numbers.Models
{
    public class UserAdress
    {
        
        [Key]
        public int Id { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        [Required]
        [DataType("navrchar(450)")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Feld nicht leer sein")]
        [DataType("navrchar(250)")]
        [Display(Name = "Strasse")]
        public string Street { get; set; }

        [DataType("navrchar(250)")]
        [Display(Name = "Adresszusatz")]
        public string AdressAditional { get; set; }

        [Required(ErrorMessage = "Feld nicht leer sein")]
        [DataType("navrchar(50)")]
        [Display(Name = "Strassennummer")]
        public string StreetNumber { get; set; }

        [Required(ErrorMessage = "Feld nicht leer sein")]
        [DataType("navrchar(100)")]
        [Display(Name = "Stadt")]
        public string City { get; set; }

        [Required(ErrorMessage = "Feld nicht leer sein")]
        [DataType("navrchar(50)")]
        [Display(Name = "Postleitzahl")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Feld nicht leer sein")]
        [DataType("navrchar(50)")]
        [Display(Name ="Land")]
        public string Country { get; set; }

    }
}
