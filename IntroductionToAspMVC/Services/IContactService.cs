using IntroductionToAspMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Services
{
    public interface IContactService
    {
        Task AddContactAsync(Contact contact);
        Task DeleteContactAsync(Contact contact);
        Task<Contact> GetContactAsync(int id);
        Task<IList<Contact>> GetContactsAsync();
        Task UpdateContactAsync(Contact contact);
    }
}