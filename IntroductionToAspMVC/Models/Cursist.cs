using IntroductionToAspMVC.Enums;
using System.Collections.Generic;

namespace IntroductionToAspMVC.Models
{
    public class Cursist: BaseModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<string> Courses { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }
    }
}