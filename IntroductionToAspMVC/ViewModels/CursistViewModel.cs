using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.ViewModels
{
    public class CursistViewModel
    {
        public int Id { get; set; }

        [DisplayName("Voornaam")]
        [Required(ErrorMessage = "Voornaam is verplicht")]
        [MinLength(3, ErrorMessage ="Tenminste 3 karakters")]
        [MaxLength(20, ErrorMessage = "Tenminste 20 karakters")]
        public string FirstName { get; set; }

        [DisplayName("Achternaam")]
        [Required(ErrorMessage = "Achternaam is verplicht")]
        public string LastName { get; set; }

        public ICollection<string> Courses { get; set; }

        [DisplayName("Leeftijd")]
        [Required(ErrorMessage = "Leeftijd is verplicht")]
        [Range(12, 18)]
        public int? Age { get; set; }

        [DisplayName("Datum van geboorte")]
        [Required(ErrorMessage = "Geboortedatum is verplicht")]
        [Range(typeof(DateTime), "01/01/1970", "01/01/2003")]
        public DateTime? DateOfBirth { get; set; }

        [DisplayName("Geslacht")]
        [Required(ErrorMessage = "Geslacht is verplicht")]
        public int Gender { get; set; }
    }
}
