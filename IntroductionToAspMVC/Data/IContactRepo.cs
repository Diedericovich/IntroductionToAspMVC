using IntroductionToAspMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroductionToAspMVC.Data
{
    public interface IContactRepo: IGenericRepo<Contact>
    {
    }
}