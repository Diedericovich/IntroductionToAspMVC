using IntroductionToAspMVC.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IntroductionToAspMVC.ViewModels.Movies
{
    public class MovieEditViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(typeof(DateTime), "01/01/1970", "01/01/2999")]
        [DisplayName("Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(0, 10)]
        public double? Rating { get; set; }

        public Genre Genre { get; set; }
    }
}