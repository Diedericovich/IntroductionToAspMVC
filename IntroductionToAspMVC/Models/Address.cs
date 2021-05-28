using System.ComponentModel.DataAnnotations;

namespace IntroductionToAspMVC.Models
{
    public class Address : BaseModel
    {
        [MaxLength(100)]
        public string Street { get; set; }

        public int Number { get; set; }

        public int Bus { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }

        [MaxLength(100)]
        public string City { get; set; }
    }
}