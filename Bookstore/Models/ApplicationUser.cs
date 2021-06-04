using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FavouriteBook { get; set; }
        public string FavouriteGenre { get; set; }
        public DateTime LogginInSince { get; set; }

    }
}
