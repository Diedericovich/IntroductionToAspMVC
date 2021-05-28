using IntroductionToAspMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Data
{
    public interface IContactRepo: IGenericRepo<Contact>
    {
        Task<IList<Contact>> GetEntitiesAsync();
        Task<Contact> GetEntityAsync(int id);
    }
}