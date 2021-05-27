using IntroductionToAspMVC.Models;
using System.Collections.Generic;

namespace IntroductionToAspMVC.ViewModels
{
    public class MovieViewModel
    {
        public ICollection<Movie> Movies { get; set; }
    }
}