using System;

namespace IntroductionToAspMVC.ViewModels.Contacts
{
    public class ContactDetailViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Emailadres { get; set; }

        public string Telephone { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public int Bus { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}