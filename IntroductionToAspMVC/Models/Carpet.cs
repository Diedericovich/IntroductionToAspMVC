using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Models
{
    public class Carpet : BaseModel
    {
        public string Texture { get; set; }

        public string Material { get; set; }

        public double SizeSquared { get; set; }

        public bool IsHypoAllergic { get; set; }

        public double Price { get; set; }
    }
}
