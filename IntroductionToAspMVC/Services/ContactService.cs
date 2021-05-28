using IntroductionToAspMVC.Data;
using IntroductionToAspMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Services
{
    public class ContactService : IContactService
    {
        private IContactRepo _contactRepo;
        private IGenericRepo<Address> _addressRepo;

        public ContactService(IContactRepo contactRepo, IGenericRepo<Address> addressRepo)
        {
            _contactRepo = contactRepo;
            _addressRepo = addressRepo;
        }

        public async Task<IList<Contact>> GetContactsAsync()
        {
            return await _contactRepo.GetEntitiesAsync();
        }

        public async Task<Contact> GetContactAsync(int id)
        {
            return await _contactRepo.GetEntityAsync(id);
        }

        public async Task AddContactAsync(Contact contact)
        {
            await _contactRepo.AddEntityAsync(contact);
        }

        public async Task UpdateContactAsync(Contact contact)
        {
            await _contactRepo.UpdateEntityAsync(contact);
        }

        public async Task DeleteContactAsync(Contact contact)
        {
            await _contactRepo.DeleteEntityAsync(contact);
        }
    }
}