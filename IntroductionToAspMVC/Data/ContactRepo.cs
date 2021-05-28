using IntroductionToAspMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Data
{
    public class ContactRepo : GenericRepo<Contact>, IContactRepo
    {
        public ContactRepo(AspContext context)
            : base(context)
        {
        }

        public override async Task<Contact> GetEntityAsync(int id)
        {
            return await _context.Contacts
                .Include(x => x.Address)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public override async Task<IList<Contact>> GetEntitiesAsync()
        {
            return await _context.Contacts
                .Include(x => x.Address)
                .ToListAsync();
        }

        public override async Task UpdateEntityAsync(Contact contact)
        {
            using var transaction = _context.Database.BeginTransaction();

            _context.Contacts.Attach(contact);
            _context.Contacts.Update(contact);

            _context.Addresses.Attach(contact.Address);
            _context.Addresses.Update(contact.Address);

            await _context.SaveChangesAsync();

            transaction.Commit();
        }
    }
}