using IntroductionToAspMVC.Enums;
using System;

namespace IntroductionToAspMVC.Models
{
    public class Movie: BaseModel
    {
        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public double Rating { get; set; }

        public Genre Genre { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}