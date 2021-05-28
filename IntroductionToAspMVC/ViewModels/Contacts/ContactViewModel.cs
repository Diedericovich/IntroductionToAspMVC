using IntroductionToAspMVC.Models;
using System.Collections.Generic;

namespace IntroductionToAspMVC.ViewModels.Contacts
{
    public class ContactViewModel
    {
        public ICollection<Contact> Contacts { get; set; }
    }
}