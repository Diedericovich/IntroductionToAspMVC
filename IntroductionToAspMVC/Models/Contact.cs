using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Models
{
    public class Contact: BaseModel
    {

        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(200)]
        public string Emailadres { get; set; }

        [MaxLength(50)]
        public string Telephone { get; set; }

        public Address Address { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
